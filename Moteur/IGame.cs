using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Role;

namespace Moteur
{
    public interface IGame
    {
        string GetName();
        void SetName(string name);
        List<Player> GetPlayers();
        List<string> GetHistory();
        void ForceEndGame();
        void StartGame();
        EnumTeam GetWinner();
        bool IsEnded();
    }
}
