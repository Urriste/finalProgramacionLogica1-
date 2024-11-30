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
    public partial class frmPunto2 : Form
    {
        public frmPunto2()
        {
            InitializeComponent();
        }

        private void frmPunto2_Load(object sender, EventArgs e)
        {
            cargarComboBoxVendedores();
            cargarComboBoxPlatos();
        }

        private void cargarComboBoxVendedores()
        {
            for (int i = 0; i < 5; i++)
            {
                cmxVendedor.Items.Add(DatosRestaurante.vendedores[i]);
            }
        }

        private void cargarComboBoxPlatos()
        {
            for (int i = 0; i < 7; i++)
            {
                cmxPlato.Items.Add(DatosRestaurante.platos[i]);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            setearTextBox();
        }
        
        private void setearTextBox()
        {
            Int32 vendedorSeleccionado = cmxVendedor.SelectedIndex;
            Int32 platoSeleccionado = cmxPlato.SelectedIndex;

            if(vendedorSeleccionado != -1 && platoSeleccionado != -1)
            {
                txtTotalVentas.Text = "$" + Convert.ToString(DatosRestaurante.ventas[platoSeleccionado, vendedorSeleccionado]);
            }
            else
            {
                MessageBox.Show("Tenes que completar todos los campos para obtener un resultado");
            }
        }
    }
}
