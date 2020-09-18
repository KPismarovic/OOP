namespace WindowsForms
{
    partial class OdabirIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdabirIgraca));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpOmiljeniIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.flpIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrikaziListe = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // flpOmiljeniIgraci
            // 
            resources.ApplyResources(this.flpOmiljeniIgraci, "flpOmiljeniIgraci");
            this.flpOmiljeniIgraci.AllowDrop = true;
            this.flpOmiljeniIgraci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpOmiljeniIgraci.Name = "flpOmiljeniIgraci";
            this.flpOmiljeniIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpOmiljeniIgraci_DragDrop);
            this.flpOmiljeniIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpOmiljeniIgraci_DragEnter);
            // 
            // flpIgraci
            // 
            resources.ApplyResources(this.flpIgraci, "flpIgraci");
            this.flpIgraci.AllowDrop = true;
            this.flpIgraci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpIgraci.Name = "flpIgraci";
            this.flpIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpIgraci_DragDrop);
            this.flpIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpOmiljeniIgraci_DragEnter);
            // 
            // btnPrikaziListe
            // 
            resources.ApplyResources(this.btnPrikaziListe, "btnPrikaziListe");
            this.btnPrikaziListe.Name = "btnPrikaziListe";
            this.btnPrikaziListe.UseVisualStyleBackColor = true;
            this.btnPrikaziListe.Click += new System.EventHandler(this.btnPrikaziListe_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // postavkeToolStripMenuItem
            // 
            resources.ApplyResources(this.postavkeToolStripMenuItem, "postavkeToolStripMenuItem");
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click);
            // 
            // OdabirIgraca
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrikaziListe);
            this.Controls.Add(this.flpIgraci);
            this.Controls.Add(this.flpOmiljeniIgraci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OdabirIgraca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpOmiljeniIgraci;
        private System.Windows.Forms.FlowLayoutPanel flpIgraci;
        private System.Windows.Forms.Button btnPrikaziListe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
    }
}