using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims
{
    class Program
    {
        static void Main(string[] args)
        {
            //increase the console app's window size
            Console.BufferWidth = 100;
            Console.SetWindowSize(Console.BufferWidth, 25);            

            ClaimsUI claimsProgram = new ClaimsUI();
            claimsProgram.Run();
        }
    }
}
