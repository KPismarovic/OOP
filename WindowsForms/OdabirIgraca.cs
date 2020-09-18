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

namespace WindowsForms
{
    public partial class OdabirIgraca : Form
    {
        private const string PATHIgraci = @"\Igraci.txt";
        List<Igrac> kolekcijaIgraca;
        
        public OdabirIgraca(string FifaCode)
        {
            InitializeComponent();
            if (Repo.CheckIfFileExists(PATHIgraci))
            {
                LoadIgraci();
            }
            else
                LoadDefaultIgraci(FifaCode);
        }

        private void LoadIgraci()
        {
            kolekcijaIgraca = Repo.LoadFileIgraci();
            foreach (var igrac in kolekcijaIgraca)
            {
                MojaKontrola kontrola = new MojaKontrola(igrac);
                if (igrac.OmiljeniIgrac == true)
                {
                    flpOmiljeniIgraci.Controls.Add(kontrola);
                }
                else
                {
                    flpIgraci.Controls.Add(kontrola);
                }
            }
        }

        private void LoadDefaultIgraci(string FifaCode)
        {
            kolekcijaIgraca = Repo.GetIgraci(FifaCode);

            foreach (Igrac igrac in kolekcijaIgraca)
            {
                MojaKontrola kontrola = new MojaKontrola(igrac);
                
                flpIgraci.Controls.Add(kontrola);
            }
        }
        
        private void flpOmiljeniIgraci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpOmiljeniIgraci_DragDrop(object sender, DragEventArgs e)
        {
            if (flpOmiljeniIgraci.Controls.Count < 3)
            {
                MojaKontrola kontrola = (MojaKontrola)e.Data.GetData(typeof(MojaKontrola));
                kontrola.SetOmiljeniIgrac("true");
                flpOmiljeniIgraci.Controls.Add(kontrola);
                
            }
            else
                MessageBox.Show("Mogu biti samo 3 omiljena igraca");
        }

        private void flpIgraci_DragDrop(object sender, DragEventArgs e)
        {
            MojaKontrola kontrola = (MojaKontrola)e.Data.GetData(typeof(MojaKontrola));
            kontrola.SetOmiljeniIgrac("false");
            flpIgraci.Controls.Add(kontrola);
        }

        private void btnPrikaziListe_Click(object sender, EventArgs e)
        {
            SaveIgraci();
            RangListe rang = new RangListe(kolekcijaIgraca);
            this.Hide();
            rang.ShowDialog();
            this.Close();
        }

        private void SaveIgraci()
        {
            kolekcijaIgraca.Clear();
            foreach (MojaKontrola kontrola in flpIgraci.Controls)
            {
                kolekcijaIgraca.Add(kontrola.GetIgrac());
            }
            foreach (MojaKontrola kontrola in flpOmiljeniIgraci.Controls)
            {
                kolekcijaIgraca.Add(kontrola.GetIgrac());
            }
            Repo.SaveFileIgraci(kolekcijaIgraca);
        }

        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdabirJezika odabir = new OdabirJezika();
            this.Hide();
            odabir.ShowDialog();
            SaveIgraci();
            Application.Restart();
        }
    }
}
