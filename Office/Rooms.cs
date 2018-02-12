using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Rooms
    {
        protected void DeveloperRoom()
        {
            Console.Clear();
            Console.WriteLine("You head to the developers room, where there are only a few\npeople, but they're all working. It's great to see that.\n\n");
        }
        protected void BossesOffice()
        {
            Console.Clear();
            Console.WriteLine("You go to your office to boss around, like a real boss.\n\n");
        }
        protected void Kitchen()
        {
            Console.Clear();
            Console.WriteLine("Your stomach is now full and you're ready to do some work.\n\n");
        }
        protected void DatabaseRoom()
        {
            Console.Clear();
            Console.WriteLine("All these servers look pretty with all their colours.\nYou end up staring at them for the rest of the day.\n\n");
        }
    }
}
