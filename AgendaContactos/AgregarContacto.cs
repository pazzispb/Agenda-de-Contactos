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
    public partial class AgregarContacto : Form
    {
        bool adding = true; //true si se va a agregar o false si se va a modificar una categoria
        Contacto contacto = null; //Categoria a eliminar o actualizar
        List<Contacto> listadoContacto;

        public AgregarContacto()
        {
            InitializeComponent();
        }

        void SetEstadoInicial()
        {
            gbDatosPersonales.Enabled = true;
            bttnCancelar.Enabled = false;
            contacto = null;
            BorrarCampos();
            CargarContactos();
            adding = true;
        }
        void BorrarCampos()
        {
            foreach (Control c in gbDatosPersonales.Controls) //bucle que recorre todos los datos del panel | hasta encontrar alguno vacio
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            txtBoxNombre.Clear();
            pbFoto.Image = null;
        }

        bool ValidarCamposObligatorios()//responde a la pregunta de: hay campos obligatorios vacios?
        {
            return (String.IsNullOrWhiteSpace(txtBoxNombre.Text));
        }
        bool ValidarNombreUnico(string nombre)//responde a la pregunta de: hay otras categorias con el nombre que se intenta registrar o modificar
        {
            if (adding)//si se esta agregando una categoria nueva
            {
                if (listadoContacto == null) return true;
                var cantidad = listadoContacto.Count(x => x.Nombres == nombre);//cuentas categorias con ese mismo nombre hay en el json
                return (cantidad < 1);//true si es unico, false si no lo es
            }
            else
            {
                if (listadoContacto == null) return true;
                var cantidad = listadoContacto.Count(x => (x.Nombres == nombre) && (x.Nombres != contacto.Nombres));//cuentas categorias con ese mismo nombre hay en el json
                return (cantidad < 1);//true si es unico, false si no lo es
            }
        }
        void CargarContactos()
        {
            var json = new Json();
            //dgvCategorias.DataSource = null;
            listadoContacto = json.ObtenerContactos();
            if (listadoContacto == null) listadoContacto = new List<Contacto>();
            //dgvCategorias.DataSource = listadoCategoria;//carga el listado de categorias al datagrid
        }


        private void bttnCrear_Click(object sender, EventArgs e)
        {
            var json = new Json();
            if (ValidarCamposObligatorios()) //si hay campos vacios
            {
                MessageBox.Show("Rellene los campos vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarNombreUnico(txtBoxNombre.Text)) //si no es unico
            {
                MessageBox.Show("El nombre que introdujo ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var contacto = new Contacto()
            {
                Nombres = txtBoxNombre.Text,
                Apellidos = txtBoxApellido.Text,
                Descripcion = txtBoxDescripcion.Text,
            };

            if (adding)
            {
                listadoContacto.Add(contacto);
            }
            else
            {
                listadoContacto[listadoContacto.IndexOf(this.contacto)].Nombres = contacto.Nombres;
                listadoContacto[listadoContacto.IndexOf(this.contacto)].Apellidos = contacto.Apellidos;
                listadoContacto[listadoContacto.IndexOf(this.contacto)].Descripcion = contacto.Descripcion;
            }

            json.GuardarContactos(listadoContacto);
            MessageBox.Show("Cambios guardados con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetEstadoInicial();
        }
        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            SetEstadoInicial();
        }
    }
}
