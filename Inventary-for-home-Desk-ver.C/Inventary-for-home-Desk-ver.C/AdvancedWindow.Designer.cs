namespace Inventary_for_home_Desk_ver.C
{
    partial class AdvancedWindow
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
            AdvCancelar = new Button();
            SuspendLayout();
            // 
            // AdvCancelar
            // 
            AdvCancelar.Location = new Point(147, 185);
            AdvCancelar.Name = "AdvCancelar";
            AdvCancelar.Size = new Size(75, 23);
            AdvCancelar.TabIndex = 0;
            AdvCancelar.Text = "Cancelar";
            AdvCancelar.UseVisualStyleBackColor = true;
            AdvCancelar.Click += AdvCancelar_Click;
            // 
            // AdvancedWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdvCancelar);
            Name = "AdvancedWindow";
            Text = "AdvancedWindow";
            ResumeLayout(false);
        }

        #endregion

        private Button AdvCancelar;
    }
}