using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojLib.Model
{
    public class TeamStatistics
    {
        private const string PATH = @"\Reprezentacija.txt";

        public List<Igrac> StartingEleven { get; set; }
        public List<Igrac> Substitutes { get; set; }

        

        public List<Igrac> GetListaIgraca(string FifaCode)
        {
            List<Igrac> kolekcijaIgraca = StartingEleven;
            
            kolekcijaIgraca.AddRange(Substitutes);
            kolekcijaIgraca.Concat(Substitutes);
            List<Tekma> tekme = Repo.GetUtakmice(FifaCode);
            foreach (var tekma in tekme)
            {
                if (tekma.AwayTeam.Code == Repo.LoadFromFile(PATH))
                {
                    foreach (var startingIgrac in tekma.AwayTeamStatistics.StartingEleven)
                    {
                        PostaviPojavljivanja(startingIgrac.Name,kolekcijaIgraca);
                    }
                    foreach (var teamEvent in tekma.AwayTeamEvents)
                    {
                        NadopuniPodatke(teamEvent, kolekcijaIgraca);
                    }
                }
                else
                {
                    foreach (var startingIgrac in tekma.HomeTeamStatistics.StartingEleven)
                    {
                        PostaviPojavljivanja(startingIgrac.Name,kolekcijaIgraca);
                    }
                    foreach (var teamEvent in tekma.HomeTeamEvents)
                    {
                        NadopuniPodatke(teamEvent, kolekcijaIgraca);
                    }
                }
            }

            return kolekcijaIgraca;
        }

        private void PostaviPojavljivanja(string name, List<Igrac> kolekcijaIgraca)
        {
            foreach (var igrac in kolekcijaIgraca)
            {
                if (igrac.Name == name)
                {
                    igrac.BrojPojavljivanja++;
                }
            }
        }

        private void NadopuniPodatke(TeamEvents teamEvent, List<Igrac> kolekcijaIgraca)
        {
            foreach (var igrac in kolekcijaIgraca)
            {
                if (igrac.Name == teamEvent.Player)
                {
                    if (teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty")
                    {
                        igrac.BrojGolova++;
                    }
                    else if (teamEvent.TypeOfEvent == "yellow-card")
                    {
                        igrac.BrojKartona++;
                    }
                    else if (teamEvent.TypeOfEvent == "substitution-in")
                    {
                        igrac.BrojPojavljivanja++;
                    }
                }
            }
        }

    }
}
