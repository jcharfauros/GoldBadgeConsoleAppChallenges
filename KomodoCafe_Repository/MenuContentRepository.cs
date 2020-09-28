using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Repository
{
    public class MenuContentRepository
    {        
        private List<MenuContent> _listOfMenuContent = new List<MenuContent>();
                                    //varible that can be used everywhere

        //Create new menu items method
        public void AddContentToList(MenuContent content)
        {
            _listOfMenuContent.Add(content);
        }

        //Read the items in the menu
        public List<MenuContent> GetMenuList()
        {
            return _listOfMenuContent;
        }

        //Delete items
        public bool RemoveMenuItemFromList(string mealName)
        {
            MenuContent content = GetMenuItemByName(mealName);

            if (content == null)
            {
                return false;
            }

            int initalCount = _listOfMenuContent.Count;
            _listOfMenuContent.Remove(content);

            if(initalCount > _listOfMenuContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper methods
        public MenuContent GetMenuItemByName(string mealName)
        {
            foreach(MenuContent content in _listOfMenuContent)
            {
                if(content.MealName.ToLower() == mealName.ToLower())
                {
                    return content;
                }
            }
            return null;
        }        
    }
}
