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
        List<StoredProcedure2> prioridades = new();
        List<StoredProcedure3> empaques = new();

        public UpdateWindow()
        {
            Load += DataLoaded;
            InitializeComponent();
            ///SE DETERMINA EL MAXIMO DEL NUMERICUPDOWN
            IdArtiFind.Maximum = decimal.MaxValue;
            IdTStock.Maximum = decimal.MaxValue;
            IdPrio.Maximum = decimal.MaxValue;
            //Se establece la cantidad minima
            CantidadActual.Maximum = decimal.MaxValue;
            CantidadActual.Minimum = 1;
        }


        private async void DataLoaded(object sender, EventArgs e)
        {
            //Traer Catalogos
            prioridades = await Querys.obtenerCatalogoPrio();
            listBoxupdatePrio.DataSource = prioridades;
            empaques = await Querys.obtenerCatalogoStock();
            listBoxUpdateStock.DataSource = empaques;
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
            
            if (IdTStock.Value > 0)
            {
                var stockId = Convert.ToInt32(IdTStock.Value);
                ///LLAMAR LA FUNCION
                var _stockBuscado = await Querys.obtenerStockByIdAsync(stockId);
                if (_stockBuscado != null)
                {
                    ActualizarEmp.Text = _stockBuscado.TypeStockName;
                    //comando para desabilitar la interacción con el usuario
                    IdTStock.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El tipo empaque que busca no existe");
                }
            }
            else
            {
                ////ALERTA.
                MessageBox.Show("El ID es incorrecto");
            }
        }

        private async void UDSearch_Click(object sender, EventArgs e)
        {
            //VALIDAR QUE EL ID INGRESADO SEA MAYOR A 0
            if (IdArtiFind.Value > 0)
            {
                ///Convertir a int
                var itemId = Convert.ToInt32(IdArtiFind.Value);
                ///LLAMAR LA FUNCION
                var _itemBuscado = await Querys.obtenerItemByIdAsync(itemId);
                //VALIDAR QUE EXISTE
                if (_itemBuscado != null) 
                {
                    //LLENAR INFORMACION SOLICITADA.
                    ArtElegido.Text = _itemBuscado.ItemName;
                    CantidadActual.Value = _itemBuscado.Stock;
                    listBoxupdatePrio.SelectedItem = prioridades.FirstOrDefault(p=>p.IdTypePrioritary== _itemBuscado.IdTypePrioritary);
                    listBoxUpdateStock.SelectedItem = empaques.FirstOrDefault(s=>s.IdTypeStock== _itemBuscado.IdTypeStock);
                    CompraActual.Value = _itemBuscado.PurchesDate;
                    ExpiracionActual.Value = _itemBuscado.ExpirationDate;
                    IdArtiFind.Enabled = false;
                }
                else
                {
                    ///ALERTA DE QUE NO EXISTE
                    MessageBox.Show("El artículo que busca no existe");
                }
            }
            else
            {
                ////ALERTA
                MessageBox.Show("El ID es incorrecto");
            }
        }

        private async void PrioFind_Click(object sender, EventArgs e)
        {
            if (IdPrio.Value > 0)
            {
                var prioId = Convert.ToInt32(IdPrio.Value);
                ///LLAMAR LA FUNCION
                var _prioBuscado = await Querys.obtenerPrioByIdAsync(prioId);
                if (_prioBuscado != null)
                {
                    RulePrioAct.Text = _prioBuscado.TypePrioritaryName;
                    DescPrioAct.Text = _prioBuscado.Description;
                    IdPrio.Enabled = false;
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

        private async void UpdateWinFinalizar_Click(object sender, EventArgs e)
        {
            bool validar = true;

            //validar que todos los campos esten completos para act artículos
            if (tabUpDate.SelectedIndex == 0)
            {
                var itemId = IdArtiFind.Value.ToString();

                if (string.IsNullOrEmpty(ArtElegido.Text))
                {
                    MessageBox.Show("Falta Nombre de articulo");
                    validar = false;
                }

                var cantAct = CantidadActual.Value.ToString();
                if (string.IsNullOrEmpty(cantAct))
                {
                    MessageBox.Show("Falta agregar una cantidad");
                    validar = false;
                }


                //prioridad por listbox
                StoredProcedure2 priodadesOBJ = (StoredProcedure2)listBoxupdatePrio.SelectedItem;
                if (priodadesOBJ == null)
                {
                    MessageBox.Show("Falta elegir la regla de importancia");
                    validar = false;
                }

                StoredProcedure3 empaquesOBJ = (StoredProcedure3)listBoxUpdateStock.SelectedItem;
                if (empaquesOBJ == null)
                {
                    MessageBox.Show("Falta elegir empaque");
                    validar = false;
                }

                var comAct = CompraActual.Value.ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(comAct))
                {
                    MessageBox.Show("Falta especificar el fecha de compra del artículo");
                    validar = false;
                }

                var exAct = ExpiracionActual.Value.ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(exAct))
                {
                    MessageBox.Show("Falta especificar el fecha de expiracion del artículo");
                    validar = false;
                }

                if (validar)
                {
                    await Querys.ActArtAsync(ArtElegido.Text,
                        cantAct,
                        priodadesOBJ.IdTypePrioritary.ToString(),
                        empaquesOBJ.IdTypeStock.ToString(),
                        CompraActual.Value,
                        ExpiracionActual.Value,
                        itemId);
                    MessageBox.Show("Se actualizo correctamente");
                    this.Close();
                }
                
            }
                
            
            ///pregunatar como bloquear el panel de id una vez seleccionado en
            ///todas las opciones
            
            //validar que todos los campos esten completos para act stock
            if (tabUpDate.SelectedIndex == 1)
            {
                var stockId = IdTStock.Value.ToString();
                if (string.IsNullOrEmpty(stockId))
                {
                    MessageBox.Show("Falta especificar el fecha de expiracion del artículo");
                    validar = false;
                }

                if (string.IsNullOrEmpty(ActualizarEmp.Text))
                {
                    MessageBox.Show("Falta colocar el nombre y cantidad a actualizar");
                    validar = false;
                }

                if (validar)
                {
                    await Querys.ActStockAsync(stockId, ActualizarEmp.Text);
                    MessageBox.Show("Se actualizo correctamente");
                    this.Close();
                }
            }

                //validar que todos los campos esten completos para act la regla de prio
            if (tabUpDate.SelectedIndex == 2)
            {
                var prioId = IdPrio.Value.ToString();

                if (string.IsNullOrEmpty(RulePrioAct.Text))
                {
                    MessageBox.Show("Falta la nombre de la nueva regla de prioridad");
                    validar = false;
                }
                
                if (string.IsNullOrEmpty(DescPrioAct.Text))
                {
                    MessageBox.Show("Falta escribir una descripción para le regla de prioridad");
                    validar = false;
                }

                if (validar)
                {
                    await Querys.ActPrioridadAsync(prioId, RulePrioAct.Text,DescPrioAct.Text);
                    MessageBox.Show("Se actualizo correctamente");
                    this.Close();
                }
            }
            
        }
    }
}
