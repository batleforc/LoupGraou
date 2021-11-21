using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur
{
    public interface IRole
    {
        int DailyVotePoder();
        int NightVotePoder();
        int NightOrder();
        void NightAction();
        void Die();
        void Victory();
        bool IsSubRole();
    }
}
