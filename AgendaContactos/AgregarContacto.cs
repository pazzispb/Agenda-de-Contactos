using AgendaContactos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class AgregarContacto : Form
    {
        int id; //Id del contacto 
        Contacto contacto = null; //contacto a crear
        List<Contacto> listadoContacto = null;
        Categoria categoria = null; //Categoria a eliminar o actualizar
        List<Categoria> listadoCategoria;

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
            pbFoto.ImageLocation = null;
        }

        bool ValidarCamposObligatorios()//responde a la pregunta de: hay campos obligatorios vacios?
        {
            return (String.IsNullOrWhiteSpace(txtBoxNombre.Text) || String.IsNullOrWhiteSpace(txtBoxApellido.Text)
                || (String.IsNullOrWhiteSpace(maskedTxtBoxTelefonoPersonal.Text) && String.IsNullOrWhiteSpace(maskedTxtBoxTelefonoResidencial.Text)
                && String.IsNullOrWhiteSpace(maskedTxtBoxTelefonoTrabajo.Text)));
        }
        bool ValidarNombreUnico(string nombre)//responde a la pregunta de: hay otros contactos con el nombre que se intenta registrar
        {
            if (listadoContacto == null) return true;
            var cantidad = listadoContacto.Count(x => ((x.Nombres + " " + x.Apellidos).ToLower().Trim() == nombre.ToLower().Trim()) //si el nombre y el apellido es igual a alguno de los contactos registrados
                && (x.Id != id));//cuentos contactos con ese mismo nombre hay en el json
            return (cantidad < 1);//true si es unico, false si no lo es           
        }
        static bool IsValidEmail(string email) => EmailFormat.IsMatch(email);
        static readonly Regex EmailFormat = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

        void CargarContactos()
        {
            var json = new Json();
            listadoContacto = json.ObtenerContactos();
            if (listadoContacto == null) listadoContacto = new List<Contacto>();
        }
        private void bttnCrear_Click(object sender, EventArgs e)
        {
            var json = new Json();
            if (ValidarCamposObligatorios()) // En caso de campo vacio, mostrara mensaje por pantalla un mensaje de alerta
            {
                MessageBox.Show("Rellene los campos vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarNombreUnico(txtBoxNombre.Text + " " + txtBoxApellido.Text))
            {
                MessageBox.Show("El nombre que introdujo ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(txtBoxCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electronico no es valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            contacto = new Contacto()
            {
                Id = json.ObtenerIdSiguiente(),
                Nombres = txtBoxNombre.Text,
                Apellidos = txtBoxApellido.Text,
                Descripcion = txtBoxDescripcion.Text,
                TelefonoPersonal = maskedTxtBoxTelefonoPersonal.Text,
                TelefonoResidencial = maskedTxtBoxTelefonoResidencial.Text,
                TelefonoTrabajo = maskedTxtBoxTelefonoTrabajo.Text,
                Apodo = txtBoxApodo.Text,
                Categoria =cbCategoria.Text,
                CorreoElectronico = txtBoxCorreoElectronico.Text,
                FechaNacimiento = dtpNacimiento.Value,
                UrlFoto = pbFoto.ImageLocation,

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
        private void bttnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog(); // clase creada para abrir archivos 
            abrirArchivo.Filter = "Image files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; //filtrando el archivo por los tipos 
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = new Bitmap(abrirArchivo.FileName);
            }
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            var json = new Json();
            cbCategoria.DataSource = json.ObtenerCategorias().FindAll(x => x.isVisible == true);
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Nombre";
        }
    }
}
