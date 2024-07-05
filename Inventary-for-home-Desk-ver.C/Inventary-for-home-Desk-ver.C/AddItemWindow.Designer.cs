namespace Inventary_for_home_Desk_ver.C
{
    partial class AddItemWindow
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
            PreguntaART = new Label();
            NameArt = new Label();
            PreguntaCantidad = new Label();
            pregunataPrioridad = new Label();
            PreguntaFechaCom = new Label();
            PreguntaFechaExp = new Label();
            nombreArticulo = new TextBox();
            TipoPioridad = new TextBox();
            FinalizarAdd = new Button();
            CancelarAdd = new Button();
            FechaCompra = new DateTimePicker();
            FechaExpiración = new DateTimePicker();
            CantidadArt = new TextBox();
            TabAdd = new TabControl();
            tabArt = new TabPage();
            TipoEmpaque = new TextBox();
            PreguntaEmpaque = new Label();
            tabPrio = new TabPage();
            DescPrio = new TextBox();
            ResPrio = new TextBox();
            NewDesc = new Label();
            NewPrio = new Label();
            PregPrio = new Label();
            SelectArtPri = new Label();
            tabStock = new TabPage();
            PreguntaStock = new Label();
            RespuestaStock = new TextBox();
            TabAdd.SuspendLayout();
            tabArt.SuspendLayout();
            tabPrio.SuspendLayout();
            tabStock.SuspendLayout();
            SuspendLayout();
            // 
            // PreguntaART
            // 
            PreguntaART.AutoSize = true;
            PreguntaART.Location = new Point(6, 3);
            PreguntaART.Name = "PreguntaART";
            PreguntaART.Size = new Size(292, 15);
            PreguntaART.TabIndex = 0;
            PreguntaART.Text = "Introduzca los datos requeridos para el nuevo artículo:";
            // 
            // NameArt
            // 
            NameArt.AutoSize = true;
            NameArt.Location = new Point(14, 29);
            NameArt.Name = "NameArt";
            NameArt.Size = new Size(113, 15);
            NameArt.TabIndex = 1;
            NameArt.Text = "Nombre del artículo";
            // 
            // PreguntaCantidad
            // 
            PreguntaCantidad.AutoSize = true;
            PreguntaCantidad.Location = new Point(15, 73);
            PreguntaCantidad.Name = "PreguntaCantidad";
            PreguntaCantidad.Size = new Size(119, 15);
            PreguntaCantidad.TabIndex = 2;
            PreguntaCantidad.Text = "Cantidad de artículos";
            // 
            // pregunataPrioridad
            // 
            pregunataPrioridad.AutoSize = true;
            pregunataPrioridad.Location = new Point(15, 117);
            pregunataPrioridad.Name = "pregunataPrioridad";
            pregunataPrioridad.Size = new Size(116, 15);
            pregunataPrioridad.TabIndex = 3;
            pregunataPrioridad.Text = "Valor de importancia";
            // 
            // PreguntaFechaCom
            // 
            PreguntaFechaCom.AutoSize = true;
            PreguntaFechaCom.Location = new Point(14, 205);
            PreguntaFechaCom.Name = "PreguntaFechaCom";
            PreguntaFechaCom.Size = new Size(98, 15);
            PreguntaFechaCom.TabIndex = 4;
            PreguntaFechaCom.Text = "Fecha de compra";
            // 
            // PreguntaFechaExp
            // 
            PreguntaFechaExp.AutoSize = true;
            PreguntaFechaExp.Location = new Point(14, 249);
            PreguntaFechaExp.Name = "PreguntaFechaExp";
            PreguntaFechaExp.Size = new Size(112, 15);
            PreguntaFechaExp.TabIndex = 5;
            PreguntaFechaExp.Text = "Fecha de expiración";
            // 
            // nombreArticulo
            // 
            nombreArticulo.Location = new Point(15, 47);
            nombreArticulo.Name = "nombreArticulo";
            nombreArticulo.Size = new Size(235, 23);
            nombreArticulo.TabIndex = 8;
            // 
            // TipoPioridad
            // 
            TipoPioridad.Location = new Point(15, 135);
            TipoPioridad.Name = "TipoPioridad";
            TipoPioridad.Size = new Size(235, 23);
            TipoPioridad.TabIndex = 10;
            // 
            // FinalizarAdd
            // 
            FinalizarAdd.Location = new Point(254, 385);
            FinalizarAdd.Name = "FinalizarAdd";
            FinalizarAdd.Size = new Size(75, 23);
            FinalizarAdd.TabIndex = 13;
            FinalizarAdd.Text = "Finalizar";
            FinalizarAdd.UseVisualStyleBackColor = true;
            FinalizarAdd.Click += FinalizarAddItem_Click;
            // 
            // CancelarAdd
            // 
            CancelarAdd.Location = new Point(335, 385);
            CancelarAdd.Name = "CancelarAdd";
            CancelarAdd.Size = new Size(75, 23);
            CancelarAdd.TabIndex = 14;
            CancelarAdd.Text = "Cancelar";
            CancelarAdd.UseVisualStyleBackColor = true;
            CancelarAdd.Click += button2_Click;
            // 
            // FechaCompra
            // 
            FechaCompra.Location = new Point(14, 223);
            FechaCompra.Name = "FechaCompra";
            FechaCompra.Size = new Size(235, 23);
            FechaCompra.TabIndex = 15;
            // 
            // FechaExpiración
            // 
            FechaExpiración.Location = new Point(14, 267);
            FechaExpiración.Name = "FechaExpiración";
            FechaExpiración.Size = new Size(235, 23);
            FechaExpiración.TabIndex = 16;
            // 
            // CantidadArt
            // 
            CantidadArt.Location = new Point(15, 91);
            CantidadArt.Name = "CantidadArt";
            CantidadArt.Size = new Size(235, 23);
            CantidadArt.TabIndex = 17;
            // 
            // TabAdd
            // 
            TabAdd.Controls.Add(tabArt);
            TabAdd.Controls.Add(tabStock);
            TabAdd.Controls.Add(tabPrio);
            TabAdd.Location = new Point(27, 37);
            TabAdd.Name = "TabAdd";
            TabAdd.SelectedIndex = 0;
            TabAdd.Size = new Size(379, 331);
            TabAdd.TabIndex = 18;
            // 
            // tabArt
            // 
            tabArt.Controls.Add(TipoEmpaque);
            tabArt.Controls.Add(PreguntaEmpaque);
            tabArt.Controls.Add(FechaExpiración);
            tabArt.Controls.Add(FechaCompra);
            tabArt.Controls.Add(CantidadArt);
            tabArt.Controls.Add(PreguntaFechaExp);
            tabArt.Controls.Add(NameArt);
            tabArt.Controls.Add(PreguntaFechaCom);
            tabArt.Controls.Add(TipoPioridad);
            tabArt.Controls.Add(PreguntaART);
            tabArt.Controls.Add(nombreArticulo);
            tabArt.Controls.Add(pregunataPrioridad);
            tabArt.Controls.Add(PreguntaCantidad);
            tabArt.Location = new Point(4, 24);
            tabArt.Name = "tabArt";
            tabArt.Padding = new Padding(3);
            tabArt.Size = new Size(371, 303);
            tabArt.TabIndex = 0;
            tabArt.Text = "Artículo";
            tabArt.UseVisualStyleBackColor = true;
            // 
            // TipoEmpaque
            // 
            TipoEmpaque.Location = new Point(12, 179);
            TipoEmpaque.Name = "TipoEmpaque";
            TipoEmpaque.Size = new Size(238, 23);
            TipoEmpaque.TabIndex = 19;
            // 
            // PreguntaEmpaque
            // 
            PreguntaEmpaque.AutoSize = true;
            PreguntaEmpaque.Location = new Point(15, 161);
            PreguntaEmpaque.Name = "PreguntaEmpaque";
            PreguntaEmpaque.Size = new Size(99, 15);
            PreguntaEmpaque.TabIndex = 18;
            PreguntaEmpaque.Text = "Tipo de empaque";
            // 
            // tabPrio
            // 
            tabPrio.Controls.Add(DescPrio);
            tabPrio.Controls.Add(ResPrio);
            tabPrio.Controls.Add(NewDesc);
            tabPrio.Controls.Add(NewPrio);
            tabPrio.Controls.Add(PregPrio);
            tabPrio.Location = new Point(4, 24);
            tabPrio.Name = "tabPrio";
            tabPrio.Padding = new Padding(3);
            tabPrio.Size = new Size(371, 303);
            tabPrio.TabIndex = 1;
            tabPrio.Text = "Regla de importancia";
            tabPrio.UseVisualStyleBackColor = true;
            // 
            // DescPrio
            // 
            DescPrio.Location = new Point(15, 101);
            DescPrio.Name = "DescPrio";
            DescPrio.Size = new Size(154, 23);
            DescPrio.TabIndex = 4;
            // 
            // ResPrio
            // 
            ResPrio.Location = new Point(15, 57);
            ResPrio.Name = "ResPrio";
            ResPrio.Size = new Size(154, 23);
            ResPrio.TabIndex = 3;
            // 
            // NewDesc
            // 
            NewDesc.AutoSize = true;
            NewDesc.Location = new Point(15, 83);
            NewDesc.Name = "NewDesc";
            NewDesc.Size = new Size(139, 15);
            NewDesc.TabIndex = 2;
            NewDesc.Text = "Introdusca la descripción";
            // 
            // NewPrio
            // 
            NewPrio.AutoSize = true;
            NewPrio.Location = new Point(15, 39);
            NewPrio.Name = "NewPrio";
            NewPrio.Size = new Size(154, 15);
            NewPrio.TabIndex = 1;
            NewPrio.Text = "Nuevo valor de importancia";
            // 
            // PregPrio
            // 
            PregPrio.AutoSize = true;
            PregPrio.Location = new Point(6, 3);
            PregPrio.Name = "PregPrio";
            PregPrio.Size = new Size(361, 15);
            PregPrio.TabIndex = 0;
            PregPrio.Text = "Introduzca los datos requeridos para el nuevo valor de importancia:";
            // 
            // SelectArtPri
            // 
            SelectArtPri.AutoSize = true;
            SelectArtPri.Location = new Point(12, 9);
            SelectArtPri.Name = "SelectArtPri";
            SelectArtPri.Size = new Size(223, 15);
            SelectArtPri.TabIndex = 19;
            SelectArtPri.Text = "Seleccione el elemento que desea añadir:";
            // 
            // tabStock
            // 
            tabStock.Controls.Add(RespuestaStock);
            tabStock.Controls.Add(PreguntaStock);
            tabStock.Location = new Point(4, 24);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(371, 303);
            tabStock.TabIndex = 2;
            tabStock.Text = "Tipo de empaque";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // PreguntaStock
            // 
            PreguntaStock.AutoSize = true;
            PreguntaStock.Location = new Point(3, 14);
            PreguntaStock.Name = "PreguntaStock";
            PreguntaStock.Size = new Size(277, 15);
            PreguntaStock.TabIndex = 0;
            PreguntaStock.Text = "Introdusca que tipo de empaque es y su capacidad:";
            // 
            // RespuestaStock
            // 
            RespuestaStock.Location = new Point(6, 32);
            RespuestaStock.Name = "RespuestaStock";
            RespuestaStock.Size = new Size(100, 23);
            RespuestaStock.TabIndex = 2;
            // 
            // AddItemWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 414);
            Controls.Add(SelectArtPri);
            Controls.Add(TabAdd);
            Controls.Add(CancelarAdd);
            Controls.Add(FinalizarAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItemWindow";
            Text = "Form2";
            TabAdd.ResumeLayout(false);
            tabArt.ResumeLayout(false);
            tabArt.PerformLayout();
            tabPrio.ResumeLayout(false);
            tabPrio.PerformLayout();
            tabStock.ResumeLayout(false);
            tabStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PreguntaART;
        private Label NameArt;
        private Label PreguntaCantidad;
        private Label pregunataPrioridad;
        private Label PreguntaFechaCom;
        private Label PreguntaFechaExp;
        private TextBox nombreArticulo;
        private TextBox TipoPioridad;
        private Button FinalizarAdd;
        private Button CancelarAdd;
        private DateTimePicker FechaCompra;
        private DateTimePicker FechaExpiración;
        private TextBox CantidadArt;
        private TabControl TabAdd;
        private TabPage tabArt;
        private TabPage tabPrio;
        private TextBox DescPrio;
        private TextBox ResPrio;
        private Label NewDesc;
        private Label NewPrio;
        private Label PregPrio;
        private Label SelectArtPri;
        private Label PreguntaEmpaque;
        private TextBox TipoEmpaque;
        private TabPage tabStock;
        private TextBox RespuestaStock;
        private Label PreguntaStock;
    }
}