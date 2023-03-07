
namespace Ptriangulus
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblladoA = new System.Windows.Forms.Label();
            this.lblladoB = new System.Windows.Forms.Label();
            this.lblladoC = new System.Windows.Forms.Label();
            this.txtladoA = new System.Windows.Forms.TextBox();
            this.txtladoB = new System.Windows.Forms.TextBox();
            this.txtladoC = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Yellow;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Location = new System.Drawing.Point(221, 333);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Yellow;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Location = new System.Drawing.Point(116, 333);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Yellow;
            this.btncalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Location = new System.Drawing.Point(13, 333);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblladoA
            // 
            this.lblladoA.AutoSize = true;
            this.lblladoA.BackColor = System.Drawing.Color.Yellow;
            this.lblladoA.Font = new System.Drawing.Font("Antique Olive CompactPS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblladoA.Location = new System.Drawing.Point(12, 40);
            this.lblladoA.Name = "lblladoA";
            this.lblladoA.Size = new System.Drawing.Size(70, 16);
            this.lblladoA.TabIndex = 3;
            this.lblladoA.Text = "LADO A:";
            // 
            // lblladoB
            // 
            this.lblladoB.AutoSize = true;
            this.lblladoB.BackColor = System.Drawing.Color.Yellow;
            this.lblladoB.Font = new System.Drawing.Font("Antique Olive CompactPS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblladoB.Location = new System.Drawing.Point(12, 84);
            this.lblladoB.Name = "lblladoB";
            this.lblladoB.Size = new System.Drawing.Size(70, 16);
            this.lblladoB.TabIndex = 4;
            this.lblladoB.Text = "LADO B:";
            // 
            // lblladoC
            // 
            this.lblladoC.AutoSize = true;
            this.lblladoC.BackColor = System.Drawing.Color.Yellow;
            this.lblladoC.Font = new System.Drawing.Font("Antique Olive CompactPS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblladoC.Location = new System.Drawing.Point(10, 123);
            this.lblladoC.Name = "lblladoC";
            this.lblladoC.Size = new System.Drawing.Size(68, 16);
            this.lblladoC.TabIndex = 5;
            this.lblladoC.Text = "LADO C:";
            // 
            // txtladoA
            // 
            this.txtladoA.BackColor = System.Drawing.Color.Yellow;
            this.txtladoA.Font = new System.Drawing.Font("Antique Olive CompactPS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtladoA.Location = new System.Drawing.Point(195, 36);
            this.txtladoA.Name = "txtladoA";
            this.txtladoA.Size = new System.Drawing.Size(100, 21);
            this.txtladoA.TabIndex = 6;
            // 
            // txtladoB
            // 
            this.txtladoB.BackColor = System.Drawing.Color.Yellow;
            this.txtladoB.Font = new System.Drawing.Font("Antique Olive CompactPS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtladoB.Location = new System.Drawing.Point(196, 80);
            this.txtladoB.Name = "txtladoB";
            this.txtladoB.Size = new System.Drawing.Size(100, 21);
            this.txtladoB.TabIndex = 7;
            // 
            // txtladoC
            // 
            this.txtladoC.BackColor = System.Drawing.Color.Yellow;
            this.txtladoC.Font = new System.Drawing.Font("Antique Olive CompactPS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtladoC.Location = new System.Drawing.Point(196, 119);
            this.txtladoC.Name = "txtladoC";
            this.txtladoC.Size = new System.Drawing.Size(100, 21);
            this.txtladoC.TabIndex = 8;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.Yellow;
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Antique Olive CompactPS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(84, 249);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(138, 23);
            this.txtresultado.TabIndex = 9;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 379);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtladoC);
            this.Controls.Add(this.txtladoB);
            this.Controls.Add(this.txtladoA);
            this.Controls.Add(this.lblladoC);
            this.Controls.Add(this.lblladoB);
            this.Controls.Add(this.lblladoA);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTriangulus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblladoA;
        private System.Windows.Forms.Label lblladoB;
        private System.Windows.Forms.Label lblladoC;
        private System.Windows.Forms.TextBox txtladoA;
        private System.Windows.Forms.TextBox txtladoB;
        private System.Windows.Forms.TextBox txtladoC;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

