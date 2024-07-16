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
            tabDelItem = new TabPage();
            textBox1 = new TextBox();
            label2 = new Label();
            tabDelReglaPrio = new TabPage();
            textBox2 = new TextBox();
            label3 = new Label();
            tabDelStock = new TabPage();
            DelQStock = new Label();
            DelAnswerStock = new TextBox();
            tabControl1.SuspendLayout();
            tabDelItem.SuspendLayout();
            tabDelReglaPrio.SuspendLayout();
            tabDelStock.SuspendLayout();
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
            tabControl1.Controls.Add(tabDelItem);
            tabControl1.Controls.Add(tabDelStock);
            tabControl1.Controls.Add(tabDelReglaPrio);
            tabControl1.Location = new Point(12, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(512, 122);
            tabControl1.TabIndex = 3;
            // 
            // tabDelItem
            // 
            tabDelItem.Controls.Add(textBox1);
            tabDelItem.Controls.Add(label2);
            tabDelItem.Location = new Point(4, 24);
            tabDelItem.Name = "tabDelItem";
            tabDelItem.Padding = new Padding(3);
            tabDelItem.Size = new Size(504, 94);
            tabDelItem.TabIndex = 0;
            tabDelItem.Text = "Artículos";
            tabDelItem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
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
            // tabDelReglaPrio
            // 
            tabDelReglaPrio.Controls.Add(textBox2);
            tabDelReglaPrio.Controls.Add(label3);
            tabDelReglaPrio.Location = new Point(4, 24);
            tabDelReglaPrio.Name = "tabDelReglaPrio";
            tabDelReglaPrio.Padding = new Padding(3);
            tabDelReglaPrio.Size = new Size(504, 94);
            tabDelReglaPrio.TabIndex = 1;
            tabDelReglaPrio.Text = "Reglas de importancia";
            tabDelReglaPrio.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
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
            // tabDelStock
            // 
            tabDelStock.Controls.Add(DelAnswerStock);
            tabDelStock.Controls.Add(DelQStock);
            tabDelStock.Location = new Point(4, 24);
            tabDelStock.Name = "tabDelStock";
            tabDelStock.Size = new Size(504, 94);
            tabDelStock.TabIndex = 2;
            tabDelStock.Text = "Empaques";
            tabDelStock.UseVisualStyleBackColor = true;
            // 
            // DelQStock
            // 
            DelQStock.AutoSize = true;
            DelQStock.Location = new Point(6, 16);
            DelQStock.Name = "DelQStock";
            DelQStock.Size = new Size(233, 15);
            DelQStock.TabIndex = 0;
            DelQStock.Text = "Seleccione el empaque que desea eliminar:";
            // 
            // DelAnswerStock
            // 
            DelAnswerStock.Location = new Point(3, 34);
            DelAnswerStock.Name = "DelAnswerStock";
            DelAnswerStock.Size = new Size(100, 23);
            DelAnswerStock.TabIndex = 1;
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
            tabDelItem.ResumeLayout(false);
            tabDelItem.PerformLayout();
            tabDelReglaPrio.ResumeLayout(false);
            tabDelReglaPrio.PerformLayout();
            tabDelStock.ResumeLayout(false);
            tabDelStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeletedWinFinalizar;
        private Button DeletedWinCancelar;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabDelItem;
        private TabPage tabDelReglaPrio;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TabPage tabDelStock;
        private TextBox DelAnswerStock;
        private Label DelQStock;
    }
}