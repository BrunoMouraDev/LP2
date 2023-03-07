namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnInserirTexto = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnInserirAsterisco = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(230, 307);
            this.btnTestar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(130, 74);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "Testar Iguais";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnInserirTexto
            // 
            this.btnInserirTexto.Location = new System.Drawing.Point(433, 306);
            this.btnInserirTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserirTexto.Name = "btnInserirTexto";
            this.btnInserirTexto.Size = new System.Drawing.Size(143, 75);
            this.btnInserirTexto.TabIndex = 1;
            this.btnInserirTexto.Text = "Inserir Texto 1 no Texto 2";
            this.btnInserirTexto.UseVisualStyleBackColor = true;
            this.btnInserirTexto.Click += new System.EventHandler(this.btnInserirTexto_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(428, 118);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(148, 26);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(428, 197);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(148, 26);
            this.txtPalavra2.TabIndex = 3;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(272, 127);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 4;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(272, 197);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 5;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnInserirAsterisco
            // 
            this.btnInserirAsterisco.Location = new System.Drawing.Point(626, 307);
            this.btnInserirAsterisco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserirAsterisco.Name = "btnInserirAsterisco";
            this.btnInserirAsterisco.Size = new System.Drawing.Size(141, 74);
            this.btnInserirAsterisco.TabIndex = 6;
            this.btnInserirAsterisco.Text = "Inserir Asterisco no Texto 1";
            this.btnInserirAsterisco.UseVisualStyleBackColor = true;
            this.btnInserirAsterisco.Click += new System.EventHandler(this.btnInserirAsterisco_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(811, 306);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 74);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 702);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInserirAsterisco);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnInserirTexto);
            this.Controls.Add(this.btnTestar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnInserirTexto;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnInserirAsterisco;
        private System.Windows.Forms.Button btnLimpar;
    }
}