using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventary_for_home_Desk_ver.C
{
    public partial class UpdateWindow : Form
    {

        public UpdateWindow()
        {
            InitializeComponent();
        }

        private void UpdateWinCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtengo el idSeleccionado
            var opcion_Seleccionada = listBox1.SelectedIndex;
            //EVALUO EL ID
            switch (opcion_Seleccionada)
            {
                //SI es caso 0
                case 0:
                    labelOPC1.Visible = true;
                    labelOPC2.Visible = false;
                    break;

                //SI es caso 1
                case 1:

                    labelOPC1.Visible = false;
                    labelOPC2.Visible = true;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
