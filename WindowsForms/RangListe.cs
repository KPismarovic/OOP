using mojLib;
using mojLib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.UserControls;

namespace WindowsForms
{
    public partial class RangListe : Form
    {
        private const string PATH = @"\Reprezentacija.txt";
        List<Tekma> kolekcijaUtakmica = Repo.GetUtakmice(Repo.LoadFromFile(PATH));

        public RangListe(List<Igrac> kolekcijaIgraca)
        {
            InitializeComponent();
           
            PrikaziBrojGolova(kolekcijaIgraca);
            PrikaziBrojKartona(kolekcijaIgraca);
            PrikaziBrojPosjetitelja();
          
        }

        private void PrikaziBrojKartona(List<Igrac> kolekcijaIgraca)
        {
            kolekcijaIgraca.Sort((x, y) => -x.BrojKartona.CompareTo(y.BrojKartona));

            foreach (Igrac igrac in kolekcijaIgraca)
            {
                RangControl kontrola = new RangControl(igrac, "kartoni");
                flpKartoni.Controls.Add(kontrola);
            }
        }

        private void PrikaziBrojGolova(List<Igrac> kolekcijaIgraca)
        {
            kolekcijaIgraca.Sort();

            foreach (Igrac igrac in kolekcijaIgraca)
            {
                RangControl kontrola = new RangControl(igrac, "golovi");
                flpGolovi.Controls.Add(kontrola);
            }
        }

        private void PrikaziBrojPosjetitelja()
        {
            kolekcijaUtakmica.Sort();

            foreach (var tekma in kolekcijaUtakmica)
            {
                lbBrojGledatelja.Items.Add(tekma);
            }
        }

        private void postavkeStraniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void odabirPrinteraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        Bitmap bmp, bmp2, bmp3;
        private void pregledPrijeIspisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bmp = new Bitmap(flpGolovi.Width, flpGolovi.Height);
            flpGolovi.DrawToBitmap(bmp, new Rectangle(0, 0, flpGolovi.Width, flpGolovi.Height));

            bmp2 = new Bitmap(flpGolovi.Width + flpKartoni.Width, flpKartoni.Height);
            flpKartoni.DrawToBitmap(bmp2, new Rectangle(0, 0,flpKartoni.Width, flpKartoni.Height));

            bmp3 = new Bitmap(lbBrojGledatelja.Width, lbBrojGledatelja.Height);
            lbBrojGledatelja.DrawToBitmap(bmp3, new Rectangle(0, 0, lbBrojGledatelja.Width, lbBrojGledatelja.Height));

            printPreviewDialog1.ShowDialog();
        }

        private void ispisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top);
            e.Graphics.DrawImage(bmp2 ,2* e.MarginBounds.Left + flpGolovi.Width, e.MarginBounds.Top);
            e.Graphics.DrawImage(bmp3, e.MarginBounds.Left , 2*e.MarginBounds.Top + flpGolovi.Height);
        }
        
    }
}
