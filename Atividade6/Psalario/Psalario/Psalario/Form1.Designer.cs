
namespace Psalario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblinfor = new System.Windows.Forms.Label();
            this.lblAliinss = new System.Windows.Forms.Label();
            this.lblAliirpf = new System.Windows.Forms.Label();
            this.lblSalfam = new System.Windows.Forms.Label();
            this.lblSalliq = new System.Windows.Forms.Label();
            this.lblDesinss = new System.Windows.Forms.Label();
            this.lblDesirpf = new System.Windows.Forms.Label();
            this.msbxsal = new System.Windows.Forms.MaskedTextBox();
            this.btnval = new System.Windows.Forms.Button();
            this.gbxsexo = new System.Windows.Forms.GroupBox();
            this.rbtnm = new System.Windows.Forms.RadioButton();
            this.rbtnf = new System.Windows.Forms.RadioButton();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cbxcasado = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdescirpf = new System.Windows.Forms.MaskedTextBox();
            this.mskdescinss = new System.Windows.Forms.MaskedTextBox();
            this.msksalliq = new System.Windows.Forms.MaskedTextBox();
            this.msksalfam = new System.Windows.Forms.MaskedTextBox();
            this.mskaliirpf = new System.Windows.Forms.MaskedTextBox();
            this.mskaliinss = new System.Windows.Forms.MaskedTextBox();
            this.btnfechar = new System.Windows.Forms.Button();
            this.cbxfilhos = new System.Windows.Forms.ComboBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.gbxsexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(151, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME FUNCIONARIO:";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(54, 66);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(124, 17);
            this.lblSal.TabIndex = 1;
            this.lblSal.Text = "SALÁRIO BRUTO:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(51, 111);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(61, 17);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "FILHOS:";
            // 
            // lblinfor
            // 
            this.lblinfor.AutoSize = true;
            this.lblinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfor.Location = new System.Drawing.Point(51, 229);
            this.lblinfor.Name = "lblinfor";
            this.lblinfor.Size = new System.Drawing.Size(8, 17);
            this.lblinfor.TabIndex = 3;
            this.lblinfor.Text = "\r\n";
            // 
            // lblAliinss
            // 
            this.lblAliinss.AutoSize = true;
            this.lblAliinss.Location = new System.Drawing.Point(24, 36);
            this.lblAliinss.Name = "lblAliinss";
            this.lblAliinss.Size = new System.Drawing.Size(113, 17);
            this.lblAliinss.TabIndex = 4;
            this.lblAliinss.Text = "ALIQUOTA INSS";
            // 
            // lblAliirpf
            // 
            this.lblAliirpf.AutoSize = true;
            this.lblAliirpf.Location = new System.Drawing.Point(24, 83);
            this.lblAliirpf.Name = "lblAliirpf";
            this.lblAliirpf.Size = new System.Drawing.Size(112, 17);
            this.lblAliirpf.TabIndex = 5;
            this.lblAliirpf.Text = "ALIQUOTA IRPF";
            // 
            // lblSalfam
            // 
            this.lblSalfam.AutoSize = true;
            this.lblSalfam.Location = new System.Drawing.Point(26, 132);
            this.lblSalfam.Name = "lblSalfam";
            this.lblSalfam.Size = new System.Drawing.Size(122, 17);
            this.lblSalfam.TabIndex = 6;
            this.lblSalfam.Text = "SALÁRIO FAMILIA";
            // 
            // lblSalliq
            // 
            this.lblSalliq.AutoSize = true;
            this.lblSalliq.Location = new System.Drawing.Point(26, 181);
            this.lblSalliq.Name = "lblSalliq";
            this.lblSalliq.Size = new System.Drawing.Size(127, 17);
            this.lblSalliq.TabIndex = 7;
            this.lblSalliq.Text = "SALÁRIO LIQUIDO";
            // 
            // lblDesinss
            // 
            this.lblDesinss.AutoSize = true;
            this.lblDesinss.Location = new System.Drawing.Point(352, 29);
            this.lblDesinss.Name = "lblDesinss";
            this.lblDesinss.Size = new System.Drawing.Size(121, 17);
            this.lblDesinss.TabIndex = 8;
            this.lblDesinss.Text = "DESCONTO INSS";
            // 
            // lblDesirpf
            // 
            this.lblDesirpf.AutoSize = true;
            this.lblDesirpf.Location = new System.Drawing.Point(353, 86);
            this.lblDesirpf.Name = "lblDesirpf";
            this.lblDesirpf.Size = new System.Drawing.Size(120, 17);
            this.lblDesirpf.TabIndex = 9;
            this.lblDesirpf.Text = "DESCONTO IRPF";
            // 
            // msbxsal
            // 
            this.msbxsal.Location = new System.Drawing.Point(208, 61);
            this.msbxsal.Mask = "00000.00";
            this.msbxsal.Name = "msbxsal";
            this.msbxsal.Size = new System.Drawing.Size(131, 22);
            this.msbxsal.TabIndex = 10;
            // 
            // btnval
            // 
            this.btnval.Location = new System.Drawing.Point(269, 172);
            this.btnval.Name = "btnval";
            this.btnval.Size = new System.Drawing.Size(164, 46);
            this.btnval.TabIndex = 11;
            this.btnval.Text = "VALIDAR DESCONTO";
            this.btnval.UseVisualStyleBackColor = true;
            this.btnval.Click += new System.EventHandler(this.btnval_Click);
            // 
            // gbxsexo
            // 
            this.gbxsexo.Controls.Add(this.rbtnm);
            this.gbxsexo.Controls.Add(this.rbtnf);
            this.gbxsexo.Location = new System.Drawing.Point(383, 14);
            this.gbxsexo.Name = "gbxsexo";
            this.gbxsexo.Size = new System.Drawing.Size(200, 116);
            this.gbxsexo.TabIndex = 12;
            this.gbxsexo.TabStop = false;
            this.gbxsexo.Text = "SEXO";
            // 
            // rbtnm
            // 
            this.rbtnm.AutoSize = true;
            this.rbtnm.Location = new System.Drawing.Point(37, 70);
            this.rbtnm.Name = "rbtnm";
            this.rbtnm.Size = new System.Drawing.Size(40, 21);
            this.rbtnm.TabIndex = 20;
            this.rbtnm.Text = "M";
            this.rbtnm.UseVisualStyleBackColor = true;
            // 
            // rbtnf
            // 
            this.rbtnf.AutoSize = true;
            this.rbtnf.Checked = true;
            this.rbtnf.Location = new System.Drawing.Point(37, 31);
            this.rbtnf.Name = "rbtnf";
            this.rbtnf.Size = new System.Drawing.Size(37, 21);
            this.rbtnf.TabIndex = 0;
            this.rbtnf.TabStop = true;
            this.rbtnf.Text = "F";
            this.rbtnf.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(208, 22);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(131, 22);
            this.txtnome.TabIndex = 19;
            // 
            // cbxcasado
            // 
            this.cbxcasado.AutoSize = true;
            this.cbxcasado.Location = new System.Drawing.Point(301, 145);
            this.cbxcasado.Name = "cbxcasado";
            this.cbxcasado.Size = new System.Drawing.Size(87, 21);
            this.cbxcasado.TabIndex = 20;
            this.cbxcasado.Text = "CASADO";
            this.cbxcasado.UseVisualStyleBackColor = true;
            this.cbxcasado.CheckedChanged += new System.EventHandler(this.cbxcasado_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(299, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "HOLERITE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdescirpf);
            this.groupBox1.Controls.Add(this.mskdescinss);
            this.groupBox1.Controls.Add(this.msksalliq);
            this.groupBox1.Controls.Add(this.msksalfam);
            this.groupBox1.Controls.Add(this.mskaliirpf);
            this.groupBox1.Controls.Add(this.mskaliinss);
            this.groupBox1.Controls.Add(this.lblAliinss);
            this.groupBox1.Controls.Add(this.lblAliirpf);
            this.groupBox1.Controls.Add(this.lblSalfam);
            this.groupBox1.Controls.Add(this.lblSalliq);
            this.groupBox1.Controls.Add(this.lblDesinss);
            this.groupBox1.Controls.Add(this.lblDesirpf);
            this.groupBox1.Location = new System.Drawing.Point(27, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 225);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // mskdescirpf
            // 
            this.mskdescirpf.Enabled = false;
            this.mskdescirpf.Location = new System.Drawing.Point(479, 85);
            this.mskdescirpf.Name = "mskdescirpf";
            this.mskdescirpf.Size = new System.Drawing.Size(131, 22);
            this.mskdescirpf.TabIndex = 27;
            // 
            // mskdescinss
            // 
            this.mskdescinss.Enabled = false;
            this.mskdescinss.Location = new System.Drawing.Point(479, 29);
            this.mskdescinss.Name = "mskdescinss";
            this.mskdescinss.Size = new System.Drawing.Size(131, 22);
            this.mskdescinss.TabIndex = 26;
            // 
            // msksalliq
            // 
            this.msksalliq.Enabled = false;
            this.msksalliq.Location = new System.Drawing.Point(166, 183);
            this.msksalliq.Name = "msksalliq";
            this.msksalliq.Size = new System.Drawing.Size(131, 22);
            this.msksalliq.TabIndex = 25;
            // 
            // msksalfam
            // 
            this.msksalfam.Enabled = false;
            this.msksalfam.Location = new System.Drawing.Point(166, 127);
            this.msksalfam.Name = "msksalfam";
            this.msksalfam.Size = new System.Drawing.Size(131, 22);
            this.msksalfam.TabIndex = 24;
            // 
            // mskaliirpf
            // 
            this.mskaliirpf.Enabled = false;
            this.mskaliirpf.Location = new System.Drawing.Point(166, 78);
            this.mskaliirpf.Name = "mskaliirpf";
            this.mskaliirpf.Size = new System.Drawing.Size(131, 22);
            this.mskaliirpf.TabIndex = 23;
            // 
            // mskaliinss
            // 
            this.mskaliinss.Enabled = false;
            this.mskaliinss.Location = new System.Drawing.Point(166, 36);
            this.mskaliinss.Name = "mskaliinss";
            this.mskaliinss.Size = new System.Drawing.Size(131, 22);
            this.mskaliinss.TabIndex = 22;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(359, 496);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(74, 43);
            this.btnfechar.TabIndex = 19;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // cbxfilhos
            // 
            this.cbxfilhos.FormattingEnabled = true;
            this.cbxfilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cbxfilhos.Location = new System.Drawing.Point(208, 104);
            this.cbxfilhos.Name = "cbxfilhos";
            this.cbxfilhos.Size = new System.Drawing.Size(131, 24);
            this.cbxfilhos.TabIndex = 24;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(269, 497);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 42);
            this.btnlimpar.TabIndex = 25;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(775, 557);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.cbxfilhos);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.cbxcasado);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.gbxsexo);
            this.Controls.Add(this.btnval);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.msbxsal);
            this.Controls.Add(this.lblinfor);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOLERITE";
            this.gbxsexo.ResumeLayout(false);
            this.gbxsexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblinfor;
        private System.Windows.Forms.Label lblAliinss;
        private System.Windows.Forms.Label lblAliirpf;
        private System.Windows.Forms.Label lblSalfam;
        private System.Windows.Forms.Label lblSalliq;
        private System.Windows.Forms.Label lblDesinss;
        private System.Windows.Forms.Label lblDesirpf;
        private System.Windows.Forms.MaskedTextBox msbxsal;
        private System.Windows.Forms.Button btnval;
        private System.Windows.Forms.GroupBox gbxsexo;
        private System.Windows.Forms.RadioButton rbtnm;
        private System.Windows.Forms.RadioButton rbtnf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.CheckBox cbxcasado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.ComboBox cbxfilhos;
        private System.Windows.Forms.MaskedTextBox mskdescirpf;
        private System.Windows.Forms.MaskedTextBox mskdescinss;
        private System.Windows.Forms.MaskedTextBox msksalliq;
        private System.Windows.Forms.MaskedTextBox msksalfam;
        private System.Windows.Forms.MaskedTextBox mskaliirpf;
        private System.Windows.Forms.MaskedTextBox mskaliinss;
        private System.Windows.Forms.Button btnlimpar;
    }
}

