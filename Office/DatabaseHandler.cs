using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class DatabaseHandler : TheFrontDesk
    {
        public DatabaseHandler()
        {
            who = "Database handler";
            Access = "1) Kitchen\n2) Database room\n";
        }
        public override void Enter()
        {
            Console.WriteLine("\"Can't wait to work on the server\" you think to yourself.");
            base.Enter();
        }
    }
}
