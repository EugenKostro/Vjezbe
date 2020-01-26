namespace kostroEugenRadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnAvion = new System.Windows.Forms.RadioButton();
            this.rBtnAutobus = new System.Windows.Forms.RadioButton();
            this.rBtnVlastiti = new System.Windows.Forms.RadioButton();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnVlastiti);
            this.groupBox1.Controls.Add(this.rBtnAutobus);
            this.groupBox1.Controls.Add(this.rBtnAvion);
            this.groupBox1.Location = new System.Drawing.Point(114, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza";
            // 
            // rBtnAvion
            // 
            this.rBtnAvion.AutoSize = true;
            this.rBtnAvion.Location = new System.Drawing.Point(24, 47);
            this.rBtnAvion.Name = "rBtnAvion";
            this.rBtnAvion.Size = new System.Drawing.Size(64, 21);
            this.rBtnAvion.TabIndex = 0;
            this.rBtnAvion.TabStop = true;
            this.rBtnAvion.Text = "Avion";
            this.rBtnAvion.UseVisualStyleBackColor = true;
            // 
            // rBtnAutobus
            // 
            this.rBtnAutobus.AutoSize = true;
            this.rBtnAutobus.Location = new System.Drawing.Point(24, 109);
            this.rBtnAutobus.Name = "rBtnAutobus";
            this.rBtnAutobus.Size = new System.Drawing.Size(81, 21);
            this.rBtnAutobus.TabIndex = 1;
            this.rBtnAutobus.TabStop = true;
            this.rBtnAutobus.Text = "Autobus";
            this.rBtnAutobus.UseVisualStyleBackColor = true;
            // 
            // rBtnVlastiti
            // 
            this.rBtnVlastiti.AutoSize = true;
            this.rBtnVlastiti.Location = new System.Drawing.Point(24, 168);
            this.rBtnVlastiti.Name = "rBtnVlastiti";
            this.rBtnVlastiti.Size = new System.Drawing.Size(123, 21);
            this.rBtnVlastiti.TabIndex = 2;
            this.rBtnVlastiti.TabStop = true;
            this.rBtnVlastiti.Text = "Vlastiti prijevoz";
            this.rBtnVlastiti.UseVisualStyleBackColor = true;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(114, 288);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(200, 58);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 389);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 85);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 486);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnVlastiti;
        private System.Windows.Forms.RadioButton rBtnAutobus;
        private System.Windows.Forms.RadioButton rBtnAvion;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox textBox1;
    }
}

