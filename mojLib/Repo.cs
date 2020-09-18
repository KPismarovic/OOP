using mojLib.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace mojLib
{
    public class Repo
    {

        public const string DIR = @"D:\Projekti\OOP\ProjektOOP";
        private const string PATHIgraci = DIR + @"\Igraci.txt";        

        public static List<Reprezentacija> GetReprezentacije()
        {
            var client = new RestClient("http://worldcup.sfg.io");

            var response = client.Execute<List<Reprezentacija>>(new RestRequest("/teams/results", Method.GET));

            return response.Data;
        }
        
        public static Reprezentacija GetReprezentacija(string FifaCode)
        {
            List<Reprezentacija> list = GetReprezentacije();

            foreach (var item in list)
            {
                if (FifaCode == item.FifaCode)
                {
                    return item;
                }
            }
            return null;
        }

        public static Reprezentacija DohvaiReprezentaciju(string FifaCode, List<Reprezentacija> reprezentacije)
        {
            foreach (var item in reprezentacije)
            {
                if (FifaCode == item.FifaCode)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<Igrac> GetIgraci(string FifaCode)
        {
            List<Tekma> listaUtakmica = GetUtakmice(FifaCode);

            List<Igrac> kolekcijaIgraca = listaUtakmica.First().GetTeamStatistics(FifaCode).GetListaIgraca(FifaCode);

            return kolekcijaIgraca;
        }
        

        public static List<Tekma> GetUtakmice(string FifaCode)
        {
            var client = new RestClient("http://worldcup.sfg.io");

            var response = client.Execute<List<Tekma>>
                (new RestRequest("/matches/country", Method.GET)
                .AddParameter("fifa_code", FifaCode));

            return response.Data;
        }

        public static void SpremiFile(string FifaCode,string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(DIR + path))
                {
                    writer.WriteLine(FifaCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        public static string LoadFromFile(string path)
        {
            string line = null;
                using (StreamReader r = new StreamReader(DIR + path))
                {
                        line = r.ReadLine();
                }
            return line;
        }

        public static bool CheckIfFileExists(string path)
        {
            if (File.Exists(DIR + path))
            {
                return true;
            }
            return false;
        }

        public static void SetLanguage(string jezik)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(jezik);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(jezik);
        }

        public static List<Igrac> LoadFileIgraci()
        {
            List<Igrac> igraci = new List<Igrac>();
            string[] lines = File.ReadAllLines(PATHIgraci);
            
            lines.ToList().ForEach(line => igraci.Add(Igrac.ParseFromFileLine(line)));
            return igraci;
        }

        public static void SaveFileIgraci(List<Igrac> igraci)
        {
            File.WriteAllLines(PATHIgraci, igraci.Select(i => i.FormatForFileLine()));
        }

        public static List<Igrac> StatistikeUtakmice(List<TeamEvents> events, List<Igrac> igraci)
        {
            foreach (var teamEvent in events)
            {
                foreach (var igrac in igraci)
                {
                    if (igrac.Name == teamEvent.Player)
                    {
                        if (teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty")
                        {
                            igrac.GoloviUTekmi++;
                        }
                        else if (teamEvent.TypeOfEvent == "yellow-card")
                        {
                            igrac.KartoniUTekmi++;
                        }                        
                    }
                }
            }
            return igraci;
        }

        public static void SpremiVelicinuProzora(string size, string path)
        {
            string jezik = "";
            using (var sr = new StreamReader(DIR + @"\Jezik.txt"))
            {
                jezik = sr.ReadLine();
            }
               SpremiFile(jezik,@"\Jezik.txt");
               File.AppendAllText(DIR +path, size);
        }

        public static string GetVelicina()
        {
            using (var sr = new StreamReader(DIR + @"\Jezik.txt"))
            {
                sr.ReadLine();
                return sr.ReadLine();
            }
        }

        public static void DeleteIgraci()
        {
            File.Delete(PATHIgraci);
        }

    }
}
