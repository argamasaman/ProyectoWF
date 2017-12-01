using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF
{
    public partial class FormularioProductos : Form
    {
        private int modo;
        private int clave;


        public FormularioProductos()
        {
            InitializeComponent();
        }

        public FormularioProductos(int modo, int clave)
        {
            this.modo = modo;
            this.clave = clave;
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
