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
            artículoToolStripMenuItem1 = new ToolStripMenuItem();
            valorDeImportanciaToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            artículoToolStripMenuItem2 = new ToolStripMenuItem();
            valorDeImportanciaToolStripMenuItem2 = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            actualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { artículoToolStripMenuItem1, valorDeImportanciaToolStripMenuItem1 });
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(71, 20);
            actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // artículoToolStripMenuItem1
            // 
            artículoToolStripMenuItem1.Name = "artículoToolStripMenuItem1";
            artículoToolStripMenuItem1.Size = new Size(183, 22);
            artículoToolStripMenuItem1.Text = "Artículo";
            artículoToolStripMenuItem1.Click += artículoToolStripMenuItem1_Click;
            // 
            // valorDeImportanciaToolStripMenuItem1
            // 
            valorDeImportanciaToolStripMenuItem1.Name = "valorDeImportanciaToolStripMenuItem1";
            valorDeImportanciaToolStripMenuItem1.Size = new Size(183, 22);
            valorDeImportanciaToolStripMenuItem1.Text = "Valor de importancia";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { artículoToolStripMenuItem2, valorDeImportanciaToolStripMenuItem2 });
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(62, 20);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // artículoToolStripMenuItem2
            // 
            artículoToolStripMenuItem2.Name = "artículoToolStripMenuItem2";
            artículoToolStripMenuItem2.Size = new Size(183, 22);
            artículoToolStripMenuItem2.Text = "Artículo";
            // 
            // valorDeImportanciaToolStripMenuItem2
            // 
            valorDeImportanciaToolStripMenuItem2.Name = "valorDeImportanciaToolStripMenuItem2";
            valorDeImportanciaToolStripMenuItem2.Size = new Size(183, 22);
            valorDeImportanciaToolStripMenuItem2.Text = "Valor de importancia";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(54, 20);
            buscarToolStripMenuItem.Text = "Buscar";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(759, 331);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(751, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(748, 300);
            dataGridView1.TabIndex = 0;
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
            Column5.HeaderText = "Importancia";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(751, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(748, 300);
            dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Importancia";
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
            Controls.Add(tabControl1);
            Controls.Add(hScrollBar1);
            Controls.Add(vScrollBar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem artículoToolStripMenuItem1;
        private ToolStripMenuItem valorDeImportanciaToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem artículoToolStripMenuItem2;
        private ToolStripMenuItem valorDeImportanciaToolStripMenuItem2;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
