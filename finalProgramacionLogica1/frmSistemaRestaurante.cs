using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProgramacionLogica1
{
    public partial class frmSistemaRestaurante : Form
    {        

        Random random = new Random();
        public frmSistemaRestaurante()
        {
            InitializeComponent();
        }

        private void frmSistemaRestaurante_Load(object sender, EventArgs e)
        {
            cargarMatriz();
            cargarPlatos();
            cargarVendedores();
        }


        private void cargarMatriz()
        {
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    DatosRestaurante.ventas[i, j] = random.Next(1, 101);
                }
            }
        }

        private void cargarPlatos()
        {
            DatosRestaurante.platos[0] = "Arroz con pollo";
            DatosRestaurante.platos[1] = "Masala dosa";
            DatosRestaurante.platos[2] = "Papas fritas";
            DatosRestaurante.platos[3] = "Paella de mariscos";
            DatosRestaurante.platos[4] = "Tacos";
            DatosRestaurante.platos[5] = "Pollo a la parmesana";
            DatosRestaurante.platos[6] = "Lasagna";

        }

        private void cargarVendedores()
        {
            DatosRestaurante.vendedores[0] = "Guido Carrillo";
            DatosRestaurante.vendedores[1] = "Santiago Ascacibar";
            DatosRestaurante.vendedores[2] = "Mariano Andujar";
            DatosRestaurante.vendedores[3] = "Leandro Desabato";
            DatosRestaurante.vendedores[4] = "Juan Sebastián Verón";


        }

        private void punto2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPunto2 ventanaPunto2 = new frmPunto2();
            ventanaPunto2.ShowDialog();
        }

        private void punto3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPunto3 ventanaPunto3 = new frmPunto3();
            ventanaPunto3.ShowDialog();
        }

        private void punto4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPunto4 ventanaPunto4 = new frmPunto4();
            ventanaPunto4.ShowDialog();
        }

        private void punto5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPunto5 ventanaPunto5 = new frmPunto5();
            ventanaPunto5.ShowDialog();
        }

        private void punto6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPunto6 ventanaPunto6 = new frmPunto6(); 
            ventanaPunto6.ShowDialog();
        }
    }
}
