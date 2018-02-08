using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Developer : TheFrontDesk
    {
        public Developer()
        {
            who = "Developer";
            Access = "1) Developer room\n2) Kitchen\n";
        }
        public override void Enter()
        {
            Console.WriteLine("\"Another day to fill my history with Stack Overflow links\"\n");
            base.Enter();
        }
    }
}
