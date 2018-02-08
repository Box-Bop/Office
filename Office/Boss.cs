using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Boss : TheFrontDesk
    {
        public Boss()
        {
            who = "Boss";
            Access = "1) Developer room\n2) Kitchen\n3) Database room\n4) Bosses office";
        }
        public override void Enter()
        {
            Console.WriteLine("The receptionist gets embarrased for not knowing his own boss.");
            base.Enter();
        }
    }
}
