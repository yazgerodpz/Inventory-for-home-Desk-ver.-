namespace Inventary_for_home_Desk_ver.C
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            ///INICIALIZAN INSTANCIAS DE OBJETO
            InitializeComponent();

        }

        private void art�culoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREAR INSTANCIA DE NUEVA VENTANA
            AddItemWindow addItemWindow = new AddItemWindow();
            //MOSTRAR LA NUEVA INSTANCIA
            addItemWindow.ShowDialog();
        }

        private void valorDeImportanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddImportanceRuleWindow reglaImportanciaWindow = new AddImportanceRuleWindow();
            reglaImportanciaWindow.ShowDialog();

        }

        private void art�culoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow();
            updateWindow.ShowDialog();
        }
    }
}
