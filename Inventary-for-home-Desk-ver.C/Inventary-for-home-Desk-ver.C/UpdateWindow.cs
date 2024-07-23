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

        /// <summary>
        /// PARA BUSCAR STOCK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void IdStockFind_Click(object sender, EventArgs e)
        {
            //CORREGIR
            if (IdTStock.Value > 0)
            {
                var stockId = Convert.ToInt32(IdTStock.Value);
                ///LLAMAR LA FUNCION
                var _stockBuscado = await Querys.obtenerStockByIdAsync(stockId);
                ActualizarEmp.Text = _stockBuscado.TypeStockName;
            }
            else
            {
                ////ALERTA.
            }
        }

        private async void UDSearch_Click(object sender, EventArgs e)
        {
            if (IdArtiFind.Value > 0)
            {
                ///Convertir a int
                var itemId = Convert.ToInt32(IdArtiFind.Value);
                ///LLAMAR LA FUNCION
                var _itemBuscado = await Querys.obtenerItemByIdAsync(itemId);
                //LLENAR INFORMACION SOLICITADA.
                ArtElegido.Text = _itemBuscado.ItemName;
                CantidadActual.Value = _itemBuscado.Stock;
                //ReglaActual.Value = _itemBuscado.TypePrioritaryName;
                //EmpActual.Value = _itemBuscado.TypeStockName;
                CompraActual.Value = _itemBuscado.PurchesDate;
                ExpiracionActual.Value = _itemBuscado.ExpirationDate;
            }
            else
            {
                ////ALERTA.
            }
        }

        private async void PrioFind_Click(object sender, EventArgs e)
        {
            if (IdPrio.Value > 0)
            {
                var prioId = Convert.ToInt32(IdPrio.Value);
                ///LLAMAR LA FUNCION
                var _prioBuscado = await Querys.obtenerPrioByIdAsync(prioId);
                RulePrioAct.Text = _prioBuscado.TypePrioritaryName;
                DescPrioAct.Text = _prioBuscado.Description;
            }
            else
            {
                ////ALERTA.
            }
        }
    }
}
