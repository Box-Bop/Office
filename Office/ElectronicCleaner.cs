using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class ElectronicCleaner : TheFrontDesk
    {
        public ElectronicCleaner()
        {
            who = "Electronic Cleaner";
            Access = "1) Developer room\n2) Kitchen\n3) Database room\n";
        }
        public override void Enter()
        {
            Console.WriteLine("Those electronics must be dirty");
            base.Enter();
        }
    }
}
