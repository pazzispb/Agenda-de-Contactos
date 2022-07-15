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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            Json json = new Json();
            List<Contacto> nombre = new List<Contacto>
            {
                new Contacto
                {
                    Id = 1,
                    Nombres = "so"
                },
                new Contacto
                {
                    Id = 2
                },
                new Contacto
                {
                    Id = 3
                }
            };
            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria
                {
                    Nombre ="pp"
                },
                new Categoria
                {
                    Nombre ="juan"
                },
                new Categoria
                {
                    Nombre ="pp"
                }
            };

            json.GuardarContactos(nombre);
            nombre = null;
            json.GuardarCategorias(categorias);
            nombre = null;
            dataGridView1.DataSource = json.ObtenerCategorias();
        }
    }
}
