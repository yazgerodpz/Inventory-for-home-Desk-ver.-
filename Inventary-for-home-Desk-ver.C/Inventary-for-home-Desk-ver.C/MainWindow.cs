namespace Inventary_for_home_Desk_ver.C
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            ///INICIALIZAN INSTANCIAS DE OBJETO
            InitializeComponent();

        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemWindow addItemWindow = new AddItemWindow();
            addItemWindow.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow();
            updateWindow.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletedWindow deletedWindow = new DeletedWindow();
            deletedWindow.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.ShowDialog();
        }
    }
}
