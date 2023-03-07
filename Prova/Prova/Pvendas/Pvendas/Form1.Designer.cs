namespace Pvendas
{
    partial class Form1
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
            this.lstbxValores = new System.Windows.Forms.ListBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxValores
            // 
            this.lstbxValores.FormattingEnabled = true;
            this.lstbxValores.Location = new System.Drawing.Point(196, 64);
            this.lstbxValores.Name = "lstbxValores";
            this.lstbxValores.Size = new System.Drawing.Size(382, 355);
            this.lstbxValores.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(40, 200);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(127, 62);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 498);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lstbxValores);
            this.Name = "Form1";
            this.Text = "Pvendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxValores;
        private System.Windows.Forms.Button btnVerificar;
    }
}

