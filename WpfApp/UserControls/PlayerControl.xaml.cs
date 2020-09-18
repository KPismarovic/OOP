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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerControl.xaml
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        Igrac igrac = new Igrac();
        public PlayerControl(Igrac noviIgrac)
        {
            InitializeComponent();
            igrac = noviIgrac;
            SetLabels(igrac);
        }

        private void SetLabels(Igrac igrac)
        {
            tbInfo.Text = igrac.ShirtNumber + " " + igrac.Name;
            imgPlayer.Source = new BitmapImage(new Uri(igrac.Slika));
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PrikazIgraca prikaz = new PrikazIgraca(igrac);
            prikaz.ShowDialog();
        }
    }
}
