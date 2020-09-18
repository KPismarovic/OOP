using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojLib.Model
{
    public class Igrac : IComparable<Igrac>
    {
        private const char DELIMITER = '|';

        public string Name { get; set; }
        public int ShirtNumber { get; set; }
        public string Position { get; set; }
        private string captain;
        public string Captain {
            get
            {
                return captain;
            }
            set
            {
                if (value.ToLower() == "false" || value == "")
                {
                    captain = "";
                }
                else
                {
                    captain = "Captain";
                }
            }
        }

        public bool OmiljeniIgrac { get; set; }
        public int BrojGolova { get; set; }
        public int BrojKartona { get; set; }
        public int BrojPojavljivanja { get; set; }
        public int GoloviUTekmi { get; set; }
        public int KartoniUTekmi { get; set; }

        private string slika = Repo.DIR + @"\Slike\DefaultPlayer.png";

        public string Slika
        {
            get { return slika; }
            set { slika = value; }
        }
        

        public int CompareTo(Igrac other) => -BrojGolova.CompareTo(other.BrojGolova);

        internal string FormatForFileLine() => $"{Name}{DELIMITER}{ShirtNumber}{DELIMITER}{Position}{DELIMITER}{Captain}{DELIMITER}" +
            $"{Slika}{DELIMITER}{OmiljeniIgrac}{DELIMITER}{BrojGolova}{DELIMITER}{BrojKartona}{DELIMITER}{BrojPojavljivanja}";

        internal static Igrac ParseFromFileLine(string line)
        {
            string[] details = line.Split(DELIMITER);
            return new Igrac
            {
                Name = details[0],
                ShirtNumber = int.Parse(details[1]),
                Position = details[2],
                Captain = details[3],
                Slika = details[4],
                OmiljeniIgrac = bool.Parse(details[5]),
                BrojGolova = int.Parse(details[6]),
                BrojKartona = int.Parse(details[7]),
                BrojPojavljivanja = int.Parse(details[8]),
            };
        }
    }
}
