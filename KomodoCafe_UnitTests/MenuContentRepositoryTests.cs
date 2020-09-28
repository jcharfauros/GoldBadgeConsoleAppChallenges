using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Repository.Tests
{
    [TestClass()]
    public class MenuContentRepositoryTests
    {
        private List<MenuContent> _listOfMenuContent = new List<MenuContent>();

        [TestMethod()]

        public void KomodoCafeTest(MenuContent content)
        {
            _listOfMenuContent.Add(content);
            Assert.Fail();
        }
        public bool RemoveMenuItemFromList(string mealName)
        {
            MenuContent content = GetMenuItemByName(mealName);

            if (content == null)
            {
                return false;
            }

            int initalCount = _listOfMenuContent.Count;
            _listOfMenuContent.Remove(content);

            if (initalCount > _listOfMenuContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
               
        public MenuContent GetMenuItemByName(string mealName)
        {
            foreach (MenuContent content in _listOfMenuContent)
            {
                if (content.MealName == mealName)
                {
                    return content;
                }
            }
            return null;
        }
    }
}