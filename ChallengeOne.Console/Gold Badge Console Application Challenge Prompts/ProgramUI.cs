using ChallengeOneRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gold_Badge_Console_Application_Challenge_Prompts

{
    public class ProgramUi


    {
        public MenuRepository _MenuRepository = new MenuRepository();
        public Menu updatedMenu = new Menu();


        public void Run()
        {
            SeedData();

            RunMenu();
        }

        private void RunMenu()
        {

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select between numbers 0 and 3:\n" +
                    "1. View all Menu Items\n" +
                    "2. Delete Menu Item\n " +
                    "3. Add Menu Item\n" +
                    "0. Exit"
                    );

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAllMenuItems();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        AddMenuItem();
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

        private void AddMenuItem()
        {
            Console.Clear();

            Menu menu = new Menu();

            Console.WriteLine("Please enter Meal Number:");
            menu.MealNumber = Console.ReadLine();

            Console.WriteLine("Please enter Meal Name:");
            menu.MealName = Console.ReadLine();

            Console.WriteLine("Please enter a Description:");
            menu.Description = Console.ReadLine();

            Console.WriteLine("Please enter a Ingredients:");
            menu.Ingredients = Console.ReadLine();

            Console.WriteLine("Please enter the price:");
            menu.Price = Console.ReadLine();

            _MenuRepository.AddContentToDirectory(menu);
        }


        private void ViewAllMenuItems()
        {
            //Clean slate to work from
            Console.Clear();

            List<Menu> listOfContent = _MenuRepository.GetContents();

            foreach (Menu menu in listOfContent)
            {
                //Using helper method
                DisplayContent(menu);
            }

            PressAnyKeyToContinue();
        }



        private void DeleteMenuItem()
        {
            Console.Clear();

            List<Menu> contentList = _MenuRepository.GetContents();

            int index = 1;

            foreach (Menu content in contentList)
            {
                Console.WriteLine($"{index} {content.Description}");
                index++;
            }
            Console.WriteLine("What Menu Item would you like to delete?");
            int targetTitleId = int.Parse(Console.ReadLine());
            int targetIndex = targetTitleId - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                Menu targetContent = contentList[targetIndex];

                if (_MenuRepository.DeleteContent(targetContent))
                {
                    Console.WriteLine($"{targetContent.Description} was successfully deleted");
                }
                else
                {
                    Console.WriteLine("Something went wrong - let's try it again!");
                }
            }
            else
            {
                Console.WriteLine("Please make a vaild selection.");
            }
            PressAnyKeyToContinue();

        }
        //Helper Methods
        private void DisplayContent(Menu menu)
        {
            Console.WriteLine(
                    $"MealNumber: {menu.MealNumber}\n" +
                    $"MealName: {menu.MealName}\n" +
                    $"Description: {menu.Description}\n" +
                    $"Ingredients: {menu.Ingredients}\n" +
                    $"Price: { menu.Price}\n");
        }
        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeedData()
        {
            Menu TacoSpecial = new Menu("1", "TacoSpecial", "Taco", "lettuce + beef", "$2.50");
            Menu BurgerSpecial = new Menu("2", "BurgerSpecial", "Burger", "bread + beef", "$4.50");
            Menu ChiefSpecial = new Menu("5", "ChiefSpecial", "Special", "lettuce + bread + beef", "3.50");

            _MenuRepository.AddContentToDirectory(TacoSpecial);
            _MenuRepository.AddContentToDirectory(BurgerSpecial);
            _MenuRepository.AddContentToDirectory(ChiefSpecial);
        }
    }
}
