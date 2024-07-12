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
            tabControl1 = new TabControl();
            ArtículoAct = new TabPage();
            textBox7 = new TextBox();
            UpdateEmpaque = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            empaquesAct = new TabPage();
            textBox9 = new TextBox();
            PreguntaEmpaqueAct = new Label();
            ElecciónEmpaqueAct = new Label();
            EmpaqueExistenteAct = new TextBox();
            PrioridadAct = new TabPage();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            ArtículoAct.SuspendLayout();
            empaquesAct.SuspendLayout();
            PrioridadAct.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione lo que desea actualizar:";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(ArtículoAct);
            tabControl1.Controls.Add(empaquesAct);
            tabControl1.Controls.Add(PrioridadAct);
            tabControl1.Location = new Point(12, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(393, 331);
            tabControl1.TabIndex = 3;
            // 
            // ArtículoAct
            // 
            ArtículoAct.Controls.Add(textBox7);
            ArtículoAct.Controls.Add(UpdateEmpaque);
            ArtículoAct.Controls.Add(dateTimePicker2);
            ArtículoAct.Controls.Add(dateTimePicker1);
            ArtículoAct.Controls.Add(label6);
            ArtículoAct.Controls.Add(textBox3);
            ArtículoAct.Controls.Add(textBox2);
            ArtículoAct.Controls.Add(label5);
            ArtículoAct.Controls.Add(label2);
            ArtículoAct.Controls.Add(textBox1);
            ArtículoAct.Controls.Add(label3);
            ArtículoAct.Controls.Add(label4);
            ArtículoAct.Location = new Point(4, 24);
            ArtículoAct.Name = "ArtículoAct";
            ArtículoAct.Padding = new Padding(3);
            ArtículoAct.Size = new Size(385, 303);
            ArtículoAct.TabIndex = 0;
            ArtículoAct.Text = "Artículo";
            ArtículoAct.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 176);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(210, 23);
            textBox7.TabIndex = 14;
            // 
            // UpdateEmpaque
            // 
            UpdateEmpaque.AutoSize = true;
            UpdateEmpaque.Location = new Point(6, 158);
            UpdateEmpaque.Name = "UpdateEmpaque";
            UpdateEmpaque.Size = new Size(204, 15);
            UpdateEmpaque.TabIndex = 13;
            UpdateEmpaque.Text = "Introdusca el nuevo tipo de empaque";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(3, 264);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(213, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 246);
            label6.Name = "label6";
            label6.Size = new Size(216, 15);
            label6.TabIndex = 9;
            label6.Text = "Introdusca la nueva fecha de expiración";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 202);
            label5.Name = "label5";
            label5.Size = new Size(158, 15);
            label5.TabIndex = 8;
            label5.Text = "Introdusca fecha de compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(227, 15);
            label2.TabIndex = 4;
            label2.Text = "Seleccione el artículo que desea actualizar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 6;
            label3.Text = "Introdusca la nueva cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(223, 15);
            label4.TabIndex = 7;
            label4.Text = "Introdusca el nuevo valor de importancia";
            // 
            // empaquesAct
            // 
            empaquesAct.Controls.Add(textBox9);
            empaquesAct.Controls.Add(PreguntaEmpaqueAct);
            empaquesAct.Controls.Add(ElecciónEmpaqueAct);
            empaquesAct.Controls.Add(EmpaqueExistenteAct);
            empaquesAct.Location = new Point(4, 24);
            empaquesAct.Name = "empaquesAct";
            empaquesAct.Size = new Size(385, 303);
            empaquesAct.TabIndex = 2;
            empaquesAct.Text = "Empaques";
            empaquesAct.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(3, 90);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 3;
            // 
            // PreguntaEmpaqueAct
            // 
            PreguntaEmpaqueAct.AutoSize = true;
            PreguntaEmpaqueAct.Location = new Point(3, 72);
            PreguntaEmpaqueAct.Name = "PreguntaEmpaqueAct";
            PreguntaEmpaqueAct.Size = new Size(377, 15);
            PreguntaEmpaqueAct.TabIndex = 2;
            PreguntaEmpaqueAct.Text = "Introdusca el nombre y la cantidad del contenido del nuevo empaque:";
            // 
            // ElecciónEmpaqueAct
            // 
            ElecciónEmpaqueAct.AutoSize = true;
            ElecciónEmpaqueAct.Location = new Point(3, 14);
            ElecciónEmpaqueAct.Name = "ElecciónEmpaqueAct";
            ElecciónEmpaqueAct.Size = new Size(239, 15);
            ElecciónEmpaqueAct.TabIndex = 1;
            ElecciónEmpaqueAct.Text = "Seleccione el empaque que desea Actualizar";
            // 
            // EmpaqueExistenteAct
            // 
            EmpaqueExistenteAct.Location = new Point(3, 32);
            EmpaqueExistenteAct.Name = "EmpaqueExistenteAct";
            EmpaqueExistenteAct.Size = new Size(100, 23);
            EmpaqueExistenteAct.TabIndex = 0;
            // 
            // PrioridadAct
            // 
            PrioridadAct.Controls.Add(textBox6);
            PrioridadAct.Controls.Add(textBox5);
            PrioridadAct.Controls.Add(label9);
            PrioridadAct.Controls.Add(textBox4);
            PrioridadAct.Controls.Add(label8);
            PrioridadAct.Controls.Add(label7);
            PrioridadAct.Location = new Point(4, 24);
            PrioridadAct.Name = "PrioridadAct";
            PrioridadAct.Padding = new Padding(3);
            PrioridadAct.Size = new Size(385, 303);
            PrioridadAct.TabIndex = 1;
            PrioridadAct.Text = "Regla de importancia";
            PrioridadAct.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 96);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 122);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 6;
            label9.Text = "Introdusca su descripción:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(225, 15);
            label8.TabIndex = 5;
            label8.Text = "Introdusca la nueva regla de importancia:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 14);
            label7.Name = "label7";
            label7.Size = new Size(187, 15);
            label7.TabIndex = 4;
            label7.Text = "Seleccione la regla de importancia";
            // 
            // UpdateWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(UpdateWinCancelar);
            Controls.Add(UpdateWinFinalizar);
            Controls.Add(label1);
            Name = "UpdateWindow";
            Text = "UpdateWindow";
            tabControl1.ResumeLayout(false);
            ArtículoAct.ResumeLayout(false);
            ArtículoAct.PerformLayout();
            empaquesAct.ResumeLayout(false);
            empaquesAct.PerformLayout();
            PrioridadAct.ResumeLayout(false);
            PrioridadAct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button UpdateWinFinalizar;
        private Button UpdateWinCancelar;
        private TabControl tabControl1;
        private TabPage ArtículoAct;
        private TabPage PrioridadAct;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private Label UpdateEmpaque;
        private TabPage empaquesAct;
        private Label ElecciónEmpaqueAct;
        private TextBox EmpaqueExistenteAct;
        private TextBox textBox9;
        private Label PreguntaEmpaqueAct;
    }
}