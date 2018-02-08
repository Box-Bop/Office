using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Janitor : TheFrontDesk
    {
        public Janitor()
        {
            who = "Janitor";
            Access = "1) Kitchen\n";
        }
        public override void Enter()
        {
            Console.WriteLine("\"I hope I get a raise soon\" you think to yourself\n");
            base.Enter();
        }
    }
}
