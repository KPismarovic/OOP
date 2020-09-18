namespace WindowsForms.UserControls
{
    partial class RangControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPojavljivanja = new System.Windows.Forms.Label();
            this.lblKriterij = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(4, 4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(78, 73);
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(88, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(46, 17);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "label1";
            // 
            // lblPojavljivanja
            // 
            this.lblPojavljivanja.AutoSize = true;
            this.lblPojavljivanja.Location = new System.Drawing.Point(88, 52);
            this.lblPojavljivanja.Name = "lblPojavljivanja";
            this.lblPojavljivanja.Size = new System.Drawing.Size(46, 17);
            this.lblPojavljivanja.TabIndex = 2;
            this.lblPojavljivanja.Text = "label2";
            // 
            // lblKriterij
            // 
            this.lblKriterij.AutoSize = true;
            this.lblKriterij.Location = new System.Drawing.Point(195, 52);
            this.lblKriterij.Name = "lblKriterij";
            this.lblKriterij.Size = new System.Drawing.Size(46, 17);
            this.lblKriterij.TabIndex = 3;
            this.lblKriterij.Text = "label3";
            // 
            // RangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKriterij);
            this.Controls.Add(this.lblPojavljivanja);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.pbSlika);
            this.Name = "RangControl";
            this.Size = new System.Drawing.Size(278, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPojavljivanja;
        private System.Windows.Forms.Label lblKriterij;
    }
}
