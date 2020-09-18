namespace WindowsForms
{
    partial class MojaKontrola
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
            this.PlayerName = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.Number = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.Captain = new System.Windows.Forms.Label();
            this.pbOmiljen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOmiljen)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(114, 3);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(46, 17);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "label1";
            this.PlayerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MojaKontrola_MouseDown);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(3, 3);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(105, 98);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(114, 29);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(46, 17);
            this.Number.TabIndex = 2;
            this.Number.Text = "label1";
            this.Number.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MojaKontrola_MouseDown);
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(114, 55);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(46, 17);
            this.Position.TabIndex = 3;
            this.Position.Text = "label1";
            this.Position.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MojaKontrola_MouseDown);
            // 
            // Captain
            // 
            this.Captain.AutoSize = true;
            this.Captain.Location = new System.Drawing.Point(114, 83);
            this.Captain.Name = "Captain";
            this.Captain.Size = new System.Drawing.Size(46, 17);
            this.Captain.TabIndex = 4;
            this.Captain.Text = "label1";
            this.Captain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MojaKontrola_MouseDown);
            // 
            // pbOmiljen
            // 
            this.pbOmiljen.Location = new System.Drawing.Point(235, 67);
            this.pbOmiljen.Name = "pbOmiljen";
            this.pbOmiljen.Size = new System.Drawing.Size(38, 36);
            this.pbOmiljen.TabIndex = 5;
            this.pbOmiljen.TabStop = false;
            // 
            // MojaKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbOmiljen);
            this.Controls.Add(this.Captain);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.PlayerName);
            this.Name = "MojaKontrola";
            this.Size = new System.Drawing.Size(276, 106);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MojaKontrola_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOmiljen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label Captain;
        private System.Windows.Forms.PictureBox pbOmiljen;
    }
}
