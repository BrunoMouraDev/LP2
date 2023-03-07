namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.btncalculo = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRaio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(51, 64);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(80, 33);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(51, 135);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(93, 31);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura:";
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolume.Location = new System.Drawing.Point(51, 211);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(113, 31);
            this.lblvolume.TabIndex = 2;
            this.lblvolume.Text = "Volume:";
            // 
            // txtraio
            // 
            this.txtraio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtraio.Location = new System.Drawing.Point(188, 71);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(150, 26);
            this.txtraio.TabIndex = 3;
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(188, 142);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(150, 26);
            this.txtaltura.TabIndex = 4;
            // 
            // txtvolume
            // 
            this.txtvolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvolume.Enabled = false;
            this.txtvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolume.Location = new System.Drawing.Point(188, 211);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(150, 22);
            this.txtvolume.TabIndex = 5;
            // 
            // btncalculo
            // 
            this.btncalculo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btncalculo.Location = new System.Drawing.Point(12, 323);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(126, 30);
            this.btncalculo.TabIndex = 6;
            this.btncalculo.Text = "Calcular";
            this.btncalculo.UseVisualStyleBackColor = false;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(273, 323);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(126, 30);
            this.btnfechar.TabIndex = 7;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(141, 323);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(126, 30);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.txtvolume);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblRaio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Raio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnlimpar;
    }
}

