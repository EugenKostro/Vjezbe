namespace kostroEugenComboBox06
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
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.chckboxDorucak = new System.Windows.Forms.CheckBox();
            this.chckboxRucak = new System.Windows.Forms.CheckBox();
            this.chckboxVecera = new System.Windows.Forms.CheckBox();
            this.chckboxSakrij = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(406, 62);
            this.txtbox1.Multiline = true;
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(338, 232);
            this.txtbox1.TabIndex = 0;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(85, 353);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(158, 55);
            this.btnPosalji.TabIndex = 1;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // chckboxDorucak
            // 
            this.chckboxDorucak.AutoSize = true;
            this.chckboxDorucak.Location = new System.Drawing.Point(85, 62);
            this.chckboxDorucak.Name = "chckboxDorucak";
            this.chckboxDorucak.Size = new System.Drawing.Size(83, 21);
            this.chckboxDorucak.TabIndex = 2;
            this.chckboxDorucak.Text = "Doručak";
            this.chckboxDorucak.UseVisualStyleBackColor = true;
            // 
            // chckboxRucak
            // 
            this.chckboxRucak.AutoSize = true;
            this.chckboxRucak.Location = new System.Drawing.Point(85, 165);
            this.chckboxRucak.Name = "chckboxRucak";
            this.chckboxRucak.Size = new System.Drawing.Size(70, 21);
            this.chckboxRucak.TabIndex = 3;
            this.chckboxRucak.Text = "Ručak";
            this.chckboxRucak.UseVisualStyleBackColor = true;
            this.chckboxRucak.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chckboxVecera
            // 
            this.chckboxVecera.AutoSize = true;
            this.chckboxVecera.Location = new System.Drawing.Point(85, 273);
            this.chckboxVecera.Name = "chckboxVecera";
            this.chckboxVecera.Size = new System.Drawing.Size(75, 21);
            this.chckboxVecera.TabIndex = 4;
            this.chckboxVecera.Text = "Večera";
            this.chckboxVecera.UseVisualStyleBackColor = true;
            // 
            // chckboxSakrij
            // 
            this.chckboxSakrij.AutoSize = true;
            this.chckboxSakrij.Location = new System.Drawing.Point(406, 387);
            this.chckboxSakrij.Name = "chckboxSakrij";
            this.chckboxSakrij.Size = new System.Drawing.Size(129, 21);
            this.chckboxSakrij.TabIndex = 5;
            this.chckboxSakrij.Text = "Sakrij narudžbu";
            this.chckboxSakrij.UseVisualStyleBackColor = true;
            this.chckboxSakrij.CheckedChanged += new System.EventHandler(this.chckboxSakrij_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chckboxSakrij);
            this.Controls.Add(this.chckboxVecera);
            this.Controls.Add(this.chckboxRucak);
            this.Controls.Add(this.chckboxDorucak);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox chckboxDorucak;
        private System.Windows.Forms.CheckBox chckboxRucak;
        private System.Windows.Forms.CheckBox chckboxVecera;
        private System.Windows.Forms.CheckBox chckboxSakrij;
    }
}

