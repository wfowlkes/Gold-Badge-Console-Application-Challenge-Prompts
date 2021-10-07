using BadgesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesConsole
{
    public class ProgramUI
    {

        public BadgesRepo _badgesRepository = new BadgesRepo();
        public BadgesRepository.Badges updatedBadges = new BadgesRepository.Badges();


        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select between numbers 0 and 3:\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n " +
                    "3. List all badges\n" +                   
                    "0. Exit"
                    );

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;            
                    case "0":
                        Console.WriteLine("Thank you GoodBye");
                        isRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 0 and 3.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;

                }
            }
        }

        private void AddABadge()
        {
            Console.Clear();

            BadgesRepository.Badges badges = new BadgesRepository.Badges();

            Console.WriteLine("What is the number on the badge:");
            badges.BadgeID = Console.ReadLine();

            Console.WriteLine("Please list a door that BadgeID needs access to:");
            string ListOfDoorNames = Console.ReadLine();
           
            Console.WriteLine("Any other doors(y / n)");
            string userInput = Console.ReadLine();

                if (userInput == "y")
                {
                Console.WriteLine("What is the number on the badge");                   
                }
                else
                {
                 Console.WriteLine();
                 bool isRunning = false;
                }

                _badgesRepository.AddContentToDirectory(badges);
        }


        private void ListAllBadges()
        {
            //Clean slate to work from
            Console.Clear();

            List<BadgesRepository.Badges> listOfContent = _badgesRepository.GetContents();

            foreach (BadgesRepository.Badges badges in listOfContent)
            {
                //Using helper method
                DisplayContent(badges);
            }
            PressAnyKeyToContinue();
        }
        private void EditABadge()
        {
            Console.Clear();

            Console.WriteLine("What is the number on the badge?");
            string BadgeID = Console.ReadLine();

            BadgesRepository.Badges badges = _badgesRepository.GetByBadgeID(BadgeID);
            //Verify that content is in our repository

            if (badges != null)
            {
                //Using helper method
                DisplayContent(badges);
            }
            else
            {
                Console.WriteLine("Unfortunatley, you made a booboo");

            }
            Console.WriteLine("What Door are we updating?");
            string ListOfDoorNames = Console.ReadLine();

            Console.WriteLine("Any other doors(y / n)");
            string userInput = Console.ReadLine();

            if (userInput == "y")
            {
                Console.WriteLine("Ok, what door are we updating");
            }
            else
            {
                Console.WriteLine();
                bool isRunning = false;
            }
                _badgesRepository.AddContentToDirectory(badges);
        
                 PressAnyKeyToContinue();
        }
        //Helper Methods
        private void DisplayContent(BadgesRepository.Badges badges)
        {
            Console.WriteLine(
                    $"BadgeID: {badges.BadgeID}\n" +
                    $"ListOfDoorNames: {badges.ListOfDoorNames}\n");
        }
        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        }
    }

