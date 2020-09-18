using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mojLib.Model;
using mojLib;
using System.IO;

namespace WindowsForms
{
    public partial class MojaKontrola : UserControl
    {
        private string SLIKA = Repo.DIR + @"\Slike\Omiljen.jpg";  
        Igrac i;
        
        public MojaKontrola(Igrac igrac)
        {
            InitializeComponent();
            SetLabels(igrac);
            i = igrac;
        }

        private void SetLabels(Igrac igrac)
        {
            BackColor = Color.White;
            PlayerName.Text = igrac.Name;
            Number.Text = igrac.ShirtNumber.ToString();
            Position.Text = igrac.Position;
            Captain.Text = igrac.Captain;
            pbSlika.ImageLocation = igrac.Slika;
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;

            pbOmiljen.ImageLocation = SLIKA;
            pbOmiljen.SizeMode = PictureBoxSizeMode.StretchImage;
            if (!igrac.OmiljeniIgrac == true)
            {
                pbOmiljen.Hide();
            }
        }

        private void MojaKontrola_MouseDown(object sender, MouseEventArgs e)
        {
            MojaKontrola mk;
            if (sender is Label)
            {
                mk = ((sender as Label).Parent) as MojaKontrola;
            }
            else
            mk = sender as MojaKontrola;
            
            mk.DoDragDrop(this,DragDropEffects.Move);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp|Ostale datoteke|*.*";
            PictureBox pb = sender as PictureBox;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                i.Slika = Repo.DIR + @"\Slike\" + ofd.SafeFileName;
                pbSlika.ImageLocation = i.Slika;
                if (Repo.CheckIfFileExists(@"\Slike\" + ofd.SafeFileName))
                {
                    File.Delete(i.Slika);
                }
                File.Copy(ofd.FileName,i.Slika);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void SetOmiljeniIgrac(string omiljen)
        {
            if (i.OmiljeniIgrac = bool.Parse(omiljen))
            {
                pbOmiljen.Show();
            }
            else
                pbOmiljen.Hide();
        }

        public Igrac GetIgrac()
        {
            return i;
        }
    }
}
