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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            abrirSubFormulario(new VisualizarContactos()); // cada vez que la aplicacion este abierta este forms estara abierto por default
            MinimizarMenu(); //el menu comenzara minimizado
        }

        private void MinimizarMenu() //metodo para minimizar la barra de menu
        {
            if (this.panelSideMenu.Width > 200) //si la barra de menu es mayor a 200, se minimizara y como siempre su ancho inicial es 230, siempre se minimiza
            {
                panelSideMenu.Width = 100; // ancho de la barra de menu minimizada
                foreach(Button Menubutton in panelSideMenu.Controls.OfType<Button>()) // para cada objeto del tipo boton dentro de este panel
                {
                    pbLogo.Visible = false;
                    Menubutton.Text = ""; // se borran los textos
                    Menubutton.ImageAlign = ContentAlignment.MiddleCenter; //(AUN NO SE AGREGA EL LOGO DE LA APP) 
                    Menubutton.Padding = new Padding(0); // el espacio en los bordes se elimina
                }
                foreach (Button Menubutton in panePhoto.Controls.OfType<Button>()) // para cada objetoo de tipo boton dentro de este OTRO panel
                {
                    pbLogo.Visible = false;
                    Menubutton.Text = ""; 
                    Menubutton.ImageAlign = ContentAlignment.MiddleCenter;
                    Menubutton.Padding = new Padding(0); // se quita el espacio
                }
            }
            else
            {
                panelSideMenu.Width = 230; //size de la barra de menu cuando este maximizada 
                foreach (Button Menubutton in panelSideMenu.Controls.OfType<Button>())
                {
                    pbLogo.Visible = true;
                    Menubutton.Text = "  " + Menubutton.Tag.ToString(); // cada boton tiene un tag en propidades que es lo que ira escrito cuando el menu re maximize nuevamente
                    Menubutton.ImageAlign = ContentAlignment.MiddleLeft; //aun no hay logo
                    Menubutton.Padding = new Padding(10,0,0,0); // espacio 
                }
                foreach (Button Menubutton in panePhoto.Controls.OfType<Button>())
                {
                    pbLogo.Visible = true;
                    Menubutton.Text = "  " + Menubutton.Tag.ToString();
                    Menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    Menubutton.Padding = new Padding(10, 0, 0, 0); //espacio
                }
            }
        }

        private Form formActivo = null; //variable para activar y desactivar los formularios, se le da un valor inicial nulo
        public void abrirSubFormulario(Form formHijo) // metodo para abrir y cerrar los formularios hijos dentro del principal
        {
            if(formActivo != null) // si hay un formulario abierto, sea cual sea, que se cierre
            formActivo.Close();
            formActivo = formHijo; // el form que este activo sera igual al form hijo
            formHijo.TopLevel = false; // el forms no se abrira encima del tope del principal
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; // el forms rellenara todo el espacio del panel
            panelFormHijo.Controls.Add(formHijo); // el form hijo se abrira especificamente en este panel
            panelFormHijo.Tag = formHijo;
            formHijo.Show(); 
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MinimizarMenu();
        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new VisualizarContactos());
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new AgregarContacto());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new Categorias());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new ImportarExportar());

        }
    }
}
