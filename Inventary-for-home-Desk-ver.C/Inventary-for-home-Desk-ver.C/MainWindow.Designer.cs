namespace Inventary_for_home_Desk_ver.C
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            añadirToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            TabMain = new TabControl();
            tabItem = new TabPage();
            dataGridViewItem = new DataGridView();
            tabReglaPrioridad = new TabPage();
            dataGridViewPrio = new DataGridView();
            tabStock = new TabPage();
            dataGridViewStock = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            TabMain.SuspendLayout();
            tabItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).BeginInit();
            tabReglaPrioridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrio).BeginInit();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { añadirToolStripMenuItem, actualizarToolStripMenuItem, eliminarToolStripMenuItem, buscarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            añadirToolStripMenuItem.Size = new Size(54, 20);
            añadirToolStripMenuItem.Text = "Añadir";
            añadirToolStripMenuItem.Click += añadirToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(71, 20);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(62, 20);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(54, 20);
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(774, 59);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 327);
            vScrollBar1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(12, 393);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(755, 17);
            hScrollBar1.TabIndex = 3;
            // 
            // TabMain
            // 
            TabMain.Controls.Add(tabItem);
            TabMain.Controls.Add(tabStock);
            TabMain.Controls.Add(tabReglaPrioridad);
            TabMain.Location = new Point(12, 59);
            TabMain.Name = "TabMain";
            TabMain.SelectedIndex = 0;
            TabMain.Size = new Size(759, 331);
            TabMain.TabIndex = 4;
            // 
            // tabItem
            // 
            tabItem.Controls.Add(dataGridViewItem);
            tabItem.Location = new Point(4, 24);
            tabItem.Name = "tabItem";
            tabItem.Padding = new Padding(3);
            tabItem.Size = new Size(751, 303);
            tabItem.TabIndex = 0;
            tabItem.Text = "Inventario";
            tabItem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItem
            // 
            dataGridViewItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItem.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewItem.Location = new Point(3, 3);
            dataGridViewItem.Name = "dataGridViewItem";
            dataGridViewItem.RowTemplate.Height = 25;
            dataGridViewItem.Size = new Size(748, 300);
            dataGridViewItem.TabIndex = 0;
            // 
            // tabReglaPrioridad
            // 
            tabReglaPrioridad.Controls.Add(dataGridViewPrio);
            tabReglaPrioridad.Location = new Point(4, 24);
            tabReglaPrioridad.Name = "tabReglaPrioridad";
            tabReglaPrioridad.Padding = new Padding(3);
            tabReglaPrioridad.Size = new Size(751, 303);
            tabReglaPrioridad.TabIndex = 1;
            tabReglaPrioridad.Text = "Reglas de prioridad";
            tabReglaPrioridad.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrio
            // 
            dataGridViewPrio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrio.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewPrio.Location = new Point(3, 3);
            dataGridViewPrio.Name = "dataGridViewPrio";
            dataGridViewPrio.RowTemplate.Height = 25;
            dataGridViewPrio.Size = new Size(748, 300);
            dataGridViewPrio.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(dataGridViewStock);
            tabStock.Location = new Point(4, 24);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(751, 303);
            tabStock.TabIndex = 2;
            tabStock.Text = "Empaques";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Columns.AddRange(new DataGridViewColumn[] { Column9 });
            dataGridViewStock.Location = new Point(3, 6);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.RowTemplate.Height = 25;
            dataGridViewStock.Size = new Size(745, 294);
            dataGridViewStock.TabIndex = 0;
            // 
            // Column9
            // 
            Column9.HeaderText = "Empaques";
            Column9.Name = "Column9";
            // 
            // Column3
            // 
            Column3.HeaderText = "Artículos";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Unidades disponibles";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Regla de prioridad";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Fecha de compra";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Fecha de expiración";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Fecha de salida";
            Column8.Name = "Column8";
            // 
            // Column1
            // 
            Column1.HeaderText = "Regla de prioridad";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripción";
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabMain);
            Controls.Add(hScrollBar1);
            Controls.Add(vScrollBar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            TabMain.ResumeLayout(false);
            tabItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).EndInit();
            tabReglaPrioridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrio).EndInit();
            tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private TabControl TabMain;
        private TabPage tabItem;
        private TabPage tabReglaPrioridad;
        private DataGridView dataGridViewItem;
        private DataGridView dataGridViewPrio;
        private TabPage tabStock;
        private DataGridView dataGridViewStock;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
