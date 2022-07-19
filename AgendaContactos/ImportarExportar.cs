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
        bool exportar = true; //true para exportar, false para importar
        List<Contacto> listadoContacto = new List<Contacto>();
        public ImportarExportar()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ConfigurarExportacion(); //pone el formulario en modo exportacion
        }
        void ConfigurarDataGrid() //configura la apariencia y comportamiento del datagrid
        {
            foreach (DataGridViewColumn column in dgvContactos.Columns) //recorre cada una de las columnas del datagrid
            {
                if (column.Name != "Seleccion") column.ReadOnly = true; //si la columna no se llama seleccion, ponla en modo de solo lectura
            }
            //invisiviliza los siguientes campos
            dgvContactos.Columns["Id"].Visible = false;
            dgvContactos.Columns["isFavorito"].Visible = false;
            dgvContactos.Columns["isEmergencia"].Visible = false;
            dgvContactos.Columns["UrlFoto"].Visible = false;
            dgvContactos.AutoResizeColumns();
        }
        void ConfigurarExportacion()
        {
            lblMensaje.Text = "Seleccione los contactos a exportar";
            HabilitarControles();
            CargarContactos();
            ConfigurarDataGrid();
            exportar = true; //modo exportacion
        }
        void ConfigurarImportacion()
        {
            OpenFileDialog fd = new OpenFileDialog();//ventana para seleccionar un archivo
            fd.Filter = "Export Files|*.exp"; //archivo especifico para las exportaciones del programa
            DialogResult resultado = fd.ShowDialog(); //almacena el resultado de la ventana de dialogo
            exportar = false; //modo de importacion
            if(resultado == DialogResult.OK) //si el usuario clickeo ok en la ventana
            {
                if (File.Exists(fd.FileName)) //si el archivo existe
                {
                    lblMensaje.Text = "Seleccione los contactos a importar";
                    HabilitarControles();
                    CargarContactos("importacion", fd.FileName); //carga los contactos del archivo seleccionado al datagrid
                    ConfigurarDataGrid();
                }
                else
                {
                    MessageBox.Show("El archivo no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        void HabilitarControles() //habilita los elementos del formulario
        {
            btnSeleccionarTodos.Enabled = true;
            dgvContactos.Enabled = true;
            btnGuardarCambios.Enabled = true;
            btnCancelar.Enabled = true;
        }
        void DeshabilitarControles() //deshabilita los elementos del formulario
        {
            btnSeleccionarTodos.Enabled = false;
            dgvContactos.Enabled = false;
            btnGuardarCambios.Enabled = false;
            btnCancelar.Enabled = false;
        }
        void CargarContactos(string modo = "exportacion", string ubicacion = "") //por default estara en modo exportacion
        {
            var json = new Json();
            if (modo == "exportacion") listadoContacto = json.ObtenerContactos(); //si esta en modo exportacion carga los contactos del archivo json del programa a la lista
            else listadoContacto = json.ObtenerContactos(ubicacion); //si esta en modo importacion, carga los contactos del archivo que se selecciono para importar a la lista
            if (listadoContacto == null) listadoContacto = new List<Contacto>(); //si la lista esta vacia, crea una lista nueva
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
                }).ToList(); //selecciona solo los campos anteriores del objeto Contacto y los almacena en una nueva Lista
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = nuevo; //carga la lista al datagridview
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //si no se clickeo dentro del encabezado del datagrid
            {
                if (e.ColumnIndex > 0) //si no se clickeo en la celda de seleccion
                {
                    if ((Boolean)dgvContactos.CurrentRow.Cells["Seleccion"].Value == true) //si el valor de la celda de seleccion esta chequeado
                        dgvContactos.CurrentRow.Cells["Seleccion"].Value = false; //deschequealo
                    else dgvContactos.CurrentRow.Cells["Seleccion"].Value = true; //sino, chequealo
                }
            }
        }
        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            if (dgvContactos.RowCount>0) //si el datagrid tiene registros
            {
                foreach(DataGridViewRow row in dgvContactos.Rows) //recorre cada uno de los registros
                {
                    row.Cells["Seleccion"].Value = true; //pon el valor de la celda de seleccion como chequeado
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ConfigurarImportacion(); //modo de importacion
        }
        void SetEstadoInicial()
        {
            DeshabilitarControles();
            dgvContactos.DataSource = null;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetEstadoInicial();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            var json = new Json();
            var lista = new List<Contacto>();//lista de contactos a exportar o importar
            var contador = 0; //contador para saber cuantos contactos se seleccionaron del datagrid
            foreach (DataGridViewRow row in dgvContactos.Rows) //recorre cada una de las filas del datagrid
            {
                if ((Boolean)row.Cells["Seleccion"].Value == true) //si el contacto esta seleccionado
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
                    }; //crea un objeto contacto con la informacion de la fila
                    if (exportar == false)//si esta en modo de importacion
                    {
                        if (!ValidarNombreUnico(contacto.Nombres + " " + contacto.Apellidos, lista)) //valida que el contacto no exista ya dentro del archivo json del sistema
                        {
                            MessageBox.Show("De los seleccionados, hay un contacto que ya existe dentro del sistema", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; //finaliza la funcion si ya existe
                        }
                    }
                    lista.Add(contacto); //agrega a la lista el contacto
                }
            }
            if (contador == 0) //si no se selecciono ningun contacto
            {
                MessageBox.Show("Seleccione contactos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            
            if(exportar == true) //si esta en modo de exportacion
            {
                FolderBrowserDialog fb = new FolderBrowserDialog(); //cuadro de dialogo para seleccionar una carpeta
                DialogResult resultado = fb.ShowDialog(); //almacena el resultado del cuadro de dialogo
                if (resultado == DialogResult.OK) //si el usuario clickeo ok
                {
                    var ruta = $"{fb.SelectedPath}//contactos({DateTime.Now.ToString("MM-dd-yyyy HH_mm_ss")}).exp"; //arma la ruta para almacenar el archivo
                    json.GuardarContactos(lista, ruta); //guarda el archivo en esa ruta
                    MessageBox.Show($"Contactos exportados con exito\nLa ruta del archivo es: {ruta}", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //si esta en modo importacion
            {
                json.ImportarContactos(lista); //guarda los contactos importados del archivo
                AgregarCategorias(lista);//en caso de que no existan las categorias, agregalas
                MessageBox.Show("Contactos agregados con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SetEstadoInicial();
        }
        void AgregarCategorias(List<Contacto> lista)
        {
            var json = new Json();
            var listaCategoria = json.ObtenerCategorias();//carga las categorias actuales del sistema
            foreach(Contacto c in lista)//recorre la lista de los contactos nuevos
            {
                if (!string.IsNullOrWhiteSpace(c.Categoria))//si el campo no esta vacio
                {
                    if (listaCategoria.Count(x => x.Nombre.ToLower().Trim() == c.Categoria.ToLower().Trim()) == 0) //si la categoria no existe dentro del programa
                        listaCategoria.Add(new Categoria { Nombre = c.Categoria, isVisible = true });//agrega la categoria a la lista
                }
            }
            json.GuardarCategorias(listaCategoria);//guarda el nuevo listado de categorias
        }
        bool ValidarNombreUnico(string nombre, List<Contacto> lista)//responde a la pregunta de: hay otros contactos con el nombre que se intenta registrar
        {
            var json = new Json();
            listadoContacto = json.ObtenerContactos();
            if (listadoContacto.Concat(lista) == null) return true; //si la lista esta vacia
            var cantidad = listadoContacto.Concat(lista).Count(x => (x.Nombres + " " + x.Apellidos).ToLower().Trim() == nombre.ToLower().Trim());//cuentos contactos con ese mismo nombre hay en el json
            return (cantidad < 1);//true si es unico, false si no lo es           
        }

    }
}