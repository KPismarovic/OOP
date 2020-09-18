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

namespace WindowsForms.UserControls
{
    public partial class RangControl : UserControl
    {
        public RangControl(Igrac igrac,string kriterij)
        {
            InitializeComponent();
            SetLabels(igrac, kriterij);
        }

        private void SetLabels(Igrac igrac, string kriterij)
        {
            BackColor = Color.White;
            pbSlika.ImageLocation = igrac.Slika;
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;

            lblIme.Text = igrac.Name;
            lblPojavljivanja.Text ="Nastupi: " +  igrac.BrojPojavljivanja.ToString();
            if (kriterij == "golovi")
            {
            lblKriterij.Text = "Golovi: " + igrac.BrojGolova.ToString();
            }
            else
            {
                lblKriterij.Text = "Kartoni: " + igrac.BrojKartona.ToString();
            }
            
        }

    }
}
