using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur
{
    public class SingleGameHandler : IGameHandler
    {
        public static Game game;

        public void CreateGame(string name)
        {
            game = new Game();
        }
        public void CreateGame(IGame newGame)
        {
            game = (Game)newGame;
        }

        public void DeleteGame()
        {
            throw new NotImplementedException();
        }

        public IGame GetGame(string gameName)
        {
            return game;
        }

        public List<IGame> GetGames()
        {
            List<IGame> toReturn = new List<IGame>();
            toReturn.Add(game);
            return toReturn;
        }
    }
}
