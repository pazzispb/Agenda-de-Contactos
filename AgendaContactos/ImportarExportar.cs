using AgendaContactos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class ImportarExportar : Form
    {
        bool exportar = true;
        List<Contacto> listadoContacto = new List<Contacto>();
        public ImportarExportar()
        {
            InitializeComponent();
            dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Permite que las columnas se ajuste el ancho de manera automatica

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ConfigurarExportacion();
        }
        void ConfigurarDataGrid()
        {
            foreach (DataGridViewColumn column in dgvContactos.Columns)
            {
                if (column.Name != "Seleccion") column.ReadOnly = true;
            }
            dgvContactos.Columns["Id"].Visible = false;
            dgvContactos.Columns["isFavorito"].Visible = false;
            dgvContactos.Columns["isEmergencia"].Visible = false;
            dgvContactos.Columns["UrlFoto"].Visible = false;

            dgvContactos.AutoResizeColumns();
        }
        void ConfigurarExportacion()
        {
            SetEstadoInicial();
            lblMensaje.Text = "Seleccione los contactos a exportar";
            HabilitarControles();
            CargarContactos();
            ConfigurarDataGrid();
            exportar = true;
        }
        void ConfigurarImportacion()
        {
            SetEstadoInicial();
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Export Files|*.exp";
            DialogResult resultado = fd.ShowDialog();
            exportar = false;
            if(resultado == DialogResult.OK)
            {
                if (File.Exists(fd.FileName))
                {
                    lblMensaje.Text = "Seleccione los contactos a importar";
                    HabilitarControles();
                    CargarContactos("importacion", fd.FileName);
                    ConfigurarDataGrid();
                }
                else
                {
                    MessageBox.Show("El archivo no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        void HabilitarControles()
        {
            btnSeleccionarTodos.Enabled = true;
            dgvContactos.Enabled = true;
            btnGuardarCambios.Enabled = true;
            btnCancelar.Enabled = true;
        }
        void DeshabilitarControles()
        {
            btnSeleccionarTodos.Enabled = false;
            dgvContactos.Enabled = false;
            btnGuardarCambios.Enabled = false;
            btnCancelar.Enabled = false;
        }
        void CargarContactos(string modo = "exportacion", string ubicacion = "")
        {
            var json = new Json();
            if (modo == "exportacion") listadoContacto = json.ObtenerContactos();
            else listadoContacto = json.ObtenerContactos(ubicacion);
            if (listadoContacto == null) listadoContacto = new List<Contacto>();
            var nuevo = listadoContacto
                .Select(x => new ContactoExportado
                {
                    Seleccion = false,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    TelefonoPersonal = x.TelefonoPersonal,
                    TelefonoTrabajo = x.TelefonoTrabajo,
                    TelefonoResidencial = x.TelefonoResidencial,
                    Categoria = x.Categoria,
                    FechaNacimiento = x.FechaNacimiento,
                    CorreoElectronico = x.CorreoElectronico,
                    Descripcion = x.Descripcion,
                    Apodo = x.Apodo
                }).ToList();
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = nuevo;
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex > 0)
                {
                    if ((Boolean)dgvContactos.CurrentRow.Cells["Seleccion"].Value == true) dgvContactos.CurrentRow.Cells["Seleccion"].Value = false;
                    else dgvContactos.CurrentRow.Cells["Seleccion"].Value = true;
                }
            }
        }
        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            if (dgvContactos.RowCount>0)
            {
                foreach(DataGridViewRow row in dgvContactos.Rows)
                {
                    row.Cells["Seleccion"].Value = true;
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ConfigurarImportacion();
        }
        void SetEstadoInicial()
        {
            dgvContactos.DataSource = null;
            DeshabilitarControles();
            exportar = true;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetEstadoInicial();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            var json = new Json();
            var lista = new List<Contacto>();
            var contador = 0;
            foreach (DataGridViewRow row in dgvContactos.Rows)
            {
                if ((Boolean)row.Cells["Seleccion"].Value == true)
                {
                    contador++;
                    var contacto = new Contacto
                    {
                        Nombres = (string)row.Cells["Nombres"].Value,
                        Apellidos = (string)row.Cells["Apellidos"].Value,
                        TelefonoPersonal = (string)row.Cells["TelefonoPersonal"].Value,
                        TelefonoTrabajo = (string)row.Cells["TelefonoTrabajo"].Value,
                        TelefonoResidencial = (string)row.Cells["TelefonoResidencial"].Value,
                        Categoria = (string)row.Cells["Categoria"].Value,
                        FechaNacimiento = (DateTime)row.Cells["FechaNacimiento"].Value,
                        CorreoElectronico = (string)row.Cells["CorreoElectronico"].Value,
                        Descripcion = (string)row.Cells["Descripcion"].Value,
                        Apodo = (string)row.Cells["Apodo"].Value
                    };
                    if (exportar == false)
                    {
                        if (!ValidarNombreUnico(contacto.Nombres + " " + contacto.Apellidos, lista))
                        {
                            MessageBox.Show("De los seleccionados, hay un contacto que ya existe dentro del sistema", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    lista.Add(contacto);
                }
            }
            if (contador == 0) 
            {
                MessageBox.Show("Seleccione contactos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            
            if(exportar == true)
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();
                DialogResult resultado = fb.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    var ruta = $"{fb.SelectedPath}//contactos({DateTime.Now.ToString("MM-dd-yyyy HH_mm_ss")}).exp";
                    json.GuardarContactos(lista, ruta);
                    MessageBox.Show($"Contactos exportados con exito\nLa ruta del archivo es: {ruta}", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                json.ImportarContactos(lista);
            }
            SetEstadoInicial();
        }
        void AgregarCategorias(List<Contacto> lista)
        {
            var json = new Json();
            var listaCategoria = json.ObtenerCategorias();
            foreach(Contacto c in lista)
            {
                if (!string.IsNullOrWhiteSpace(c.Categoria))
                {
                    if (listaCategoria.Count(x => x.Nombre.ToLower().Trim() == c.Categoria.ToLower().Trim()) == 0)
                        listaCategoria.Add(new Categoria { Nombre = c.Categoria });
                }
            }
            json.GuardarCategorias(listaCategoria);
        }
        bool ValidarNombreUnico(string nombre, List<Contacto> lista)//responde a la pregunta de: hay otros contactos con el nombre que se intenta registrar
        {
            var json = new Json();
            if (json.ObtenerContactos().Concat(lista) == null) return true;
            var cantidad = listadoContacto.Concat(lista).Count(x => (x.Nombres + " " + x.Apellidos).ToLower().Trim() == nombre.ToLower().Trim());//cuentos contactos con ese mismo nombre hay en el json
            return (cantidad < 1);//true si es unico, false si no lo es           
        }

    }
}
