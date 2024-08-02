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
            Load += DataLoaded;
            InitializeComponent();
            CantidadArtAdd.Maximum = decimal.MaxValue;
            CantidadArtAdd.Minimum = 1;
        }

        private async void DataLoaded(object sender, EventArgs e)
        {
            //Traer Catalogos
            var catPrior = await Querys.obtenerCatalogoPrio();
            listBox1.DataSource = catPrior;
            var catStk = await Querys.obtenerCatalogoStock();
            listBox2.DataSource = catStk;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CERRAR ESTA INSTANCIA "THIS"
            this.Close();
        }
        //Añadir
        //Artículo
        private async void FinalizarAddItem_Click(object sender, EventArgs e)
        {
            bool validado = true;
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
                    validado = false;
                }
                //Cantidad
                var CantidAdd = CantidadArtAdd.Value.ToString();
                if (string.IsNullOrEmpty(CantidAdd))
                {
                    MessageBox.Show("Falta agregar una cantidad");
                    validado = false;
                }
                //Prioridad POR EL LISTBOX
        
                StoredProcedure2 PrioridOBJ = (StoredProcedure2)listBox1.SelectedItem;
                if (PrioridOBJ == null) 
                {
                    MessageBox.Show("Falta elegir la regla de importancia");
                    validado = false;
                }

                //Cear la vista de los empaques por listbox
                StoredProcedure3 StockOBJ = (StoredProcedure3)listBox2.SelectedItem;
                if (StockOBJ == null)
                {
                    MessageBox.Show("Falta elegir un empaque");
                    validado = false;
                }
                

                //Fecha compra convertida a cadena con formato
                var fechaCompraSTR = FechaCompra.Value.ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(fechaCompraSTR))
                {
                    
                    MessageBox.Show("Falta especificar el fecha de compra del artículo");
                    validado = false;
                }
                //Fecha expiracion convertida a cadena con formato
                var fechaExpiraSTR = FechaExpiración.Value.ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(fechaExpiraSTR)) 
                {
                    MessageBox.Show("Falta especificar el fecha de expiracion del artículo");
                    validado = false;
                }

                //SI TODO ESTA BIEN Y VALIDADO 
                if (validado)
                {
                    //Enviar a la BD
                    await Querys.CrearNArtAsync(nombreArticulo.Text, 
                        CantidAdd,
                        PrioridOBJ.IdTypePrioritary.ToString(),
                        StockOBJ.IdTypeStock.ToString(),
                        FechaCompra.Value,
                        FechaExpiración.Value);
                    MessageBox.Show("Se guardo correctamente");
                    //SE CIERRA VENTANA
                    this.Close();
                }
            }

            //Empaques
            if (TabAdd.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(RespuestaStock.Text))
                {
                    MessageBox.Show("Falta el tipo de empaque");
                    //Desvalidar

                }


                //SI TODO ESTA BIEN Y VALIDADO 
                if (validado)
                {
                    //Enviar a la BD
                    await Querys.CrearNStockAsync(RespuestaStock.Text);
                    MessageBox.Show("Se guardo correctamente");
                    //SE CIERRA VENTANA
                    this.Close();
                }

            }

            //Regla de Prioridad
            if (TabAdd.SelectedIndex == 2) 
            {
                if (string.IsNullOrEmpty(ResPrio.Text))
                {
                    MessageBox.Show("Falta la nombre de la nueva regla de prioridad");
                }
                if (string.IsNullOrEmpty(DescPrio.Text))
                {
                    MessageBox.Show("Falta la descripción de la regla de prioridad");
                }
                //SI TODO ESTA BIEN Y VALIDADO 
                if (validado)
                {
                    //Enviar a la BD
                    await Querys.CrearNPrioridadAsync(ResPrio.Text, DescPrio.Text);
                    MessageBox.Show("Se guardo correctamente");
                    //SE CIERRA VENTANA
                    this.Close();
                }
            }
        }
    }
}
