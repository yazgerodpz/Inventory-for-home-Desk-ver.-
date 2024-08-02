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
            SelecDelTab = new Label();
            tabControlDel = new TabControl();
            tabDelItem = new TabPage();
            DelCantidadActual = new NumericUpDown();
            DelExpAct = new DateTimePicker();
            DelCompAct = new DateTimePicker();
            DelExpiration = new Label();
            listBoxDelStock = new ListBox();
            listBoxDelPrio = new ListBox();
            DelPurchase = new Label();
            DelTypeS = new Label();
            DelPrio = new Label();
            DelStock = new Label();
            DelItemName = new Label();
            DelArtElegido = new TextBox();
            DelSearchArt = new Button();
            DelIDArt = new NumericUpDown();
            label2 = new Label();
            tabDelStock = new TabPage();
            QDelEmpaque = new Label();
            DelEmpaque = new TextBox();
            DelSearchStock = new Button();
            DelIDStock = new NumericUpDown();
            DelQStock = new Label();
            tabDelReglaPrio = new TabPage();
            DelDesc = new TextBox();
            DelRule = new TextBox();
            QDelDesc = new Label();
            QDelPrio = new Label();
            DelSearchPrio = new Button();
            DelIDPrio = new NumericUpDown();
            label3 = new Label();
            tabControlDel.SuspendLayout();
            tabDelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelCantidadActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DelIDArt).BeginInit();
            tabDelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelIDStock).BeginInit();
            tabDelReglaPrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelIDPrio).BeginInit();
            SuspendLayout();
            // 
            // DeletedWinFinalizar
            // 
            DeletedWinFinalizar.Location = new Point(573, 440);
            DeletedWinFinalizar.Name = "DeletedWinFinalizar";
            DeletedWinFinalizar.Size = new Size(75, 23);
            DeletedWinFinalizar.TabIndex = 0;
            DeletedWinFinalizar.Text = "Finalizar";
            DeletedWinFinalizar.UseVisualStyleBackColor = true;
            DeletedWinFinalizar.Click += DeletedWinFinalizar_Click;
            // 
            // DeletedWinCancelar
            // 
            DeletedWinCancelar.Location = new Point(654, 440);
            DeletedWinCancelar.Name = "DeletedWinCancelar";
            DeletedWinCancelar.Size = new Size(75, 23);
            DeletedWinCancelar.TabIndex = 1;
            DeletedWinCancelar.Text = "Cancelar";
            DeletedWinCancelar.UseVisualStyleBackColor = true;
            DeletedWinCancelar.Click += DeletedWinCancelar_Click;
            // 
            // SelecDelTab
            // 
            SelecDelTab.AutoSize = true;
            SelecDelTab.Location = new Point(12, 9);
            SelecDelTab.Name = "SelecDelTab";
            SelecDelTab.Size = new Size(170, 15);
            SelecDelTab.TabIndex = 2;
            SelecDelTab.Text = "Seleccione lo que desea borrar:";
            // 
            // tabControlDel
            // 
            tabControlDel.Controls.Add(tabDelItem);
            tabControlDel.Controls.Add(tabDelStock);
            tabControlDel.Controls.Add(tabDelReglaPrio);
            tabControlDel.Location = new Point(12, 41);
            tabControlDel.Name = "tabControlDel";
            tabControlDel.SelectedIndex = 0;
            tabControlDel.Size = new Size(701, 397);
            tabControlDel.TabIndex = 3;
            // 
            // tabDelItem
            // 
            tabDelItem.Controls.Add(DelCantidadActual);
            tabDelItem.Controls.Add(DelExpAct);
            tabDelItem.Controls.Add(DelCompAct);
            tabDelItem.Controls.Add(DelExpiration);
            tabDelItem.Controls.Add(listBoxDelStock);
            tabDelItem.Controls.Add(listBoxDelPrio);
            tabDelItem.Controls.Add(DelPurchase);
            tabDelItem.Controls.Add(DelTypeS);
            tabDelItem.Controls.Add(DelPrio);
            tabDelItem.Controls.Add(DelStock);
            tabDelItem.Controls.Add(DelItemName);
            tabDelItem.Controls.Add(DelArtElegido);
            tabDelItem.Controls.Add(DelSearchArt);
            tabDelItem.Controls.Add(DelIDArt);
            tabDelItem.Controls.Add(label2);
            tabDelItem.Location = new Point(4, 24);
            tabDelItem.Name = "tabDelItem";
            tabDelItem.Padding = new Padding(3);
            tabDelItem.Size = new Size(693, 369);
            tabDelItem.TabIndex = 0;
            tabDelItem.Text = "Artículos";
            tabDelItem.UseVisualStyleBackColor = true;
            // 
            // DelCantidadActual
            // 
            DelCantidadActual.Location = new Point(6, 121);
            DelCantidadActual.Name = "DelCantidadActual";
            DelCantidadActual.Size = new Size(120, 23);
            DelCantidadActual.TabIndex = 22;
            // 
            // DelExpAct
            // 
            DelExpAct.Location = new Point(6, 320);
            DelExpAct.Name = "DelExpAct";
            DelExpAct.Size = new Size(227, 23);
            DelExpAct.TabIndex = 19;
            // 
            // DelCompAct
            // 
            DelCompAct.Location = new Point(6, 276);
            DelCompAct.Name = "DelCompAct";
            DelCompAct.Size = new Size(227, 23);
            DelCompAct.TabIndex = 18;
            // 
            // DelExpiration
            // 
            DelExpiration.AutoSize = true;
            DelExpiration.Location = new Point(6, 302);
            DelExpiration.Name = "DelExpiration";
            DelExpiration.Size = new Size(115, 15);
            DelExpiration.TabIndex = 17;
            DelExpiration.Text = "Fecha de expiración:";
            // 
            // listBoxDelStock
            // 
            listBoxDelStock.FormattingEnabled = true;
            listBoxDelStock.ItemHeight = 15;
            listBoxDelStock.Location = new Point(6, 221);
            listBoxDelStock.Name = "listBoxDelStock";
            listBoxDelStock.Size = new Size(355, 19);
            listBoxDelStock.TabIndex = 16;
            // 
            // listBoxDelPrio
            // 
            listBoxDelPrio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxDelPrio.FormattingEnabled = true;
            listBoxDelPrio.ItemHeight = 15;
            listBoxDelPrio.Location = new Point(6, 166);
            listBoxDelPrio.Name = "listBoxDelPrio";
            listBoxDelPrio.Size = new Size(681, 19);
            listBoxDelPrio.TabIndex = 15;
            // 
            // DelPurchase
            // 
            DelPurchase.AutoSize = true;
            DelPurchase.Location = new Point(6, 258);
            DelPurchase.Name = "DelPurchase";
            DelPurchase.Size = new Size(101, 15);
            DelPurchase.TabIndex = 13;
            DelPurchase.Text = "Fecha de compra:";
            // 
            // DelTypeS
            // 
            DelTypeS.AutoSize = true;
            DelTypeS.Location = new Point(6, 203);
            DelTypeS.Name = "DelTypeS";
            DelTypeS.Size = new Size(60, 15);
            DelTypeS.TabIndex = 12;
            DelTypeS.Text = "Empaque:";
            // 
            // DelPrio
            // 
            DelPrio.AutoSize = true;
            DelPrio.Location = new Point(6, 147);
            DelPrio.Name = "DelPrio";
            DelPrio.Size = new Size(106, 15);
            DelPrio.TabIndex = 11;
            DelPrio.Text = "Regla de prioridad:";
            // 
            // DelStock
            // 
            DelStock.AutoSize = true;
            DelStock.Location = new Point(6, 103);
            DelStock.Name = "DelStock";
            DelStock.Size = new Size(58, 15);
            DelStock.TabIndex = 10;
            DelStock.Text = "Cantidad:";
            // 
            // DelItemName
            // 
            DelItemName.AutoSize = true;
            DelItemName.Location = new Point(6, 59);
            DelItemName.Name = "DelItemName";
            DelItemName.Size = new Size(52, 15);
            DelItemName.TabIndex = 9;
            DelItemName.Text = "Artículo:";
            // 
            // DelArtElegido
            // 
            DelArtElegido.Location = new Point(6, 77);
            DelArtElegido.Name = "DelArtElegido";
            DelArtElegido.Size = new Size(100, 23);
            DelArtElegido.TabIndex = 8;
            // 
            // DelSearchArt
            // 
            DelSearchArt.Location = new Point(150, 33);
            DelSearchArt.Name = "DelSearchArt";
            DelSearchArt.Size = new Size(75, 23);
            DelSearchArt.TabIndex = 7;
            DelSearchArt.Text = "Buscar";
            DelSearchArt.UseVisualStyleBackColor = true;
            DelSearchArt.Click += DelSearchArt_Click;
            // 
            // DelIDArt
            // 
            DelIDArt.Location = new Point(6, 33);
            DelIDArt.Name = "DelIDArt";
            DelIDArt.Size = new Size(120, 23);
            DelIDArt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 15);
            label2.Name = "label2";
            label2.Size = new Size(216, 15);
            label2.TabIndex = 4;
            label2.Text = "Seleccione el ID del artículo ha eliminar:";
            // 
            // tabDelStock
            // 
            tabDelStock.Controls.Add(QDelEmpaque);
            tabDelStock.Controls.Add(DelEmpaque);
            tabDelStock.Controls.Add(DelSearchStock);
            tabDelStock.Controls.Add(DelIDStock);
            tabDelStock.Controls.Add(DelQStock);
            tabDelStock.Location = new Point(4, 24);
            tabDelStock.Name = "tabDelStock";
            tabDelStock.Size = new Size(693, 369);
            tabDelStock.TabIndex = 2;
            tabDelStock.Text = "Empaques";
            tabDelStock.UseVisualStyleBackColor = true;
            // 
            // QDelEmpaque
            // 
            QDelEmpaque.AutoSize = true;
            QDelEmpaque.Location = new Point(6, 73);
            QDelEmpaque.Name = "QDelEmpaque";
            QDelEmpaque.Size = new Size(118, 15);
            QDelEmpaque.TabIndex = 18;
            QDelEmpaque.Text = "Empaque y cantidad:";
            // 
            // DelEmpaque
            // 
            DelEmpaque.Location = new Point(6, 91);
            DelEmpaque.Name = "DelEmpaque";
            DelEmpaque.Size = new Size(233, 23);
            DelEmpaque.TabIndex = 17;
            // 
            // DelSearchStock
            // 
            DelSearchStock.Location = new Point(149, 34);
            DelSearchStock.Name = "DelSearchStock";
            DelSearchStock.Size = new Size(75, 23);
            DelSearchStock.TabIndex = 8;
            DelSearchStock.Text = "Buscar";
            DelSearchStock.UseVisualStyleBackColor = true;
            DelSearchStock.Click += DelSearchStock_Click;
            // 
            // DelIDStock
            // 
            DelIDStock.Location = new Point(6, 34);
            DelIDStock.Name = "DelIDStock";
            DelIDStock.Size = new Size(120, 23);
            DelIDStock.TabIndex = 7;
            // 
            // DelQStock
            // 
            DelQStock.AutoSize = true;
            DelQStock.Location = new Point(6, 16);
            DelQStock.Name = "DelQStock";
            DelQStock.Size = new Size(266, 15);
            DelQStock.TabIndex = 0;
            DelQStock.Text = "Seleccione el ID del empaque que desea eliminar:";
            // 
            // tabDelReglaPrio
            // 
            tabDelReglaPrio.Controls.Add(DelDesc);
            tabDelReglaPrio.Controls.Add(DelRule);
            tabDelReglaPrio.Controls.Add(QDelDesc);
            tabDelReglaPrio.Controls.Add(QDelPrio);
            tabDelReglaPrio.Controls.Add(DelSearchPrio);
            tabDelReglaPrio.Controls.Add(DelIDPrio);
            tabDelReglaPrio.Controls.Add(label3);
            tabDelReglaPrio.Location = new Point(4, 24);
            tabDelReglaPrio.Name = "tabDelReglaPrio";
            tabDelReglaPrio.Padding = new Padding(3);
            tabDelReglaPrio.Size = new Size(693, 369);
            tabDelReglaPrio.TabIndex = 1;
            tabDelReglaPrio.Text = "Reglas de importancia";
            tabDelReglaPrio.UseVisualStyleBackColor = true;
            // 
            // DelDesc
            // 
            DelDesc.Location = new Point(6, 142);
            DelDesc.Multiline = true;
            DelDesc.Name = "DelDesc";
            DelDesc.Size = new Size(670, 140);
            DelDesc.TabIndex = 17;
            // 
            // DelRule
            // 
            DelRule.Location = new Point(6, 98);
            DelRule.Name = "DelRule";
            DelRule.Size = new Size(100, 23);
            DelRule.TabIndex = 16;
            // 
            // QDelDesc
            // 
            QDelDesc.AutoSize = true;
            QDelDesc.Location = new Point(6, 124);
            QDelDesc.Name = "QDelDesc";
            QDelDesc.Size = new Size(72, 15);
            QDelDesc.TabIndex = 15;
            QDelDesc.Text = "Descripción:";
            // 
            // QDelPrio
            // 
            QDelPrio.AutoSize = true;
            QDelPrio.Location = new Point(6, 80);
            QDelPrio.Name = "QDelPrio";
            QDelPrio.Size = new Size(106, 15);
            QDelPrio.TabIndex = 14;
            QDelPrio.Text = "Regla de prioridad:";
            // 
            // DelSearchPrio
            // 
            DelSearchPrio.Location = new Point(149, 34);
            DelSearchPrio.Name = "DelSearchPrio";
            DelSearchPrio.Size = new Size(75, 23);
            DelSearchPrio.TabIndex = 8;
            DelSearchPrio.Text = "Buscar";
            DelSearchPrio.UseVisualStyleBackColor = true;
            DelSearchPrio.Click += DelSearchPrio_Click;
            // 
            // DelIDPrio
            // 
            DelIDPrio.Location = new Point(6, 34);
            DelIDPrio.Name = "DelIDPrio";
            DelIDPrio.Size = new Size(120, 23);
            DelIDPrio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(211, 15);
            label3.TabIndex = 4;
            label3.Text = "Seleccione el ID de la regla ha eliminar:";
            // 
            // DeletedWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 470);
            Controls.Add(tabControlDel);
            Controls.Add(SelecDelTab);
            Controls.Add(DeletedWinCancelar);
            Controls.Add(DeletedWinFinalizar);
            Name = "DeletedWindow";
            Text = "DeletedWindow";
            tabControlDel.ResumeLayout(false);
            tabDelItem.ResumeLayout(false);
            tabDelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelCantidadActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)DelIDArt).EndInit();
            tabDelStock.ResumeLayout(false);
            tabDelStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelIDStock).EndInit();
            tabDelReglaPrio.ResumeLayout(false);
            tabDelReglaPrio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelIDPrio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeletedWinFinalizar;
        private Button DeletedWinCancelar;
        private Label SelecDelTab;
        private TabControl tabControlDel;
        private TabPage tabDelItem;
        private TabPage tabDelReglaPrio;
        private Label label2;
        private Label label3;
        private TabPage tabDelStock;
        private Label DelQStock;
        private Button DelSearchArt;
        private NumericUpDown DelIDArt;
        private Button DelSearchStock;
        private NumericUpDown DelIDStock;
        private Button DelSearchPrio;
        private NumericUpDown DelIDPrio;
        private Label DelItemName;
        private TextBox DelArtElegido;
        private Label DelPurchase;
        private Label DelTypeS;
        private Label DelPrio;
        private Label DelStock;
        private ListBox listBoxDelPrio;
        private ListBox listBoxDelStock;
        private DateTimePicker DelExpAct;
        private DateTimePicker DelCompAct;
        private Label DelExpiration;
        private Label QDelDesc;
        private Label QDelPrio;
        private TextBox DelDesc;
        private TextBox DelRule;
        private Label QDelEmpaque;
        private TextBox DelEmpaque;
        private NumericUpDown DelCantidadActual;
    }
}