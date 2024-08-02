using System.Diagnostics.Contracts;
using Inventary_for_home_Desk_ver.C.Models;

namespace Inventary_for_home_Desk_ver.C
{
    public partial class MainWindow : Form
    {
        List<StoredProcedure1> items = new();
        List<StoredProcedure2> prioritys = new();
        List<StoredProcedure3> stocks = new();

        /// <summary>
        /// Carga inicial de ventana principal
        /// </summary>
        public MainWindow()
        {
            ///INICIALIZAN INSTANCIAS DE OBJETO
            ///FUNCION NO ASYNCRONA
            //items = Querys.ObtenerTablaItem();
            Load += MainDataLoaded;
            InitializeComponent();
        }

        //CON FUNCION ASINCRONA
        private async void MainDataLoaded(object sender, EventArgs e)
        {
            //TABLA INVENTARIO
            //TRAER LOS ITEMS POR QUERY
            items = await Querys.ObtenerTablaItemAsync();
            //CONFIGURAR LOS NOMBRES Y DATA PROPERTY NAME DE LA TABLA por modo grafico
            //ASIGNAR AL DATASOURCE LA LISTA
            dataGridViewItem.DataSource = items;

            //TABLA EMPAQUES
            stocks = await Querys.ObtenerTablaStockAsync();
            dataGridViewStock.DataSource = stocks;
            //TABLA REGLAS DE PRIORIDAD
            prioritys = await Querys.ObtenerTablaPrioridadAsync();
            dataGridViewPrio.DataSource = prioritys;

        }

        /// <summary>
        /// MOSTRAR LA VENTANA DE AÑADIR 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aqui se crea la instancia de la ventana añadir
            AddItemWindow addItemWindow = new AddItemWindow();
            //Aqui se muestra la ventana
            addItemWindow.ShowDialog();
            //Actualizar DAtos
            await actualizarDatos();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow();
            updateWindow.ShowDialog();
            //Actualizar DAtos
            await actualizarDatos();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletedWindow deletedWindow = new DeletedWindow();
            deletedWindow.ShowDialog();
            //Actualizar DAtos
            await actualizarDatos();


        }




        /// <summary>
        /// Esta funcion actualiza la datagrid de items y las grids de stock y prioridades
        /// </summary>
        /// <returns></returns>
        private async Task actualizarDatos()
        {
            // Seccion de actualizacion de datos despues de añadir
            items = await Querys.ObtenerTablaItemAsync();
            ////TABLA ITEMS
            dataGridViewItem.DataSource = items;
            ////TABLA EMPAQUES
            stocks = await Querys.ObtenerTablaStockAsync();
            dataGridViewStock.DataSource = stocks;
            ////TABLA REGLAS DE PRIORIDAD
            prioritys = await Querys.ObtenerTablaPrioridadAsync();
            dataGridViewPrio.DataSource = prioritys;
        }
        
    }
}
