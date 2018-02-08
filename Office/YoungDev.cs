using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class YoungDev : TheFrontDesk
    {
        public YoungDev()
        {
            who = "Young Developer";
            Access = "1) Developer room\n2) Kitchen";
        }
        public override void Enter()
        {
            Console.WriteLine("*The front desk receptionist gives you some tips about programming*\n");
            base.Enter();
        }
    }
}
