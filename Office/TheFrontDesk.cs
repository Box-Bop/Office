using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class TheFrontDesk : Rooms
    {
        public string who;
        public string Access;

        public virtual void Enter()
        {
            Console.WriteLine("Right, you were the/a " + who + " here!\nWhich room do you wish to head to?");
            Console.WriteLine(Access);
            int dec = Convert.ToInt16(Console.ReadLine());
            switch (who)
            {
                
                case "Young Developer":
                    switch (dec)
                    {
                        case 1:
                            DeveloperRoom();
                            break;
                        case 2:
                            Kitchen();
                            break;
                    }
                    break;
                case "Boss":
                    switch (dec)
                    {
                        case 1:
                            DeveloperRoom();
                            break;
                        case 2:
                            Kitchen();
                            break;
                        case 3:
                            DatabaseRoom();
                            break;
                        case 4:
                            BossesOffice();
                            break;
                    }
                    break;
                case "Developer":
                    switch (dec)
                    {
                        case 1:
                            DeveloperRoom();
                            break;
                        case 2:
                            Kitchen();
                            break;
                    }
                    break;
                case "Janitor":
                    switch (dec)
                    {
                        case 1:
                            Kitchen();
                            break;
                    }
                    break;
                case "Database handler":
                    switch (dec)
                    {
                        case 2:
                            DatabaseRoom();
                            break;
                        case 1:
                            Kitchen();
                            break;
                    }
                    break;
                case "Electronic Cleaner":
                    switch (dec)
                    {
                        case 1:
                            DeveloperRoom();
                            break;
                        case 2:
                            Kitchen();
                            break;
                        case 3:
                            DatabaseRoom();
                            break;
                    }
                    break;
            }
        }
    }
}
