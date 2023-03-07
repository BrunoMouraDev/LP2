namespace PTesteMetodos
{
    partial class frmExercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio4));
            this.rtbConteudo = new System.Windows.Forms.RichTextBox();
            this.btnNums = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.Location = new System.Drawing.Point(330, 53);
            this.rtbConteudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(314, 154);
            this.rtbConteudo.TabIndex = 0;
            this.rtbConteudo.Text = "";
            // 
            // btnNums
            // 
            this.btnNums.Location = new System.Drawing.Point(181, 237);
            this.btnNums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNums.Name = "btnNums";
            this.btnNums.Size = new System.Drawing.Size(162, 108);
            this.btnNums.TabIndex = 1;
            this.btnNums.Text = "Quantidade de caracteres númericos";
            this.btnNums.UseVisualStyleBackColor = true;
            this.btnNums.Click += new System.EventHandler(this.btnNums_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(421, 237);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(159, 108);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Posição onde há o primeiro espaço em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(661, 237);
            this.btnLetras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(158, 108);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Quantidade de cacteres alfabéticos";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(421, 353);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(159, 28);
            this.txtResultado.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(446, 407);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 33);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 521);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNums);
            this.Controls.Add(this.rtbConteudo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExercicio4";
            this.Text = "Exercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.Button btnNums;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}