using _02_KomodoClaims_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims
{
    class ClaimsUI
    {
        private ClaimsRepository _claimContentRepo = new ClaimsRepository();

        public void Run()
        {
            Claims();            
            //ClaimsList();
        }

        private void Claims()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\nPlease select a vaild menu option:\n\n" +
                    "1. View All Claims\n" +
                    "2. Take Care of Next Claim\n" +
                    "3. Enter a New Claim\n" +
                    "4. Exit");

                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "one":                    
                        ViewAllClaims();
                        break;
                    case "2":
                    case "two":                    
                    //NextClaim();
                        break;
                    case "3":
                    case "three":
                        EnterANewClaim();
                        break;                    
                    case "4":
                    case "four":                    
                        Console.WriteLine("You are now exiting the program.");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("That is not a vaild option, please try again.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
                
        private void ViewAllClaims()
        {
            Console.Clear();
            Console.WriteLine($"\n{"ClaimID"} " +
                              $"{"Type", 5} " +
                              $"{"Description", -20} " +
                              $"{"Amount", -10}" +
                              $"{"DateOfAccident", -10} " +
                              $"{"DateOfClaim", -10} " +
                              $"{"IsValid", -5}\n");
            
            Queue<ClaimsContent> listClaimsQueue = _claimContentRepo.ReturnAllClaims();
            
            foreach (ClaimsContent claimsContent in listClaimsQueue)
            {   //string interpolation formatting!!! HUZZAH! 
                Console.WriteLine(
                        $"{claimsContent.ClaimID, 3}" +
                        $"{claimsContent.ClaimType, 9}" +
                        $"{claimsContent.Description, 20}" +
                        $"{claimsContent.ClaimAmount, 10:C}" +
                        $"{claimsContent.DateOfAccident, -15:MM/dd/yyyy}" +
                        $"{claimsContent.DateOfClaim, -15:MM/dd/yyyy}" +
                        $"{claimsContent.IsVaild, 5}");
            }            
        }
        // take care of next claim
        private void NextClaim()
        {

        }
        // create new claim
        private void EnterANewClaim()
        {   
            Console.Clear();
            ClaimsContent newClaim = new ClaimsContent();
                        
            Console.WriteLine("Enter the ID for the new claim:\n");
            string claimIDString = Console.ReadLine();
            int claimIdInt = int.Parse(claimIDString);
            newClaim.ClaimID = claimIdInt;
                        
            Console.WriteLine("\nEnter the claim type number for the new claim:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n\n");

            string claimTypeAsString = Console.ReadLine();
            int claimAsInt = int.Parse(claimTypeAsString);
            newClaim.ClaimType = (ClaimType)claimAsInt;
                        
            Console.WriteLine("\nEnter a description for the new claim:\n");
            newClaim.Description = Console.ReadLine();
                        
            Console.WriteLine("\nEnter the new claim amount:\n");
            string claimAmountString = Console.ReadLine();
            double amountAsInt = double.Parse(claimAmountString);
            newClaim.ClaimAmount = amountAsInt;
                        
            Console.WriteLine("\nEnter the date of the accident (mm/dd/yyyy):\n");
            DateTime accidentDate = DateTime.Parse(Console.ReadLine());                      
            newClaim.DateOfAccident = accidentDate;
                        
            Console.WriteLine("\nEnter the date of the new claim (mm/dd/yyyy):\n");
            DateTime claimDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfClaim = claimDate;
                        
            Console.WriteLine("\nIs this new claim valid? (y/n)\n");
            string claimIsValid = Console.ReadLine().ToLower();
            if(claimIsValid == "y")
            {
                newClaim.IsVaild = true;
            }
            else
            {
                newClaim.IsVaild = false;
            }

            _claimContentRepo.EnterANewClaim(newClaim);                                   

        }

        //Seed method
        //private void ClaimsList()
        //{
        //    ClaimsContent claimOne = new ClaimsContent(1, ClaimType.Car, "Car accident on 465.", 400.00,
        //        DateTime.Parse("04/25/18"), DateTime.Parse("04/27/18"), true);
        //    ClaimsContent claimTwo = new ClaimsContent(2, ClaimType.Home, "House fire in kitchen", 4000.00,
        //        DateTime.Parse("04/11/18"), DateTime.Parse("04/12/18"), true);
        //    ClaimsContent claimThree = new ClaimsContent(3, ClaimType.Theft, "Stolen pancakes.", 4.00,
        //        DateTime.Parse("04/27/18"), DateTime.Parse("06/01/18"), false);

        //    _claimContentRepo.AddClaimsToList(claimOne);
        //    _claimContentRepo.AddClaimsToList(claimTwo);
        //    _claimContentRepo.AddClaimsToList(claimThree);
        //}
    }
}
