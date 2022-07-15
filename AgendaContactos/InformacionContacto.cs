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
        int id;//Id del contacto cuyos datos se mostraran en este formulario
        public InformacionContacto(int id)
        {
            InitializeComponent();
            this.id = id;
        }
    }
}
