using Moteur.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur 
{
    public class Game : IGame
    {
        string name = "";
        List<Player> players = new List<Player>();
        List<string> history = new List<string>();
        EnumTeam team = EnumTeam.none;
        bool endPartie=false;
        bool PartieStarted = false;

        public void ForceEndGame()
        {
            PartieStarted = false ;
            endPartie = true ;
        }

        public List<string> GetHistory()
        {
            return history;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string p_name)
        {
            name = p_name;
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public EnumTeam GetWinner()
        {
            return team;
        }

        public bool IsEnded()
        {
            return endPartie;
        }

        public void StartGame()
        {
            PartieStarted = true;
        }
    }
}
