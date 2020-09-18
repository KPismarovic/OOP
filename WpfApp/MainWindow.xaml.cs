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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string PATHJezik = @"\Jezik.txt";
        public MainWindow()
        {
            InitializeComponent();
            if (Repo.CheckIfFileExists(PATHJezik))
            {
                spJezik.Visibility = Visibility.Hidden;
                spVelicina.Visibility = Visibility.Visible;
            }
        }

        private void BtnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            Repo.SpremiVelicinuProzora("Max", PATHJezik);
            spVelicina.Visibility = Visibility.Hidden;
            btnDalje.Visibility = Visibility.Visible;
        }

        private void BtnOdabranaVelicina_Click(object sender, RoutedEventArgs e)
        {
            Repo.SpremiVelicinuProzora("Normal", PATHJezik);
            spVelicina.Visibility = Visibility.Hidden;
            btnDalje.Visibility = Visibility.Visible;
        }

        private void BtnHrvatski_Click(object sender, RoutedEventArgs e)
        {
            Repo.SpremiFile("", PATHJezik);
            Repo.SetLanguage("");
            spJezik.Visibility = Visibility.Hidden;
            spVelicina.Visibility = Visibility.Visible;
        }

        private void BtnEngleski_Click(object sender, RoutedEventArgs e)
        {
            Repo.SpremiFile("en", PATHJezik);
            Repo.SetLanguage("en");
            spJezik.Visibility = Visibility.Hidden;
            spVelicina.Visibility = Visibility.Visible;
        }

        private void BtnDalje_Click(object sender, RoutedEventArgs e)
        {
            OdabirReprezentacija pregled = new OdabirReprezentacija();
            this.Hide();
            pregled.ShowDialog();
            this.Close();
        }
    }
}
