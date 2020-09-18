using mojLib;
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
    /// Interaction logic for PregledReprezentacije.xaml
    /// </summary>
    public partial class PregledReprezentacije : Window
    {
        public PregledReprezentacije(string FifaCode,List<Reprezentacija> kolekcijaReprezentacija)
        {
            InitializeComponent();
            LoadReprezentacija(FifaCode, kolekcijaReprezentacija);
        }

        private void LoadReprezentacija(string FifaCode, List<Reprezentacija> kolekcijaReprezentacija)
        {
            Reprezentacija r = Repo.DohvaiReprezentaciju(FifaCode, kolekcijaReprezentacija);
            lblNaziv.Content = r.Country;
            lblFifaCode.Content = r.FifaCode;
            lblUtakmice.Content = r.GamesPlayed;
            lblWLD.Content = r.Wins + " / " + r.Draws +  " / " + r.Losses;
            lblGolovi.Content = r.GoalsFor + " / " + r.GoalsAgainst + " / " + r.GoalDifferential;
        }
    }
}
