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
    public partial class OdabirReprezentacije : Form
    {
        private const string PATH = @"\Reprezentacija.txt";

        public OdabirReprezentacije()
        {
            InitializeComponent();
            LoadReprezentacije();
        }

        private void LoadReprezentacije()
        {
            
            List<Reprezentacija> kolekcijaReprezentacija = Repo.GetReprezentacije();
            foreach (var reprezentacija in kolekcijaReprezentacija)
            {
                cbOdabirReprezentacije.Items.Add(reprezentacija);
            }
            cbOdabirReprezentacije.Show();
        }

        private void cbOdabirReprezentacije_SelectedValueChanged(object sender, EventArgs e)
        {
            {
                Reprezentacija reprezentacija = cbOdabirReprezentacije.SelectedItem as Reprezentacija;

                Repo.SpremiFile(reprezentacija.FifaCode, PATH);
                Repo.DeleteIgraci();
                OdabirIgraca od = new OdabirIgraca(reprezentacija.FifaCode);
                this.Hide();
                od.ShowDialog();
                this.Close();
            }
        }
    }
}
