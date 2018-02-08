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
            switch (who)
            {
                case "Young Developer":
                    Console.WriteLine(Access);
                    int dec = Convert.ToInt16(Console.ReadLine());
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
                    Console.WriteLine(Access);
                    int dec2 = Convert.ToInt16(Console.ReadLine());
                    switch (dec2)
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
                    Console.WriteLine(Access);
                    int dec3 = Convert.ToInt16(Console.ReadLine());
                    switch (dec3)
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
                    Console.WriteLine(Access);
                    int dec4 = Convert.ToInt16(Console.ReadLine());
                    switch (dec4)
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
            }
        }
    }
}
