using mojLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PrikazIgraca.xaml
    /// </summary>
    public partial class PrikazIgraca : Window
    {
        public PrikazIgraca(Igrac igrac)
        {
            InitializeComponent();
            LoadIgrac(igrac);
        }

        private void LoadIgrac(Igrac igrac)
        {
            lblIme.Content = igrac.Name;
            lblBroj.Content = igrac.ShirtNumber;
            lblPozicija.Content = igrac.Position;
            imgPlayer.Source = new BitmapImage(new Uri(igrac.Slika));
            lblGolovi.Content = igrac.GoloviUTekmi;
            lblKartoni.Content = igrac.KartoniUTekmi;
            lblCaptain.Content = igrac.Captain;
        }
    }
}
