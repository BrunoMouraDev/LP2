namespace Pclasses
{
    partial class frmMensalista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensalista));
            this.button1 = new System.Windows.Forms.Button();
            this.btnparametro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtadmissao = new System.Windows.Forms.TextBox();
            this.gbxhome = new System.Windows.Forms.GroupBox();
            this.rbtnnao = new System.Windows.Forms.RadioButton();
            this.rbtnsim = new System.Windows.Forms.RadioButton();
            this.gbxhome.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSTANCIAR MENSALISTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnparametro
            // 
            this.btnparametro.Location = new System.Drawing.Point(272, 302);
            this.btnparametro.Name = "btnparametro";
            this.btnparametro.Size = new System.Drawing.Size(223, 74);
            this.btnparametro.TabIndex = 1;
            this.btnparametro.Text = "INSTANCIAR MENSALISTA PASSANDO PARAMETRO";
            this.btnparametro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MATRICULA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SALARIO POR HORA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DATA DE ADMISSÃO:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(192, 55);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(192, 105);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 7;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(192, 163);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 8;
            // 
            // txtadmissao
            // 
            this.txtadmissao.Location = new System.Drawing.Point(192, 221);
            this.txtadmissao.Name = "txtadmissao";
            this.txtadmissao.Size = new System.Drawing.Size(100, 20);
            this.txtadmissao.TabIndex = 9;
            // 
            // gbxhome
            // 
            this.gbxhome.Controls.Add(this.rbtnnao);
            this.gbxhome.Controls.Add(this.rbtnsim);
            this.gbxhome.Location = new System.Drawing.Point(348, 87);
            this.gbxhome.Name = "gbxhome";
            this.gbxhome.Size = new System.Drawing.Size(147, 119);
            this.gbxhome.TabIndex = 10;
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
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 431);
            this.Controls.Add(this.gbxhome);
            this.Controls.Add(this.txtadmissao);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnparametro);
            this.Controls.Add(this.button1);
            this.Name = "frmMensalista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMensalista";
            this.gbxhome.ResumeLayout(false);
            this.gbxhome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnparametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtadmissao;
        private System.Windows.Forms.GroupBox gbxhome;
        private System.Windows.Forms.RadioButton rbtnnao;
        private System.Windows.Forms.RadioButton rbtnsim;
    }
}