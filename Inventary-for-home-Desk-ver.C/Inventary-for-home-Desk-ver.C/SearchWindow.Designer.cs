namespace Inventary_for_home_Desk_ver.C
{
    partial class SearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CancelarBusqueda = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CancelarBusqueda
            // 
            CancelarBusqueda.Location = new Point(678, 350);
            CancelarBusqueda.Name = "CancelarBusqueda";
            CancelarBusqueda.Size = new Size(75, 23);
            CancelarBusqueda.TabIndex = 0;
            CancelarBusqueda.Text = "Cancelar";
            CancelarBusqueda.UseVisualStyleBackColor = true;
            CancelarBusqueda.Click += CancelarBusqueda_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(702, 304);
            dataGridView1.TabIndex = 1;
            // 
            // SearchWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 385);
            Controls.Add(dataGridView1);
            Controls.Add(CancelarBusqueda);
            Name = "SearchWindow";
            Text = "SearchWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelarBusqueda;
        private DataGridView dataGridView1;
    }
}