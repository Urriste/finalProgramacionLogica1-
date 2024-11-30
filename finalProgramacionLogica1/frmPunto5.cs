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
    public partial class frmPunto5 : Form
    {
        public frmPunto5()
        {
            InitializeComponent();
        }

        private void frmPunto5_Load(object sender, EventArgs e)
        {
            cargarListado();
        }


        private void cargarListado()
        {
            for (int i = 0; i < 7; i++)
            {
                Int32 ventasTotalesPorPlato = 0;

                for (int j = 0; j < 5; j++)
                {
                    ventasTotalesPorPlato = ventasTotalesPorPlato + DatosRestaurante.ventas[i,j];
                }

                dgvPlatos.Rows.Add(DatosRestaurante.platos[i], "$" + ventasTotalesPorPlato);
            }
        }
    }
}
