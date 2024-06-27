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
            SuspendLayout();
            // 
            // CancelarBusqueda
            // 
            CancelarBusqueda.Location = new Point(469, 52);
            CancelarBusqueda.Name = "CancelarBusqueda";
            CancelarBusqueda.Size = new Size(75, 23);
            CancelarBusqueda.TabIndex = 0;
            CancelarBusqueda.Text = "Cancelar";
            CancelarBusqueda.UseVisualStyleBackColor = true;
            CancelarBusqueda.Click += CancelarBusqueda_Click;
            // 
            // SearchWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBusqueda);
            Name = "SearchWindow";
            Text = "SearchWindow";
            ResumeLayout(false);
        }

        #endregion

        private Button CancelarBusqueda;
    }
}