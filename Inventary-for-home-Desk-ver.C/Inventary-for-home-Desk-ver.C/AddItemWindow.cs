using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventary_for_home_Desk_ver.C.Models;

namespace Inventary_for_home_Desk_ver.C
{
    public partial class AddItemWindow : Form
    {
        public AddItemWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CERRAR ESTA INSTANCIA "THIS"
            this.Close();
        }

        private async void FinalizarAddItem_Click(object sender, EventArgs e)
        {
            //Evaluar si estas en Articulo o Regla de importancia
            if (TabAdd.SelectedIndex == 0) 
            {
                //Operacion de añadir Articulo.
                //RECOPILAR LA INFORMACION.
                //REVISAR CADA CAMPO
                //Nombre articulo
                if (string.IsNullOrEmpty(nombreArticulo.Text))
                {
                    MessageBox.Show("Falta Nombre de articulo");
                }
                //Cantidad
                //Prioridad
                //Empaque
                //Fecha compra
                //Fecha expiracion
                //Enviar a la BD
                //await Querys.CrearNArtAsync();
            }
        }
    }
}
