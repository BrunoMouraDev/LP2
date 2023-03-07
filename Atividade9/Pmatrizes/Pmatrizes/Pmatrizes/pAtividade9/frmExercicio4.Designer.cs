namespace pAtividade9
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
            this.btnNomes = new System.Windows.Forms.Button();
            this.txtPlanilha = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNomes
            // 
            this.btnNomes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomes.Location = new System.Drawing.Point(76, 198);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(201, 58);
            this.btnNomes.TabIndex = 3;
            this.btnNomes.Text = "Imprimir Nomes";
            this.btnNomes.UseVisualStyleBackColor = true;
            this.btnNomes.Click += new System.EventHandler(this.btnNomes_Click);
            // 
            // txtPlanilha
            // 
            this.txtPlanilha.Location = new System.Drawing.Point(313, 56);
            this.txtPlanilha.Name = "txtPlanilha";
            this.txtPlanilha.Size = new System.Drawing.Size(538, 440);
            this.txtPlanilha.TabIndex = 4;
            this.txtPlanilha.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.txtPlanilha);
            this.Controls.Add(this.btnNomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio4";
            this.Text = "ArrayList Nomes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.RichTextBox txtPlanilha;
    }
}