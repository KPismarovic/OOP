using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojLib
{
    public class Reprezentacija
    {
        
        public string Country { get; set; }
        public string FifaCode { get; set; }
       
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GamesPlayed { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifferential { get; set; }

        public override string ToString() => $"{Country} ({FifaCode})";

    }
}
