using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur
{
    internal interface IUser
    {
        string getUsername();
        string getSocket();
        string getRole();
        string isAlive();
    }
}
