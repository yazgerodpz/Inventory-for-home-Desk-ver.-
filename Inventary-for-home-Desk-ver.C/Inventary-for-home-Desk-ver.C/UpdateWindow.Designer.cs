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
            tabUpDate = new TabControl();
            ArticuloAct = new TabPage();
            UDSearch = new Button();
            QIDArtoUD = new Label();
            IdArtiFind = new NumericUpDown();
            EmpActual = new NumericUpDown();
            ReglaActual = new NumericUpDown();
            CantidadActual = new NumericUpDown();
            UDTypeS = new Label();
            ExpiracionActual = new DateTimePicker();
            CompraActual = new DateTimePicker();
            UDExpiration = new Label();
            UDPurchase = new Label();
            UDItemName = new Label();
            ArtElegido = new TextBox();
            UDStock = new Label();
            UDPrio = new Label();
            empaquesAct = new TabPage();
            IdStockFind = new Button();
            IdTStock = new NumericUpDown();
            ActualizarEmp = new TextBox();
            PreguntaEmpaqueAct = new Label();
            UDTypeStock = new Label();
            PrioridadAct = new TabPage();
            PrioFind = new Button();
            IdPrio = new NumericUpDown();
            DescPrioAct = new TextBox();
            RulePrioAct = new TextBox();
            DescripciónActual = new Label();
            PrioActual = new Label();
            UDPrioridad = new Label();
            tabUpDate.SuspendLayout();
            ArticuloAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdArtiFind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmpActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReglaActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantidadActual).BeginInit();
            empaquesAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdTStock).BeginInit();
            PrioridadAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdPrio).BeginInit();
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
            UpdateWinFinalizar.Location = new Point(246, 423);
            UpdateWinFinalizar.Name = "UpdateWinFinalizar";
            UpdateWinFinalizar.Size = new Size(75, 23);
            UpdateWinFinalizar.TabIndex = 1;
            UpdateWinFinalizar.Text = "Finalizar";
            UpdateWinFinalizar.UseVisualStyleBackColor = true;
            // 
            // UpdateWinCancelar
            // 
            UpdateWinCancelar.Location = new Point(327, 423);
            UpdateWinCancelar.Name = "UpdateWinCancelar";
            UpdateWinCancelar.Size = new Size(75, 23);
            UpdateWinCancelar.TabIndex = 2;
            UpdateWinCancelar.Text = "Cancelar";
            UpdateWinCancelar.UseVisualStyleBackColor = true;
            UpdateWinCancelar.Click += UpdateWinCancelar_Click;
            // 
            // tabUpDate
            // 
            tabUpDate.Controls.Add(ArticuloAct);
            tabUpDate.Controls.Add(empaquesAct);
            tabUpDate.Controls.Add(PrioridadAct);
            tabUpDate.Location = new Point(12, 37);
            tabUpDate.Name = "tabUpDate";
            tabUpDate.SelectedIndex = 0;
            tabUpDate.Size = new Size(393, 380);
            tabUpDate.TabIndex = 3;
            // 
            // ArticuloAct
            // 
            ArticuloAct.Controls.Add(UDSearch);
            ArticuloAct.Controls.Add(QIDArtoUD);
            ArticuloAct.Controls.Add(IdArtiFind);
            ArticuloAct.Controls.Add(EmpActual);
            ArticuloAct.Controls.Add(ReglaActual);
            ArticuloAct.Controls.Add(CantidadActual);
            ArticuloAct.Controls.Add(UDTypeS);
            ArticuloAct.Controls.Add(ExpiracionActual);
            ArticuloAct.Controls.Add(CompraActual);
            ArticuloAct.Controls.Add(UDExpiration);
            ArticuloAct.Controls.Add(UDPurchase);
            ArticuloAct.Controls.Add(UDItemName);
            ArticuloAct.Controls.Add(ArtElegido);
            ArticuloAct.Controls.Add(UDStock);
            ArticuloAct.Controls.Add(UDPrio);
            ArticuloAct.Location = new Point(4, 24);
            ArticuloAct.Name = "ArticuloAct";
            ArticuloAct.Padding = new Padding(3);
            ArticuloAct.Size = new Size(385, 352);
            ArticuloAct.TabIndex = 0;
            ArticuloAct.Text = "Artículo";
            ArticuloAct.UseVisualStyleBackColor = true;
            // 
            // UDSearch
            // 
            UDSearch.Location = new Point(155, 37);
            UDSearch.Name = "UDSearch";
            UDSearch.Size = new Size(75, 23);
            UDSearch.TabIndex = 19;
            UDSearch.Text = "Buscar";
            UDSearch.UseVisualStyleBackColor = true;
            UDSearch.Click += UDSearch_Click;
            // 
            // QIDArtoUD
            // 
            QIDArtoUD.AutoSize = true;
            QIDArtoUD.Location = new Point(6, 19);
            QIDArtoUD.Name = "QIDArtoUD";
            QIDArtoUD.Size = new Size(264, 15);
            QIDArtoUD.TabIndex = 18;
            QIDArtoUD.Text = "Seleccione el Id del Artículo que desea actualizar:";
            // 
            // IdArtiFind
            // 
            IdArtiFind.Location = new Point(6, 37);
            IdArtiFind.Name = "IdArtiFind";
            IdArtiFind.Size = new Size(120, 23);
            IdArtiFind.TabIndex = 17;
            // 
            // EmpActual
            // 
            EmpActual.Location = new Point(6, 231);
            EmpActual.Name = "EmpActual";
            EmpActual.Size = new Size(120, 23);
            EmpActual.TabIndex = 16;
            // 
            // ReglaActual
            // 
            ReglaActual.Location = new Point(6, 187);
            ReglaActual.Name = "ReglaActual";
            ReglaActual.Size = new Size(120, 23);
            ReglaActual.TabIndex = 15;
            // 
            // CantidadActual
            // 
            CantidadActual.Location = new Point(6, 143);
            CantidadActual.Name = "CantidadActual";
            CantidadActual.Size = new Size(120, 23);
            CantidadActual.TabIndex = 14;
            // 
            // UDTypeS
            // 
            UDTypeS.AutoSize = true;
            UDTypeS.Location = new Point(3, 213);
            UDTypeS.Name = "UDTypeS";
            UDTypeS.Size = new Size(102, 15);
            UDTypeS.TabIndex = 13;
            UDTypeS.Text = "Tipo de empaque:";
            // 
            // ExpiracionActual
            // 
            ExpiracionActual.Location = new Point(3, 319);
            ExpiracionActual.Name = "ExpiracionActual";
            ExpiracionActual.Size = new Size(213, 23);
            ExpiracionActual.TabIndex = 12;
            // 
            // CompraActual
            // 
            CompraActual.Location = new Point(3, 275);
            CompraActual.Name = "CompraActual";
            CompraActual.Size = new Size(213, 23);
            CompraActual.TabIndex = 11;
            // 
            // UDExpiration
            // 
            UDExpiration.AutoSize = true;
            UDExpiration.Location = new Point(3, 301);
            UDExpiration.Name = "UDExpiration";
            UDExpiration.Size = new Size(115, 15);
            UDExpiration.TabIndex = 9;
            UDExpiration.Text = "Fecha de expiración:";
            // 
            // UDPurchase
            // 
            UDPurchase.AutoSize = true;
            UDPurchase.Location = new Point(0, 257);
            UDPurchase.Name = "UDPurchase";
            UDPurchase.Size = new Size(101, 15);
            UDPurchase.TabIndex = 8;
            UDPurchase.Text = "Fecha de compra:";
            // 
            // UDItemName
            // 
            UDItemName.AutoSize = true;
            UDItemName.Location = new Point(6, 81);
            UDItemName.Name = "UDItemName";
            UDItemName.Size = new Size(52, 15);
            UDItemName.TabIndex = 4;
            UDItemName.Text = "Artículo:";
            // 
            // ArtElegido
            // 
            ArtElegido.Location = new Point(6, 99);
            ArtElegido.Name = "ArtElegido";
            ArtElegido.Size = new Size(210, 23);
            ArtElegido.TabIndex = 5;
            // 
            // UDStock
            // 
            UDStock.AutoSize = true;
            UDStock.Location = new Point(6, 125);
            UDStock.Name = "UDStock";
            UDStock.Size = new Size(58, 15);
            UDStock.TabIndex = 6;
            UDStock.Text = "Cantidad:";
            // 
            // UDPrio
            // 
            UDPrio.AutoSize = true;
            UDPrio.Location = new Point(3, 169);
            UDPrio.Name = "UDPrio";
            UDPrio.Size = new Size(106, 15);
            UDPrio.TabIndex = 7;
            UDPrio.Text = "Regla de Prioridad:";
            // 
            // empaquesAct
            // 
            empaquesAct.Controls.Add(IdStockFind);
            empaquesAct.Controls.Add(IdTStock);
            empaquesAct.Controls.Add(ActualizarEmp);
            empaquesAct.Controls.Add(PreguntaEmpaqueAct);
            empaquesAct.Controls.Add(UDTypeStock);
            empaquesAct.Location = new Point(4, 24);
            empaquesAct.Name = "empaquesAct";
            empaquesAct.Size = new Size(385, 352);
            empaquesAct.TabIndex = 2;
            empaquesAct.Text = "Empaques";
            empaquesAct.UseVisualStyleBackColor = true;
            // 
            // IdStockFind
            // 
            IdStockFind.Location = new Point(167, 34);
            IdStockFind.Name = "IdStockFind";
            IdStockFind.Size = new Size(75, 23);
            IdStockFind.TabIndex = 16;
            IdStockFind.Text = "Buscar";
            IdStockFind.UseVisualStyleBackColor = true;
            IdStockFind.Click += IdStockFind_Click;
            // 
            // IdTStock
            // 
            IdTStock.Location = new Point(3, 34);
            IdTStock.Name = "IdTStock";
            IdTStock.Size = new Size(120, 23);
            IdTStock.TabIndex = 15;
            // 
            // ActualizarEmp
            // 
            ActualizarEmp.Location = new Point(3, 112);
            ActualizarEmp.Name = "ActualizarEmp";
            ActualizarEmp.Size = new Size(302, 23);
            ActualizarEmp.TabIndex = 3;
            // 
            // PreguntaEmpaqueAct
            // 
            PreguntaEmpaqueAct.AutoSize = true;
            PreguntaEmpaqueAct.Location = new Point(3, 79);
            PreguntaEmpaqueAct.Name = "PreguntaEmpaqueAct";
            PreguntaEmpaqueAct.Size = new Size(317, 30);
            PreguntaEmpaqueAct.TabIndex = 2;
            PreguntaEmpaqueAct.Text = "Introdusca el nuevo nombre y/o la cantidad  del contenido\r\ndel empaque:";
            // 
            // UDTypeStock
            // 
            UDTypeStock.AutoSize = true;
            UDTypeStock.Location = new Point(3, 16);
            UDTypeStock.Name = "UDTypeStock";
            UDTypeStock.Size = new Size(273, 15);
            UDTypeStock.TabIndex = 1;
            UDTypeStock.Text = "Seleccione el ID del empaque que desea actualizar:";
            // 
            // PrioridadAct
            // 
            PrioridadAct.Controls.Add(PrioFind);
            PrioridadAct.Controls.Add(IdPrio);
            PrioridadAct.Controls.Add(DescPrioAct);
            PrioridadAct.Controls.Add(RulePrioAct);
            PrioridadAct.Controls.Add(DescripciónActual);
            PrioridadAct.Controls.Add(PrioActual);
            PrioridadAct.Controls.Add(UDPrioridad);
            PrioridadAct.Location = new Point(4, 24);
            PrioridadAct.Name = "PrioridadAct";
            PrioridadAct.Padding = new Padding(3);
            PrioridadAct.Size = new Size(385, 352);
            PrioridadAct.TabIndex = 1;
            PrioridadAct.Text = "Regla de prioridad";
            PrioridadAct.UseVisualStyleBackColor = true;
            // 
            // PrioFind
            // 
            PrioFind.Location = new Point(156, 32);
            PrioFind.Name = "PrioFind";
            PrioFind.Size = new Size(75, 23);
            PrioFind.TabIndex = 16;
            PrioFind.Text = "Buscar";
            PrioFind.UseVisualStyleBackColor = true;
            PrioFind.Click += PrioFind_Click;
            // 
            // IdPrio
            // 
            IdPrio.Location = new Point(6, 32);
            IdPrio.Name = "IdPrio";
            IdPrio.Size = new Size(120, 23);
            IdPrio.TabIndex = 15;
            // 
            // DescPrioAct
            // 
            DescPrioAct.Location = new Point(6, 140);
            DescPrioAct.Name = "DescPrioAct";
            DescPrioAct.Size = new Size(100, 23);
            DescPrioAct.TabIndex = 7;
            // 
            // RulePrioAct
            // 
            RulePrioAct.Location = new Point(6, 96);
            RulePrioAct.Name = "RulePrioAct";
            RulePrioAct.Size = new Size(100, 23);
            RulePrioAct.TabIndex = 7;
            // 
            // DescripciónActual
            // 
            DescripciónActual.AutoSize = true;
            DescripciónActual.Location = new Point(6, 122);
            DescripciónActual.Name = "DescripciónActual";
            DescripciónActual.Size = new Size(72, 15);
            DescripciónActual.TabIndex = 6;
            DescripciónActual.Text = "Descripción:";
            // 
            // PrioActual
            // 
            PrioActual.AutoSize = true;
            PrioActual.Location = new Point(6, 78);
            PrioActual.Name = "PrioActual";
            PrioActual.Size = new Size(106, 15);
            PrioActual.TabIndex = 5;
            PrioActual.Text = "Regla de prioridad:";
            // 
            // UDPrioridad
            // 
            UDPrioridad.AutoSize = true;
            UDPrioridad.Location = new Point(6, 14);
            UDPrioridad.Name = "UDPrioridad";
            UDPrioridad.Size = new Size(283, 15);
            UDPrioridad.TabIndex = 4;
            UDPrioridad.Text = "Seleccione la regla de prioridad que desea actualizar:";
            // 
            // UpdateWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 457);
            Controls.Add(tabUpDate);
            Controls.Add(UpdateWinCancelar);
            Controls.Add(UpdateWinFinalizar);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateWindow";
            Text = "UpdateWindow";
            tabUpDate.ResumeLayout(false);
            ArticuloAct.ResumeLayout(false);
            ArticuloAct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IdArtiFind).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmpActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReglaActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantidadActual).EndInit();
            empaquesAct.ResumeLayout(false);
            empaquesAct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IdTStock).EndInit();
            PrioridadAct.ResumeLayout(false);
            PrioridadAct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IdPrio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button UpdateWinFinalizar;
        private Button UpdateWinCancelar;
        private TabControl tabUpDate;
        private TabPage ArticuloAct;
        private TabPage PrioridadAct;
        private Label UDItemName;
        private TextBox ArtElegido;
        private Label UDStock;
        private Label UDPrio;
        private Label UDPurchase;
        private Label UDExpiration;
        private DateTimePicker ExpiracionActual;
        private DateTimePicker CompraActual;
        private TextBox DescPrioAct;
        private TextBox RulePrioAct;
        private Label DescripciónActual;
        private Label PrioActual;
        private Label UDPrioridad;
        private Label UDTypeS;
        private TabPage empaquesAct;
        private Label UDTypeStock;
        private TextBox ActualizarEmp;
        private Label PreguntaEmpaqueAct;
        private NumericUpDown EmpActual;
        private NumericUpDown ReglaActual;
        private NumericUpDown CantidadActual;
        private Button UDSearch;
        private Label QIDArtoUD;
        private NumericUpDown IdArtiFind;
        private Button IdStockFind;
        private NumericUpDown IdTStock;
        private Button PrioFind;
        private NumericUpDown IdPrio;
    }
}