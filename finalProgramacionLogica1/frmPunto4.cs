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
    public partial class frmPunto4 : Form
    {
        public frmPunto4()
        {
            InitializeComponent();
        }

        private void frmPunto4_Load(object sender, EventArgs e)
        {
            cargarComboBoxVendedores();
        }
        private void cargarComboBoxVendedores()
        {
            for (int i = 0; i < 5; i++)
            {
                cmxVendedor.Items.Add(DatosRestaurante.vendedores[i]);
            }
        }

        private void btnTotal_Click_1(object sender, EventArgs e)
        {
            Int32 vendedorSeleccionado = cmxVendedor.SelectedIndex;
            Int32 totalVentas = 0;

            if(vendedorSeleccionado != -1)
            {

                for (int i = 0; i < 7; i++)
                {
                    totalVentas = totalVentas + DatosRestaurante.ventas[i, vendedorSeleccionado];
                }

                txtTotalVentas.Text = "$" + totalVentas.ToString();
            }
            else
            {
                MessageBox.Show("Tenes que completar todos los campos para obtener un resultado");
            }
        }
    }
}
