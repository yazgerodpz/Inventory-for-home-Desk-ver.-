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
            SuspendLayout();
            // 
            // DeletedWinFinalizar
            // 
            DeletedWinFinalizar.Location = new Point(632, 389);
            DeletedWinFinalizar.Name = "DeletedWinFinalizar";
            DeletedWinFinalizar.Size = new Size(75, 23);
            DeletedWinFinalizar.TabIndex = 0;
            DeletedWinFinalizar.Text = "Finalizar";
            DeletedWinFinalizar.UseVisualStyleBackColor = true;
            // 
            // DeletedWinCancelar
            // 
            DeletedWinCancelar.Location = new Point(713, 389);
            DeletedWinCancelar.Name = "DeletedWinCancelar";
            DeletedWinCancelar.Size = new Size(75, 23);
            DeletedWinCancelar.TabIndex = 1;
            DeletedWinCancelar.Text = "Cancelar";
            DeletedWinCancelar.UseVisualStyleBackColor = true;
            DeletedWinCancelar.Click += DeletedWinCancelar_Click;
            // 
            // DeletedWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeletedWinCancelar);
            Controls.Add(DeletedWinFinalizar);
            Name = "DeletedWindow";
            Text = "DeletedWindow";
            ResumeLayout(false);
        }

        #endregion

        private Button DeletedWinFinalizar;
        private Button DeletedWinCancelar;
    }
}