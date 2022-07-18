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
    public partial class InformacionContacto : Form
    {
        int id; //Id del contacto cuyos datos se mostraran en este formulario
        public InformacionContacto(int id)
        {
            InitializeComponent();
            this.id = id;
            EstadoInicial();


        }

        void EstadoInicial()
        {
            var json = new Json();
            Contacto contacto = json.ObtenerContactos().FirstOrDefault(x => x.Id == id);
            txtBoxNombre.Text = contacto.Nombres;
            txtBoxApellido.Text = contacto.Apellidos;
            maskedTxtBoxTelefonoPersonal.Text = contacto.TelefonoPersonal;
            maskedTxtBoxTelefonoResidencial.Text = contacto.TelefonoResidencial;
            maskedTxtBoxTelefonoTrabajo.Text = contacto.TelefonoTrabajo;
            cbCategoria.Text = contacto.Categoria;
            dtpNacimiento.Value = contacto.FechaNacimiento;
            txtBoxCorreoElectronico.Text = contacto.CorreoElectronico;
            txtBoxDescripcion.Text = contacto.Descripcion;
            txtBoxApodo.Text = contacto.Apodo;
            //foto

        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            var json = new Json();
            Contacto contacto = json.ObtenerContactos().FirstOrDefault(x => x.Id == id);
            contacto.Apellidos = txtBoxApellido.Text;
            json.GuardarContactos(json.ObtenerContactos());

        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
