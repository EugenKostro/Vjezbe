namespace kostroEugenDateTimePicker
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
            this.lblDatumLeta = new System.Windows.Forms.Label();
            this.lblVrijemePolaska = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVrijeme = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatumLeta
            // 
            this.lblDatumLeta.AutoSize = true;
            this.lblDatumLeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumLeta.Location = new System.Drawing.Point(29, 29);
            this.lblDatumLeta.Name = "lblDatumLeta";
            this.lblDatumLeta.Size = new System.Drawing.Size(157, 24);
            this.lblDatumLeta.TabIndex = 0;
            this.lblDatumLeta.Text = "Upišite datum leta";
            // 
            // lblVrijemePolaska
            // 
            this.lblVrijemePolaska.AutoSize = true;
            this.lblVrijemePolaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijemePolaska.Location = new System.Drawing.Point(32, 76);
            this.lblVrijemePolaska.Name = "lblVrijemePolaska";
            this.lblVrijemePolaska.Size = new System.Drawing.Size(201, 24);
            this.lblVrijemePolaska.TabIndex = 1;
            this.lblVrijemePolaska.Text = "Upišite vrijeme polaska";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(276, 32);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(222, 20);
            this.dateTimePickerDatum.TabIndex = 2;
            // 
            // dateTimePickerVrijeme
            // 
            this.dateTimePickerVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerVrijeme.Location = new System.Drawing.Point(276, 79);
            this.dateTimePickerVrijeme.Name = "dateTimePickerVrijeme";
            this.dateTimePickerVrijeme.ShowUpDown = true;
            this.dateTimePickerVrijeme.Size = new System.Drawing.Size(222, 20);
            this.dateTimePickerVrijeme.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 254);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(534, 362);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(106, 40);
            this.btnRezerviraj.TabIndex = 5;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.BtnRezerviraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePickerVrijeme);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.lblVrijemePolaska);
            this.Controls.Add(this.lblDatumLeta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumLeta;
        private System.Windows.Forms.Label lblVrijemePolaska;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerVrijeme;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRezerviraj;
    }
}

