using mojLib;
using mojLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp.UserControls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for OdabirReprezentacija.xaml
    /// </summary>
    public partial class OdabirReprezentacija : Window
    {
        private const string PATH = @"\Reprezentacija.txt";
        private string FIFACODE = Repo.LoadFromFile(PATH);
        private List<Reprezentacija> kolekcijaReprezentacija = Repo.GetReprezentacije();

        public OdabirReprezentacija()
        {
            InitializeComponent();
            string line = Repo.GetVelicina();
            if (line == "Normal")
            {
                WindowState = WindowState.Normal;
            }
            else
                WindowState = WindowState.Maximized;
        }

        private void CbReprezentacije_Loaded(object sender, RoutedEventArgs e)
        {
            int index = 0;
            foreach (var item in kolekcijaReprezentacija)
            {
                cbReprezentacije.Items.Add(item);
                if (item.FifaCode == FIFACODE)
                {
                    cbReprezentacije.SelectedIndex = index;
                }
                index++;
            }
        }
       
        private void LoadField()
        {
            List<Tekma> listaUtakmica = Repo.GetUtakmice(FIFACODE);
            Reprezentacija protiv = cbProtiv.SelectedItem as Reprezentacija;
            
            foreach (var utakmica in listaUtakmica)
            {
                if (utakmica.HomeTeam.Code == protiv.FifaCode )
                {
                    LoadHomeTeam(utakmica.AwayTeamStatistics.StartingEleven,utakmica.AwayTeamEvents);
                    LoadAwayTeam(utakmica.HomeTeamStatistics.StartingEleven, utakmica.HomeTeamEvents);
                    lblHomeGoals.Content = utakmica.AwayTeam.Goals;
                    lblAwayGoals.Content = utakmica.HomeTeam.Goals;
                    return;
                }
                else if (utakmica.AwayTeam.Code == protiv.FifaCode)
                {
                    LoadHomeTeam(utakmica.HomeTeamStatistics.StartingEleven,utakmica.HomeTeamEvents);
                    LoadAwayTeam(utakmica.AwayTeamStatistics.StartingEleven, utakmica.AwayTeamEvents);
                    lblHomeGoals.Content = utakmica.HomeTeam.Goals;
                    lblAwayGoals.Content = utakmica.AwayTeam.Goals;
                    return;
                }
            }
        }

        private void LoadHomeTeam(List<Igrac> igraci,List<TeamEvents> events)
        {
            if (Repo.CheckIfFileExists(@"\Igraci.txt"))
            {
                List<Igrac> spremljeniIgraci = Repo.LoadFileIgraci();
                spremljeniIgraci = Repo.StatistikeUtakmice(events,spremljeniIgraci);
                 
                foreach (var spremljenIgrac in spremljeniIgraci)
                {
                    foreach (var igrac in igraci)
                    {
                        if (igrac.Name == spremljenIgrac.Name)
                        {
                            spremljenIgrac.Captain = igrac.Captain;
                                PlayerControl control = new PlayerControl(spremljenIgrac);
                                if (spremljenIgrac.Position == "Goalie")
                                {
                                    spHomeG.Children.Add(control);
                                }
                                else if (spremljenIgrac.Position == "Defender")
                                {
                                    spHomeD.Children.Add(control);
                                }
                                else if (spremljenIgrac.Position == "Midfield")
                                {
                                    spHomeM.Children.Add(control);
                                }
                                else
                                {
                                    spHomeF.Children.Add(control);
                                }
                        }
                    }
                }
            }
            else{
                igraci = Repo.StatistikeUtakmice(events, igraci);
                foreach (Igrac igrac in igraci)
                {
                    PlayerControl control = new PlayerControl(igrac);
                    if (igrac.Position == "Goalie")
                    {
                        spHomeG.Children.Add(control);
                    }
                    else if (igrac.Position == "Defender")
                    {
                        spHomeD.Children.Add(control);
                    }
                    else if (igrac.Position == "Midfield")
                    {
                        spHomeM.Children.Add(control);
                    }
                    else
                    {
                        spHomeF.Children.Add(control);
                    }
                }
            }
        }

        private void LoadAwayTeam(List<Igrac> igraci, List<TeamEvents> events)
        {
            igraci = Repo.StatistikeUtakmice(events, igraci);
            foreach (Igrac igrac in igraci)
            {
                PlayerControl control = new PlayerControl(igrac);
                if (igrac.Position == "Goalie")
                {
                    spAwayG.Children.Add(control);
                }
                else if (igrac.Position == "Defender")
                {
                    spAwayD.Children.Add(control);
                }
                else if (igrac.Position == "Midfield")
                {
                    spAwayM.Children.Add(control);
                }
                else
                {
                    spAwayF.Children.Add(control);
                }
            }
        }

        private void CbProtiv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (spHomeG.Children.Count != 0)
            {
                spHomeG.Children.Clear();
                spHomeD.Children.Clear();
                spHomeM.Children.Clear();
                spHomeF.Children.Clear();
            spAwayG.Children.Clear();
            spAwayD.Children.Clear();
            spAwayM.Children.Clear();
            spAwayF.Children.Clear();
            }
            if (!(cbProtiv.SelectedIndex == -1))
            {
                Reprezentacija reprezentacija = cbProtiv.SelectedItem as Reprezentacija;
                PregledReprezentacije pregled = new PregledReprezentacije(reprezentacija.FifaCode, kolekcijaReprezentacija);
                pregled.ShowDialog();
                LoadField();
            }
        }

        private void CbReprezentacije_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblHomeGoals.Content = 0;
            lblAwayGoals.Content = 0;
            Reprezentacija reprezentacija = cbReprezentacije.SelectedItem as Reprezentacija;
            if (reprezentacija.FifaCode != FIFACODE)
            {
            Repo.DeleteIgraci();
            }
            PregledReprezentacije pregled = new PregledReprezentacije(reprezentacija.FifaCode, kolekcijaReprezentacija);
            pregled.ShowDialog();
            Repo.SpremiFile(reprezentacija.FifaCode, PATH);
            cbProtiv.Items.Clear();
            LoadcbProtiv();
        }

        private void LoadcbProtiv()
        {
            FIFACODE = Repo.LoadFromFile(PATH);
            List<Tekma> listaUtakmica = Repo.GetUtakmice(FIFACODE);
            foreach (var item in listaUtakmica)
            {
                if (item.HomeTeam.Code == FIFACODE)
                {
                    cbProtiv.Items.Add(GetJednuRep(item.AwayTeam.Code));
                }
                else
                {
                    cbProtiv.Items.Add(GetJednuRep(item.HomeTeam.Code));
                }
            }
        }

       private Reprezentacija GetJednuRep(string FifaCode)
       {
            foreach (var item in kolekcijaReprezentacija)
            {
                if (FifaCode == item.FifaCode)
                {
                    return item;
                }
            }
            return null;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(Repo.DIR + @"\Jezik.txt");
            MainWindow window = new MainWindow();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }
    }
}
