﻿using AgendaContactos.Modelos;
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


        bool ValidarCamposObligatorios()
        {
            return (String.IsNullOrWhiteSpace(txtBoxNombre.Text));
        }

        bool ValidarNombreUnico(string nombre)
        {
            var json = new Json();
            if (json.ObtenerContactos() == null) return true;
            var cantidad = json.ObtenerContactos().Count(x => x.Nombres == nombre);
            return (cantidad < 1);     
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {


            if (ValidarCamposObligatorios()) 
            {
                MessageBox.Show("Rellene los campos vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarNombreUnico(txtBoxNombre.Text)) 
            {
                MessageBox.Show("El nombre que introdujo ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var json = new Json();
            var listadoContactos = json.ObtenerContactos();
            Contacto contacto = listadoContactos.FirstOrDefault(x => x.Id == id);
            var index = listadoContactos.IndexOf(contacto);
            listadoContactos[index].Nombres = txtBoxNombre.Text;
            listadoContactos[index].Apellidos = txtBoxApellido.Text;
            listadoContactos[index].TelefonoPersonal = maskedTxtBoxTelefonoPersonal.Text;
            listadoContactos[index].TelefonoResidencial = maskedTxtBoxTelefonoResidencial.Text;
            listadoContactos[index].TelefonoTrabajo = maskedTxtBoxTelefonoTrabajo.Text;
            listadoContactos[index].Categoria = cbCategoria.Text;
            listadoContactos[index].FechaNacimiento = dtpNacimiento.Value;
            listadoContactos[index].CorreoElectronico = txtBoxCorreoElectronico.Text;
            listadoContactos[index].Descripcion = txtBoxDescripcion.Text;
            listadoContactos[index].Apodo = txtBoxApodo.Text;
            if (checkBoxIsFavorito.Checked)
            {
                listadoContactos[index].isFavorito = true;
            }
            if (checkBoxIsEmergencia.Checked)
            {
                listadoContactos[index].isEmergencia = true;
            }

            json.GuardarContactos(listadoContactos);
            MessageBox.Show("Cambios guardados con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.aplicacion.abrirSubFormulario(new VisualizarContactos());
        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var json = new Json();
            var listadoContactos = json.ObtenerContactos();
            Contacto contacto = listadoContactos.FirstOrDefault(x => x.Id == id);
            var index = listadoContactos.IndexOf(contacto);
            listadoContactos.Remove(contacto);
            json.GuardarContactos(listadoContactos);
            Program.aplicacion.abrirSubFormulario(new VisualizarContactos());

        }
    }
}
