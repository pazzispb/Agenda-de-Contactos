using AgendaContactos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class Categorias : Form
    {
        bool adding = true; //true si se va a agregar o false si se va a modificar una categoria
        Categoria categoria = null; //Categoria a eliminar o actualizar
        List<Categoria> listadoCategoria;
        public Categorias()
        {
            InitializeComponent();
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Permite que las columnas se ajuste el ancho de manera automatica
            SetEstadoInicial();
        }
        void SetEstadoInicial()
        {
            gbDatos.Enabled = true;
            btnBorrar.Enabled = false;
            categoria = null;
            BorrarCampos();
            CargarCategorias();
            adding = true;
        }
        void BorrarCampos()
        {
            txtDescripcion.Clear();
            txtNombre.Clear();
            chkIsVisible.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetEstadoInicial();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var json = new Json();
            if (ValidarCamposVacios()) //si hay campos vacios
            {
                MessageBox.Show("Rellene los campos vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvCategorias.DataSource == null)
                listadoCategorias = new List<Categoria>();
            if (!ValidarNombreUnico(txtNombre.Text)) //si no es unico
            {
                MessageBox.Show("El nombre que introdujo ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var categoria = new Categoria()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                isVisible = chkIsVisible.Checked
            };
            if (adding)
            {
                listadoCategoria.Add(categoria);
            }
            else
            {
                listadoCategoria[listadoCategoria.IndexOf(this.categoria)].Nombre = categoria.Nombre;
                listadoCategoria[listadoCategoria.IndexOf(this.categoria)].Descripcion = categoria.Descripcion;
                listadoCategoria[listadoCategoria.IndexOf(this.categoria)].isVisible = categoria.isVisible;
            }
            json.GuardarCategorias(listadoCategoria);
            MessageBox.Show("Cambios guardados con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetEstadoInicial();
        }
        bool ValidarCamposVacios()//responde a la pregunta de: hay campos obligatorios vacios?
        {
            return (String.IsNullOrWhiteSpace(txtNombre.Text));
        }
        bool ValidarNombreUnico(string nombre)//responde a la pregunta de: hay otras categorias con el nombre que se intenta registrar o modificar
        {
            if (adding)//si se esta agregando una categoria nueva
            {
                if (listadoCategoria == null) return true;
                var cantidad = listadoCategoria.Count(x=>x.Nombre == nombre);//cuentas categorias con ese mismo nombre hay en el json
                return (cantidad < 1);//true si es unico, false si no lo es
            }
            else
            {
                if (listadoCategoria == null) return true;
                var cantidad = listadoCategoria.Count(x => (x.Nombre == nombre) && (x.Nombre!=categoria.Nombre));//cuentas categorias con ese mismo nombre hay en el json
                return (cantidad < 1);//true si es unico, false si no lo es
            }
        }
        void CargarCategorias()
        {
            var json = new Json();
            dgvCategorias.DataSource = null;
            listadoCategoria = json.ObtenerCategorias();
            dgvCategorias.DataSource = listadoCategoria;//carga el listado de categorias al datagrid
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var nombre = dgvCategorias.CurrentRow.Cells["Nombre"].Value.ToString(); //almacena el nombre de la categoria
                categoria = listadoCategoria.FirstOrDefault(x => x.Nombre == nombre); //almacena el objeto categoria
                adding = false;
                btnBorrar.Enabled = true;
                txtNombre.Text = nombre;
                txtDescripcion.Text = categoria.Descripcion;
                chkIsVisible.Checked = categoria.isVisible;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro que desea borrar la categoría?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var json = new Json();
            if(DialogResult == DialogResult.Yes)
            {
                listadoCategoria.Remove(categoria);
                json.GuardarCategorias(listadoCategoria);
                SetEstadoInicial();
            }
        }
    }
}
