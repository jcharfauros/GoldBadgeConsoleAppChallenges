using KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Menu
{
    class MenuUI
    {
        private MenuContentRepository _menuContentRepo = new MenuContentRepository();

        public void Run()
        {
            CurrentMenuList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\nPlease select an option to proceed:\n\n" +
                    "1. Create New Menu Item\n" +
                    "2. View All Menu Items\n" +
                    "3. View Menu Meals by Name\n" +
                    "4. Remove Existing Menu Item\n" +
                    "5. Exit\n\n");

                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case"one":                    
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":                    
                        DisplayAllMenuItems();
                        break;
                    case "3":
                    case "three":
                        DisplayMealsByName();
                        break;
                    case "4":
                    case "four":
                        RemoveMenuItem();
                        break;
                    case "5":
                    case "five":                        
                        Console.WriteLine("See you next time.");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewContent()
        {
            Console.Clear();
            MenuContent newMenuContent = new MenuContent();

            Console.WriteLine("Enter the name of the meal:");
            newMenuContent.MealName = Console.ReadLine();

            Console.WriteLine("Enter the meal's menu number:");
            string menuNumAsString = Console.ReadLine();
            newMenuContent.MealNumber = int.Parse(menuNumAsString);

            Console.WriteLine("Enter the description for the meal:");
            newMenuContent.Description = Console.ReadLine();

            Console.WriteLine("Enter the ingredients list for the meal:");
            newMenuContent.Ingredients = Console.ReadLine();

            Console.WriteLine("Enter the meal's sale price:");
            string priceAsString = Console.ReadLine();
            newMenuContent.Price = double.Parse(priceAsString);
                        
            _menuContentRepo.AddContentToList(newMenuContent);
        }
                
        private void DisplayAllMenuItems()
        {
            Console.Clear();

            List<MenuContent> listMenuContent = _menuContentRepo.GetMenuList();

            foreach (MenuContent menuContent in listMenuContent)
            {
                Console.WriteLine($"Meal Name: {menuContent.MealName}\n" +
                    $"Description: {menuContent.Description}\n");
            }
        }
               
        private void DisplayMealsByName()
        {
            Console.Clear();
            
            Console.WriteLine("Enter name of the meal you want to see:\n");
            
            string mealName = Console.ReadLine();
            
            MenuContent menuContent = _menuContentRepo.GetMenuItemByName(mealName);            

            if (menuContent != null)
            {
                Console.WriteLine($"\nMEAL NAME     : {menuContent.MealName}\n" +
                    $"MENU ITEM#    : {menuContent.MealNumber}\n" +
                    $"DESCRIPTION   : {menuContent.Description}\n" +
                    $"INGREDIANTS   : {menuContent.Ingredients}\n" +
                    $"MENU PRICE    : {menuContent.Price}\n");
            }
            else
            {
                Console.WriteLine("No meal on the menu by that name.");
            }
        }
        
        private void RemoveMenuItem()
        {
            DisplayAllMenuItems();
                        
            Console.WriteLine("\n\nEnter the name of the menu item you want to delete:\n\n");
            string input = Console.ReadLine();
                        
            bool removeItem = _menuContentRepo.RemoveMenuItemFromList(input);
                        
            if (removeItem)
            {
                Console.WriteLine("You successfully deleted the menu item.");
            }
            else
            {
                Console.WriteLine("The menu item could not be deleted.");
            }
        }
             
        // Seed 
        private void CurrentMenuList()
        {
            MenuContent breakfast = new MenuContent("Breakfast Special", 1,
                "A hardy breakfast for earlier birds.", 
                "Pancakes, bacon, eggs, sliced oranges", 6.99);
            MenuContent lunch = new MenuContent("Lunch Special", 2, 
                "Quick, light lunch for the working person",
                "Bread, Lettuce, Deli Turkey, Tomato, bag of chips", 8.99);
            MenuContent dinner = new MenuContent("Dinner Special", 3, 
                "Easy dinner for busy people",
                "Small salad, chicken, mashed potatoes, broccoli", 11.99);

            _menuContentRepo.AddContentToList(breakfast);
            _menuContentRepo.AddContentToList(lunch);
            _menuContentRepo.AddContentToList(dinner);

        }
    }
}
