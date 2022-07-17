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
        Contacto contacto = null; //contacto a crear
        List<Contacto> listadoContacto = null;

        public AgregarContacto()
        {
            InitializeComponent();
            SetEstadoInicial();
        }

        void SetEstadoInicial()
        {
            gbDatosPersonales.Enabled = true;
            bttnCancelar.Enabled = true;
            contacto = null;
            BorrarCampos();
            CargarContactos();
        }
        void BorrarCampos()
        {
            foreach (Control c in gbDatosPersonales.Controls) //bucle que recorre todos los datos del panel | hasta encontrar alguno vacio
            {
                if (c is TextBox || c is MaskedTextBox)
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
        bool ValidarNombreUnico(string nombre)//responde a la pregunta de: hay otros contactos con el nombre que se intenta registrar
        {
            if (listadoContacto == null) return true;
            var cantidad = listadoContacto.Count(x => x.Nombres == nombre);//cuentos contactos con ese mismo nombre hay en el json
            return (cantidad < 1);//true si es unico, false si no lo es           
        }
        void CargarContactos()
        {
            var json = new Json();
            listadoContacto = json.ObtenerContactos();
            if (listadoContacto == null) listadoContacto = new List<Contacto>();
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
            contacto = new Contacto()
            {
                Nombres = txtBoxNombre.Text,
                Apellidos = txtBoxApellido.Text,
                Descripcion = txtBoxDescripcion.Text,
            };
            listadoContacto.Add(contacto);
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
