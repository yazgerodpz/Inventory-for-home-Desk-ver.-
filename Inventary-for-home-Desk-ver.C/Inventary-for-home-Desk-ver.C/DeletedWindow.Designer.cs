namespace Inventary_for_home_Desk_ver.C
{
    partial class DeletedWindow
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
            DeletedWinFinalizar = new Button();
            DeletedWinCancelar = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // DeletedWinFinalizar
            // 
            DeletedWinFinalizar.Location = new Point(368, 201);
            DeletedWinFinalizar.Name = "DeletedWinFinalizar";
            DeletedWinFinalizar.Size = new Size(75, 23);
            DeletedWinFinalizar.TabIndex = 0;
            DeletedWinFinalizar.Text = "Finalizar";
            DeletedWinFinalizar.UseVisualStyleBackColor = true;
            // 
            // DeletedWinCancelar
            // 
            DeletedWinCancelar.Location = new Point(449, 201);
            DeletedWinCancelar.Name = "DeletedWinCancelar";
            DeletedWinCancelar.Size = new Size(75, 23);
            DeletedWinCancelar.TabIndex = 1;
            DeletedWinCancelar.Text = "Cancelar";
            DeletedWinCancelar.UseVisualStyleBackColor = true;
            DeletedWinCancelar.Click += DeletedWinCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione entre artículos o regla de importancia para borrar:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(512, 144);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(504, 116);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Artículos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(504, 116);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reglas de importancia";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 4;
            label2.Text = "Seleccione el artículo ha eliminar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(169, 15);
            label3.TabIndex = 4;
            label3.Text = "Seleccione la regla ha eliminar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // DeletedWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 237);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(DeletedWinCancelar);
            Controls.Add(DeletedWinFinalizar);
            Name = "DeletedWindow";
            Text = "DeletedWindow";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeletedWinFinalizar;
        private Button DeletedWinCancelar;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}