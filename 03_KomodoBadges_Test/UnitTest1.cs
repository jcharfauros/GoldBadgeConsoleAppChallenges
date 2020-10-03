using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_KomodoBadges_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateNewDictionary()
        {
            //following example on how to create a dictionary
            //https://www.dotnetperls.com/dictionary
            var badge = new Dictionary<string, int>;
            badge.Add("B1234", 2);
            badge.Add("B1235", 1);
            badge.Add("B1236", 0);
            badge.Add("B1237", -1);

            Console.WriteLine("badge 1: " +
                badge.Count);

            var badge2 = new Dictionary<string, int>
            {
                {"B1234", 2 },
                {"B1235", 1 },
                {"B1236", 0 },
                {"B1237", -1 }
            };
            Console.WriteLine("BADGES 2:" +
                badge2.Count);

            //output
            //BADGES 1: 4
            //BADGES 2: 2           
        }
        [TestMethod]
        public void CreateBadge()
        {
            var badge = new Dictionary<int, string>;
            badge.Add(12345, "A5");
            badge.Add(12345, "A7");
            //can i use this to show which doors a badge has access too??
            Console.WriteLine("");
        }


        [TestMethod]
        public void MyTestKeys()
        {
            var data = new Dictionary<string, int>()
            {
                {"B1234", 2 },
                {"B1235", 1 },
                {"B1236", 0 },
                {"B1237", -1 }
            };
            //store keys in a list
            var list = new List<string>(data.Keys);
            //loop through list
            foreach (string badge in list)
            {
                Console.WriteLine("Badges:" + badge);
            }

            //output
            //Badges: B1234
            //Badges: B1235
            //Badges: B1236
            //Badges: B1237
        }
        [TestMethod]
        public void ContainsKey()
        {
            Dictionary<string, int> badge = new Dictionary<string, int>();

            badge.Add("B1238", 1);
            badge.Add("B1239", 5);

            // see if dictionary contains this string
            //note: i can check to see if a badge has access to a door
            if (badge.ContainsKey("B1238"))
            {
                int value = badge["B1238"];
                Console.WriteLine(value);
            }
            // see if dictionary contains this string
            if (!badge.ContainsKey("acorn"))
            {
                Console.WriteLine(false);
            }

            //output
            //1
            //false
        }
    }
}
