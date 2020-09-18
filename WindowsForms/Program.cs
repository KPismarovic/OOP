using mojLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    static class Program
    {
        private const string PATHReprezentacija = @"\Reprezentacija.txt";
        private const string PATHJezik = @"\Jezik.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (Repo.CheckIfFileExists(PATHJezik))
            {
                Repo.SetLanguage(Repo.LoadFromFile(PATHJezik));
                if (Repo.CheckIfFileExists(PATHReprezentacija))
                {
                    Application.Run(new OdabirIgraca(Repo.LoadFromFile(PATHReprezentacija)));
                }
                else
                    Application.Run(new OdabirReprezentacije());
            }
            else
            Application.Run(new OdabirJezika());
        }
    }
}
