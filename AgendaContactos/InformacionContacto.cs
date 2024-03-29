﻿using AgendaContactos.Modelos;
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
    public partial class InformacionContacto : Form
    {
        int id; //Id del contacto cuyos datos se mostraran en este formulario
        public InformacionContacto(int id)
        {
            InitializeComponent();
            this.id = id;
            EstadoInicial();
        }

        void EstadoInicial() // Este es el estado en el que se presentara el form
        {
            var json = new Json();
            Contacto contacto = json.ObtenerContactos().FirstOrDefault(x => x.Id == id); // Filtramos el contacto por el Id para tener sus datos y presentarlos por pantalla
            
            txtBoxNombre.Text = contacto.Nombres;
            txtBoxApellido.Text = contacto.Apellidos;
            txtBoxCorreoElectronico.Text = contacto.CorreoElectronico;
            txtBoxDescripcion.Text = contacto.Descripcion;
            txtBoxApodo.Text = contacto.Apodo;
            dtpNacimiento.Value = contacto.FechaNacimiento;
            if (contacto.UrlFoto != null) { pbFoto.ImageLocation = contacto.UrlFoto; }
            checkBoxIsFavorito.Checked = contacto.isFavorito;
            checkBoxIsEmergencia.Checked = contacto.isEmergencia;
            maskedTxtBoxTelefonoPersonal.Text = contacto.TelefonoPersonal;
            maskedTxtBoxTelefonoResidencial.Text = contacto.TelefonoResidencial;
            maskedTxtBoxTelefonoTrabajo.Text = contacto.TelefonoTrabajo;
            
            var listado = json.ObtenerCategorias();
            cbCategoria.DataSource = listado ?? null;
            var categoria = listado.FirstOrDefault(x => x.Nombre == contacto.Categoria);
            cbCategoria.SelectedIndex = listado.IndexOf(categoria); // Cada dato se va a mostrar con el equivalente al dato ya registrado del contacto
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Nombre";
        }
        bool ValidarCamposObligatorios() //confirmara los campos vacios 
        {
            return (String.IsNullOrWhiteSpace(txtBoxNombre.Text) || String.IsNullOrWhiteSpace(txtBoxApellido.Text) || String.IsNullOrWhiteSpace(cbCategoria.Text)
                || (String.IsNullOrWhiteSpace(maskedTxtBoxTelefonoPersonal.Text) && String.IsNullOrWhiteSpace(maskedTxtBoxTelefonoResidencial.Text)
                && String.IsNullOrWhiteSpace(maskedTxtBoxTelefonoTrabajo.Text)));
        }

        bool ValidarNombreUnico(string nombre)  //confirmara que no exista otra persona igual en la lista de contacto
        {
            var json = new Json();
            if (json.ObtenerContactos() == null) return true;
            var cantidad = json.ObtenerContactos()
                .Count(
                x => ((x.Nombres + " " + x.Apellidos).ToLower().Trim() == nombre.ToLower().Trim()) //si el nombre y el apellido es igual a alguno de los contactos registrados
                && (x.Id != id) //si no es el id del contacto que se esta visualizando
                );
            return (cantidad < 1);//si se cumple que la cantidad es menor que 1 es unico, de lo contrario no es unico     
        }
        static bool IsValidEmail(string email) => EmailFormat.IsMatch(email);
        static readonly Regex EmailFormat = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
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
            if (!IsValidEmail(txtBoxCorreoElectronico.Text) && !String.IsNullOrWhiteSpace(txtBoxCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electronico no es valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var json = new Json();
            var listadoContactos = json.ObtenerContactos();
            Contacto contacto = listadoContactos.FirstOrDefault(x => x.Id == id);
            var index = listadoContactos.IndexOf(contacto); // Tomara la lista de contactos junto con el contacto ubicado por el id, y obtendremos el index
            listadoContactos[index].Nombres = txtBoxNombre.Text;
            listadoContactos[index].Apellidos = txtBoxApellido.Text;
            listadoContactos[index].TelefonoPersonal = maskedTxtBoxTelefonoPersonal.Text;
            listadoContactos[index].TelefonoResidencial = maskedTxtBoxTelefonoResidencial.Text; //en cada uno de estos, guardamos lo que sea que se actualice 
            listadoContactos[index].TelefonoTrabajo = maskedTxtBoxTelefonoTrabajo.Text;
            listadoContactos[index].Categoria = cbCategoria.Text;
            listadoContactos[index].FechaNacimiento = dtpNacimiento.Value;
            listadoContactos[index].CorreoElectronico = txtBoxCorreoElectronico.Text;
            listadoContactos[index].Descripcion = txtBoxDescripcion.Text; // En cada uno de estos, guardamos lo que sea que se actualice
            listadoContactos[index].Apodo = txtBoxApodo.Text;
            listadoContactos[index].isFavorito = checkBoxIsFavorito.Checked;
            listadoContactos[index].isEmergencia = checkBoxIsEmergencia.Checked;
            listadoContactos[index].UrlFoto = pbFoto.ImageLocation;

            json.GuardarContactos(listadoContactos); // Se guardaran los cambios al Json
            MessageBox.Show("Cambios guardados con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.aplicacion.abrirSubFormulario(new VisualizarContactos()); // Regresara a la pantalla de inicio
        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var json = new Json();
            var listadoContactos = json.ObtenerContactos();
            Contacto contacto = listadoContactos.FirstOrDefault(x => x.Id == id);
            listadoContactos.Remove(contacto); // Tomara el contacto y lo eliminara de la lista
            json.GuardarContactos(listadoContactos); // Se guardaran los cambios en el Json
            MessageBox.Show("Contacto eliminado con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.aplicacion.abrirSubFormulario(new VisualizarContactos()); // Regresara a la pantalla de inicio
        }

        private void bttnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarFoto = new OpenFileDialog();
            buscarFoto.Filter = "Image files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (buscarFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = buscarFoto.FileName;
            }
        }
    }
}