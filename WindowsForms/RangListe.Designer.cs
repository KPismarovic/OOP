namespace WindowsForms
{
    partial class RangListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangListe));
            this.lbBrojGledatelja = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flpGolovi = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKartoni = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ispisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeStraniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odabirPrinteraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPrijeIspisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBrojGledatelja
            // 
            resources.ApplyResources(this.lbBrojGledatelja, "lbBrojGledatelja");
            this.lbBrojGledatelja.FormattingEnabled = true;
            this.lbBrojGledatelja.Name = "lbBrojGledatelja";
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // flpGolovi
            // 
            resources.ApplyResources(this.flpGolovi, "flpGolovi");
            this.flpGolovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGolovi.Name = "flpGolovi";
            // 
            // flpKartoni
            // 
            resources.ApplyResources(this.flpKartoni, "flpKartoni");
            this.flpKartoni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpKartoni.Name = "flpKartoni";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ispisToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ispisToolStripMenuItem
            // 
            resources.ApplyResources(this.ispisToolStripMenuItem, "ispisToolStripMenuItem");
            this.ispisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeStraniceToolStripMenuItem,
            this.odabirPrinteraToolStripMenuItem1,
            this.pregledPrijeIspisaToolStripMenuItem,
            this.ispisToolStripMenuItem2});
            this.ispisToolStripMenuItem.Name = "ispisToolStripMenuItem";
            // 
            // postavkeStraniceToolStripMenuItem
            // 
            resources.ApplyResources(this.postavkeStraniceToolStripMenuItem, "postavkeStraniceToolStripMenuItem");
            this.postavkeStraniceToolStripMenuItem.Name = "postavkeStraniceToolStripMenuItem";
            this.postavkeStraniceToolStripMenuItem.Click += new System.EventHandler(this.postavkeStraniceToolStripMenuItem_Click);
            // 
            // odabirPrinteraToolStripMenuItem1
            // 
            resources.ApplyResources(this.odabirPrinteraToolStripMenuItem1, "odabirPrinteraToolStripMenuItem1");
            this.odabirPrinteraToolStripMenuItem1.Name = "odabirPrinteraToolStripMenuItem1";
            this.odabirPrinteraToolStripMenuItem1.Click += new System.EventHandler(this.odabirPrinteraToolStripMenuItem1_Click);
            // 
            // pregledPrijeIspisaToolStripMenuItem
            // 
            resources.ApplyResources(this.pregledPrijeIspisaToolStripMenuItem, "pregledPrijeIspisaToolStripMenuItem");
            this.pregledPrijeIspisaToolStripMenuItem.Name = "pregledPrijeIspisaToolStripMenuItem";
            this.pregledPrijeIspisaToolStripMenuItem.Click += new System.EventHandler(this.pregledPrijeIspisaToolStripMenuItem_Click);
            // 
            // ispisToolStripMenuItem2
            // 
            resources.ApplyResources(this.ispisToolStripMenuItem2, "ispisToolStripMenuItem2");
            this.ispisToolStripMenuItem2.Name = "ispisToolStripMenuItem2";
            this.ispisToolStripMenuItem2.Click += new System.EventHandler(this.ispisToolStripMenuItem2_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // RangListe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpKartoni);
            this.Controls.Add(this.flpGolovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBrojGledatelja);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RangListe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbBrojGledatelja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpGolovi;
        private System.Windows.Forms.FlowLayoutPanel flpKartoni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postavkeStraniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odabirPrinteraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledPrijeIspisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}