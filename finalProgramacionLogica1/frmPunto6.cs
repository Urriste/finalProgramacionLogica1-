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
    public partial class frmPunto6 : Form
    {
        public frmPunto6()
        {
            InitializeComponent();
        }

        private void frmPunto6_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void cargarListado()
        {
            for (int i = 0; i < 5; i++)
            {
                Int32 ventasTotalesPorVendedor = 0;

                for (int j = 0; j < 7; j++)
                {
                    ventasTotalesPorVendedor = ventasTotalesPorVendedor + DatosRestaurante.ventas[j, i];
                }

                dgvPlatos.Rows.Add(DatosRestaurante.vendedores[i], "$" + ventasTotalesPorVendedor);
            }
        }
    }
}
