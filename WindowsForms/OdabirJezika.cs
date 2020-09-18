using mojLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsForms
{
    public partial class OdabirJezika : Form
    {
        private const string PATHReprezentacija = @"\Reprezentacija.txt";
        private const string PATHJezik = @"\Jezik.txt";

        public OdabirJezika()
        {
            InitializeComponent();
        }

        private void btnCRO_Click(object sender, EventArgs e)
        {
            if (Repo.CheckIfFileExists(PATHJezik))
            {
                Repo.SpremiFile("", PATHJezik);
                Repo.SetLanguage("");
                this.Close();
            }
            else
            {
            Repo.SpremiFile("", PATHJezik);
            Repo.SetLanguage("");
            GoToNextForm();
            }
        }
        
        private void btnENG_Click(object sender, EventArgs e)
        {
            if (Repo.CheckIfFileExists(PATHJezik))
            {
                Repo.SpremiFile("en", PATHJezik);
                Repo.SetLanguage("en");
                this.Close();
            }
            else
            {
                Repo.SpremiFile("en", PATHJezik);
                Repo.SetLanguage("en");
                GoToNextForm();
            }
        }

        private void GoToNextForm()
        {
            if (Repo.CheckIfFileExists(PATHReprezentacija))
            {
                OdabirIgraca formaIgraci = new OdabirIgraca(Repo.LoadFromFile(PATHReprezentacija));
                this.Hide();
                formaIgraci.ShowDialog();
            }
            else
            {
                OdabirReprezentacije formR = new OdabirReprezentacije();
                this.Hide();
                formR.ShowDialog();
            }
            this.Close();
        }
        
    }
}
