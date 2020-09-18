namespace WindowsForms
{
    partial class OdabirReprezentacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdabirReprezentacije));
            this.cbOdabirReprezentacije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOdabirReprezentacije
            // 
            resources.ApplyResources(this.cbOdabirReprezentacije, "cbOdabirReprezentacije");
            this.cbOdabirReprezentacije.FormattingEnabled = true;
            this.cbOdabirReprezentacije.Name = "cbOdabirReprezentacije";
            this.cbOdabirReprezentacije.SelectedValueChanged += new System.EventHandler(this.cbOdabirReprezentacije_SelectedValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // OdabirReprezentacije
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOdabirReprezentacije);
            this.Name = "OdabirReprezentacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOdabirReprezentacije;
        private System.Windows.Forms.Label label1;
    }
}

