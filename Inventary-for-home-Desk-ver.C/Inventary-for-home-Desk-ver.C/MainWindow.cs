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

        private async void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemWindow addItemWindow = new AddItemWindow();
            addItemWindow.ShowDialog();
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

        private async void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow();
            updateWindow.ShowDialog();
            ////TABLA ITEMS
            dataGridViewItem.DataSource = items;
            ////TABLA EMPAQUES
            stocks = await Querys.ObtenerTablaStockAsync();
            dataGridViewStock.DataSource = stocks;
            ////TABLA REGLAS DE PRIORIDAD
            prioritys = await Querys.ObtenerTablaPrioridadAsync();
            dataGridViewPrio.DataSource = prioritys;

        }

        private async void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletedWindow deletedWindow = new DeletedWindow();
            deletedWindow.ShowDialog();
            ////TABLA ITEMS
            dataGridViewItem.DataSource = items;
            ////TABLA EMPAQUES
            stocks = await Querys.ObtenerTablaStockAsync();
            dataGridViewStock.DataSource = stocks;
            ////TABLA REGLAS DE PRIORIDAD
            prioritys = await Querys.ObtenerTablaPrioridadAsync();
            dataGridViewPrio.DataSource = prioritys;

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.ShowDialog();
        }

    }
}
