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
            var listadoContactos = json.ObtenerContactos();
            Contacto contacto = listadoContactos.FirstOrDefault(x => x.Id == id);
            //busca el indice de contacto en la lista listadoContactos con .IndexOf()
            //ese indice almacenalo en una variable
            //para actualizar la informacion accede a la posicion de ese elemento en el listado de la siguiente manera listadoContactos[indice].nombre
            //eso lo haras con cada uno de los campos
            json.GuardarContactos(listadoContactos);//al final se guarda esa lista que modificaste
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
