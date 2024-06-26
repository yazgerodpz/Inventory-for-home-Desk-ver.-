namespace Inventary_for_home_Desk_ver.C
{
    partial class UpdateWindow
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
            label1 = new Label();
            UpdateWinFinalizar = new Button();
            UpdateWinCancelar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el artículo e introduca los nuevos datos:";
            // 
            // UpdateWinFinalizar
            // 
            UpdateWinFinalizar.Location = new Point(632, 410);
            UpdateWinFinalizar.Name = "UpdateWinFinalizar";
            UpdateWinFinalizar.Size = new Size(75, 23);
            UpdateWinFinalizar.TabIndex = 1;
            UpdateWinFinalizar.Text = "Finalizar";
            UpdateWinFinalizar.UseVisualStyleBackColor = true;
            // 
            // UpdateWinCancelar
            // 
            UpdateWinCancelar.Location = new Point(713, 410);
            UpdateWinCancelar.Name = "UpdateWinCancelar";
            UpdateWinCancelar.Size = new Size(75, 23);
            UpdateWinCancelar.TabIndex = 2;
            UpdateWinCancelar.Text = "Cancelar";
            UpdateWinCancelar.UseVisualStyleBackColor = true;
            UpdateWinCancelar.Click += UpdateWinCancelar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Artículos", "Regla de importancia" });
            listBox1.Location = new Point(12, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(134, 34);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // UpdateWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(UpdateWinCancelar);
            Controls.Add(UpdateWinFinalizar);
            Controls.Add(label1);
            Name = "UpdateWindow";
            Text = "UpdateWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button UpdateWinFinalizar;
        private Button UpdateWinCancelar;
        private ListBox listBox1;
    }
}