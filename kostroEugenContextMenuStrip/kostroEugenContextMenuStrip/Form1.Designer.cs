namespace kostroEugenContextMenuStrip
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
            this.components = new System.ComponentModel.Container();
            this.txtBoxLijevo = new System.Windows.Forms.TextBox();
            this.txtBoxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoCTRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxLijevo
            // 
            this.txtBoxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBoxLijevo.Location = new System.Drawing.Point(89, 83);
            this.txtBoxLijevo.Name = "txtBoxLijevo";
            this.txtBoxLijevo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLijevo.TabIndex = 0;
            // 
            // txtBoxDesno
            // 
            this.txtBoxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBoxDesno.Location = new System.Drawing.Point(434, 83);
            this.txtBoxDesno.Name = "txtBoxDesno";
            this.txtBoxDesno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDesno.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoCTRLToolStripMenuItem,
            this.desnoNaLijevoCtrlLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 70);
            // 
            // lijevoNaDesnoCTRLToolStripMenuItem
            // 
            this.lijevoNaDesnoCTRLToolStripMenuItem.Name = "lijevoNaDesnoCTRLToolStripMenuItem";
            this.lijevoNaDesnoCTRLToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.lijevoNaDesnoCTRLToolStripMenuItem.Text = "Lijevo na desno Ctrl+D";
            this.lijevoNaDesnoCTRLToolStripMenuItem.Click += new System.EventHandler(this.LijevoNaDesnoCTRLToolStripMenuItem_Click);
            // 
            // desnoNaLijevoCtrlLToolStripMenuItem
            // 
            this.desnoNaLijevoCtrlLToolStripMenuItem.Name = "desnoNaLijevoCtrlLToolStripMenuItem";
            this.desnoNaLijevoCtrlLToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.desnoNaLijevoCtrlLToolStripMenuItem.Text = "Desno na lijevo Ctrl+L";
            this.desnoNaLijevoCtrlLToolStripMenuItem.Click += new System.EventHandler(this.DesnoNaLijevoCtrlLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 182);
            this.Controls.Add(this.txtBoxDesno);
            this.Controls.Add(this.txtBoxLijevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLijevo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBoxDesno;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoCTRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoCtrlLToolStripMenuItem;
    }
}

