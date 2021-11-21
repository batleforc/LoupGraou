using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Role;

namespace Moteur
{
    public class Player
    {
        private string username;
        private string socketId;
        private bool IsAlive;
        private IRole role;
        private IRole[] subRole;
        private string userPic;

    }
}
