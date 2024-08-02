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
    public partial class DeletedWindow : Form
    {
        //crear nuevos objetos 
        List<StoredProcedure2> borrarprio = new();
        List<StoredProcedure3> borraremp = new();
        public DeletedWindow()
        {
            //el comando hace que se cargen los datos de los catalogos
            Load += DataLoaded;
            InitializeComponent();
            DelIDArt.Maximum = decimal.MaxValue;
            DelIDStock.Maximum = decimal.MaxValue;
            DelIDPrio.Maximum = decimal.MaxValue;
            DelCantidadActual.Maximum = decimal.MaxValue;
        }

        private async void DataLoaded(object sender, EventArgs e)
        {
            borrarprio = await Querys.obtenerCatalogoPrio();
            listBoxDelPrio.DataSource = borrarprio;
            borraremp = await Querys.obtenerCatalogoStock();
            listBoxDelStock.DataSource = borraremp;

        }

        private void DeletedWinCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //se crea la función de busqueda por Id para eliminar elementos
        private async void DelSearchArt_Click(object sender, EventArgs e)
        {
            //VALIDAR QUE EL ID INGRESADO SEA MAYOR A 0
            if (DelIDArt.Value > 0)
            {
                //Convertir a int
                var itemId = Convert.ToInt32(DelIDArt.Value);
                //LLAMAR LA FUNCION
                var _delitembuscado = await Querys.obtenerItemByIdAsync(itemId);
                //VALIDAR QUE EXISTE
                if (_delitembuscado != null)
                {
                    //LLENAR INFORMACION SOLICITADA.
                    DelArtElegido.Text = _delitembuscado.ItemName;
                    DelCantidadActual.Value = _delitembuscado.Stock;
                    listBoxDelPrio.SelectedItem = borrarprio.FirstOrDefault(p => p.IdTypePrioritary == _delitembuscado.IdTypePrioritary);
                    //listBoxDelPrio.Enabled = false;
                    listBoxDelStock.SelectedItem = borraremp.FirstOrDefault(e => e.IdTypeStock == _delitembuscado.IdTypeStock);
                    //listBoxDelStock.Enabled = false;
                    DelCompAct.Value = _delitembuscado.PurchesDate;
                    DelExpAct.Value = _delitembuscado.ExpirationDate;
                    //DelIDArt.Enabled = false;
                }
                else
                {
                    //ALERTA DE QUE NO EXISTE
                    MessageBox.Show("El artículo que busca no existe");
                }
            }
            else
            {
                //Alerta de que el id es incorrecto
                MessageBox.Show("El ID es incorrecto");
            }
        }

        private async void DelSearchStock_Click(object sender, EventArgs e)
        {
            if (DelIDStock.Value > 0)
            {
                var stockId = Convert.ToInt32(DelIDStock.Value);
                var _delstockbus = await Querys.obtenerStockByIdAsync(stockId);
                if (_delstockbus != null)
                {
                    DelEmpaque.Text = _delstockbus.TypeStockName;
                }
                else
                {
                    MessageBox.Show("El tipo empaque que busca no existe");
                }
            }
            else
            {
                MessageBox.Show("El ID es incorrecto");
            }
        }

        private async void DelSearchPrio_Click(object sender, EventArgs e)
        {
            if (DelIDPrio.Value > 0)
            {
                var prioId = Convert.ToInt32(DelIDPrio.Value);
                var _delpriobus = await Querys.obtenerPrioByIdAsync(prioId);
                if (_delpriobus != null)
                {
                    DelRule.Text = _delpriobus.TypePrioritaryName;
                    DelDesc.Text = _delpriobus.Description;
                }
                else
                {
                    MessageBox.Show("La regla de prioridad que busca no existe");
                }

            }
            else
            {
                ////ALERTA.
                MessageBox.Show("El ID es incorrecto");
            }
        }

        //activar el botonque implementara los cambios
        private async void DeletedWinFinalizar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            //validar que todos los campos esten completos para Del
            if (tabControlDel.SelectedIndex == 0)
            {
                var itemId = DelIDArt.Value.ToString();

                if (valido)
                {
                    await Querys.ElimArtAsync(itemId);
                    MessageBox.Show("Se elimino correctamente");
                    this.Close();
                }
            }

            if (tabControlDel.SelectedIndex == 1)
            {
                var stockId = DelIDStock.Value.ToString();

                if (valido)
                {
                    await Querys.ElimStockAsync(stockId);
                    MessageBox.Show("Se elimino correctamente");
                    this.Close();
                }
            }

            if (tabControlDel.SelectedIndex == 2)
            {
                var prioId = DelIDPrio.Value.ToString();

                if (valido)
                {
                    await Querys.ElimPrioridadAsync(prioId);
                    MessageBox.Show("Se elimino correctamente");
                    this.Close();
                }
            }
        }
    }
}
