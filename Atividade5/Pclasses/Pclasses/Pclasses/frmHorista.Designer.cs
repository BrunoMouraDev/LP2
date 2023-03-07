namespace Pclasses
{
    partial class frmHorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorista));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsalariohoras = new System.Windows.Forms.TextBox();
            this.txtadmissao = new System.Windows.Forms.TextBox();
            this.gbxhome = new System.Windows.Forms.GroupBox();
            this.rbtnnao = new System.Windows.Forms.RadioButton();
            this.rbtnsim = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txthumerohoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfaltas = new System.Windows.Forms.TextBox();
            this.gbxhome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MATRICULA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(37, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SALARIO POR HORAS :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DATA DE ADMISSÃO:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(184, 46);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(184, 72);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 8;
            // 
            // txtsalariohoras
            // 
            this.txtsalariohoras.Location = new System.Drawing.Point(184, 98);
            this.txtsalariohoras.Name = "txtsalariohoras";
            this.txtsalariohoras.Size = new System.Drawing.Size(100, 20);
            this.txtsalariohoras.TabIndex = 9;
            this.txtsalariohoras.TextChanged += new System.EventHandler(this.txtsalariohoras_TextChanged);
            // 
            // txtadmissao
            // 
            this.txtadmissao.Location = new System.Drawing.Point(184, 150);
            this.txtadmissao.Name = "txtadmissao";
            this.txtadmissao.Size = new System.Drawing.Size(100, 20);
            this.txtadmissao.TabIndex = 10;
            // 
            // gbxhome
            // 
            this.gbxhome.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gbxhome.Controls.Add(this.rbtnnao);
            this.gbxhome.Controls.Add(this.rbtnsim);
            this.gbxhome.Location = new System.Drawing.Point(317, 72);
            this.gbxhome.Name = "gbxhome";
            this.gbxhome.Size = new System.Drawing.Size(147, 119);
            this.gbxhome.TabIndex = 11;
            this.gbxhome.TabStop = false;
            this.gbxhome.Text = "Trabalha em HomeOffice";
            // 
            // rbtnnao
            // 
            this.rbtnnao.AutoSize = true;
            this.rbtnnao.Checked = true;
            this.rbtnnao.Location = new System.Drawing.Point(19, 82);
            this.rbtnnao.Name = "rbtnnao";
            this.rbtnnao.Size = new System.Drawing.Size(45, 17);
            this.rbtnnao.TabIndex = 1;
            this.rbtnnao.TabStop = true;
            this.rbtnnao.Text = "Não";
            this.rbtnnao.UseVisualStyleBackColor = true;
            // 
            // rbtnsim
            // 
            this.rbtnsim.AutoSize = true;
            this.rbtnsim.Location = new System.Drawing.Point(22, 45);
            this.rbtnsim.Name = "rbtnsim";
            this.rbtnsim.Size = new System.Drawing.Size(42, 17);
            this.rbtnsim.TabIndex = 0;
            this.rbtnsim.Text = "Sim";
            this.rbtnsim.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 74);
            this.button1.TabIndex = 12;
            this.button1.Text = "INSTANCIAR HORISTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label5.Location = new System.Drawing.Point(37, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "NÚMERO DE HORAS :";
            // 
            // txthumerohoras
            // 
            this.txthumerohoras.Location = new System.Drawing.Point(184, 124);
            this.txthumerohoras.Name = "txthumerohoras";
            this.txthumerohoras.Size = new System.Drawing.Size(100, 20);
            this.txthumerohoras.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Location = new System.Drawing.Point(37, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DIAS FALTADOS:";
            // 
            // txtfaltas
            // 
            this.txtfaltas.Location = new System.Drawing.Point(184, 184);
            this.txtfaltas.Name = "txtfaltas";
            this.txtfaltas.Size = new System.Drawing.Size(100, 20);
            this.txtfaltas.TabIndex = 16;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 439);
            this.Controls.Add(this.txtfaltas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthumerohoras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxhome);
            this.Controls.Add(this.txtadmissao);
            this.Controls.Add(this.txtsalariohoras);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHorista";
            this.gbxhome.ResumeLayout(false);
            this.gbxhome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsalariohoras;
        private System.Windows.Forms.TextBox txtadmissao;
        private System.Windows.Forms.GroupBox gbxhome;
        private System.Windows.Forms.RadioButton rbtnnao;
        private System.Windows.Forms.RadioButton rbtnsim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthumerohoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfaltas;
    }
}