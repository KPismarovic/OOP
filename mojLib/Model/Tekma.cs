using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojLib.Model
{
    public class Tekma :IComparable<Tekma>
    {
        public string Venue { get; set; }
        public string Location { get; set; }
        public int Attendance { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public List<TeamEvents> HomeTeamEvents { get; set; }
        public List<TeamEvents> AwayTeamEvents { get; set; }
        public TeamStatistics HomeTeamStatistics { get; set; }
        public TeamStatistics AwayTeamStatistics { get; set; }

        internal TeamStatistics GetTeamStatistics(string fifaCode)
        {
            if (HomeTeam.Code == fifaCode)
            {
                return HomeTeamStatistics;
            }
            else return AwayTeamStatistics;
        }

        public override string ToString() => $"{Venue}, {Location},  {HomeTeam.Country} - {AwayTeam.Country}   {Attendance}";

        public int CompareTo(Tekma other) => -this.Attendance.CompareTo(other.Attendance);
    }
}
