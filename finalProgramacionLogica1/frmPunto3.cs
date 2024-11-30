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
    public partial class frmPunto3 : Form
    {
        public frmPunto3()
        {
            InitializeComponent();
        }

        private void frmPunto3_Load(object sender, EventArgs e)
        {
            cargarComboBoxPlatos();
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
            Int32 platoSeleccionado = cmxPlato.SelectedIndex;
            Int32 totalVentas = 0;

            if(platoSeleccionado != -1)
            {
                for (int i = 0; i < 5; i++)
                {
                    totalVentas = totalVentas + DatosRestaurante.ventas[platoSeleccionado, i];
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
