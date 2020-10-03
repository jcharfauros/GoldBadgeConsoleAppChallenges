using _03_KomodoBadges_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBagdes
{
    class BadgeUI
    {
        private BadgeContentRepository _badgeContentRepo = new BadgeContentRepository();
        public void Run()
        {
            Badges();
        }

        private void Badges()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\nPlease select a vaild menu option to proceed:\n\n" +
                    "1. CREATE a new badge\n" +
                    "2. VIEW all badges and it's door access\n" +
                    "3. UPDATE door access on existing badge\n" +
                    "4. DELETE door access on existing badge\n" +
                    "5. EXIT program\n\n");

                string userInput = Console.ReadLine().ToLower();
                
                switch (userInput)
                {
                    case "1":
                    case "one":
                        Console.WriteLine($"You have entered menu option to CREATE, hit enter to continue..");
                        Console.ReadKey();
                        CreateBadge();
                        break;
                    case "2":
                    case "two":
                        GetBadgeList();
                        break;
                    case "3":
                    case "three":
                        UpdateAccess();
                        break;
                    case "4":
                    case "four":
                        DeleteAccess();
                        break;
                    case "5":
                    case "five":
                        Console.WriteLine("\nYou are exiting the application. Goodbye.");                        
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("\nThat is not a valid option, please try again.");
                        break;
                }

                Console.WriteLine("\n\nPlease press any key to continue to exit application...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DeleteAccess()
        {
            throw new NotImplementedException();
        }

        private void UpdateAccess()
        {
            throw new NotImplementedException();
        }

        private void CreateBadge()
        {
            Console.Clear();
            BadgeContent newBadge = new BadgeContent();

            Console.WriteLine("\nEnter Badge ID:\n");
            string newBadgeString = Console.ReadLine();
            int newBadgeInt = int.Parse(newBadgeString);
            newBadge.BadgeID = newBadgeInt;
            Console.Clear();

            Console.WriteLine("\nEnter a name for the badge:\n");
            newBadge.BadgeName = Console.ReadLine();

            List<string> newDoorAccess = new List<string>();
            Console.WriteLine("\nEnter a name of the door it can access:\n");
            string doorInput = Console.ReadLine();
            newDoorAccess.Add(doorInput);
        }

        private void GetBadgeList()
        {
            Console.Clear();
            Console.WriteLine($"{"Badge #",-10}{"Door Name",-10}");

            //Dictionary<int, BadgeContent> badgeContent = .GetBadgeList();
            //INCOMPLETE
        }              
        
    }
}
