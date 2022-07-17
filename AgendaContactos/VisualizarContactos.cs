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
    public partial class VisualizarContactos : Form
    {
        List<Contacto> listadoContacto = null;
        public VisualizarContactos()
        {
            InitializeComponent();
            CargarContactos();
            dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Permite que las columnas se ajuste el ancho de manera automatica
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void CargarContactos()
        {
            var json = new Json();
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = listadoContacto; // mi dgv sera igual a mi listado de conceptos


            listadoContacto = json.ObtenerContactos();
            if (listadoContacto == null) listadoContacto = new List<Contacto>();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = listadoContacto; //el datagridview obtiene la lista de ciudadanos
            var nombre = dgvContactos.CurrentRow.Cells["Nombre"].Value.ToString(); //almacena el nombre de la categoria
            //var contacto = listadoContacto.Filter(x => x.Nombres == nombre); //almacena el objeto categoria
            //dgvContactos.DataSource = contacto; //el datagridview obtiene la lista de ciudadanos

        }
    }
}
