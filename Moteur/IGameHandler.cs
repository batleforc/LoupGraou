using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur
{
    public interface IGameHandler
    {
        IGame GetGame(string game);
        void DeleteGame();
        List<IGame> GetGames();
        void CreateGame(string name);
        void CreateGame(IGame game);
    }
}
