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
        void CargarContactos(string busqueda = null)
        {
            var json = new Json();
            listadoContacto = json.ObtenerContactos();//Cargamos todos los contactos
            var listadoProyectado = listadoContacto
                .Select(x => new VistaContacto(){
                    Id = x.Id,
                    Nombre = x.Nombres + " " + x.Apellidos,
                    TelefonoPersonal = x.TelefonoPersonal,
                    TelefonoTrabajo = x.TelefonoTrabajo,
                    TelefonoResidencial = x.TelefonoResidencial
                }).ToList();//Elegimos 5 campos a mostrar dentro del datagrid, pero el id no se ve
            if(!string.IsNullOrWhiteSpace(busqueda))
            {
                foreach(var contacto in listadoProyectado) //quita los nulos de los campos de la lista
                {
                    var indice = listadoProyectado.IndexOf(contacto);
                    if (contacto.Nombre == null) listadoProyectado[indice].Nombre = "";
                    if (contacto.TelefonoPersonal == null) listadoProyectado[indice].TelefonoPersonal = "";
                    if (contacto.TelefonoResidencial == null) listadoProyectado[indice].TelefonoResidencial = "";
                    if (contacto.TelefonoTrabajo == null) listadoProyectado[indice].TelefonoTrabajo = "";
                }
                listadoProyectado = listadoProyectado.FindAll(
                    x =>
                        (x.Nombre.ToLower().Trim().Contains(busqueda.ToLower().Trim())) ||
                        (x.TelefonoTrabajo.ToLower().Trim().Contains(busqueda.ToLower().Trim())) ||
                        (x.TelefonoResidencial.ToLower().Trim().Contains(busqueda.ToLower().Trim())) ||
                        (x.TelefonoPersonal.ToLower().Trim().Contains(busqueda.ToLower().Trim()))
                    );
            }
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = listadoProyectado; // mi dgv sera igual a mi listado de conceptos
            dgvContactos.Columns["Id"].Visible = false;//Esconde la columna de Id
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxFiltro.Text))
            {
                CargarContactos(txtBoxFiltro.Text);
            }
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);
                Program.aplicacion.abrirSubFormulario(new InformacionContacto(id));
            }
        }
    }
}
