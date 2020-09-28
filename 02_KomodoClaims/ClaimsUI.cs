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
            ClaimsList();
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
                    //NextClaim();
                    case "2":
                    case "two":                    
                    //EnterANewClaim();
                    case "3":
                    case "three":                    
                    //exit    
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

        //view all claims
        private void ViewAllClaims()
        {
            Console.Clear();

            List<ClaimsContent> listClaimsContent = _claimContentRepo.Returnallclaims();

            foreach (ClaimsContent claimsContent in listClaimsContent)
            {
                Console.WriteLine(
                    $"ClaimID: {claimsContent.ClaimID}",
                    $"Type: {claimsContent.ClaimType}",
                    $"Description: {claimsContent.Description}",
                    $"Amount: {claimsContent.ClaimAmount}",
                    $"DateOfAccident: {claimsContent.DateOfAccident}",
                    $"DateOfClaim: {claimsContent.DateOfClaim}",
                    $"IsValid: {claimsContent.IsVaild}");
            }           
        }
        // take care of next claim
        private void NextClaim()
        {

        }
        // create new claim
        private void EnterANewClaim()
        {

        }

        //Seed method
        private void ClaimsList()
        {
            ClaimsContent claimOne = new ClaimsContent(1, ClaimType.Car, "Car accident on 465.", 400.00,
                DateTime.Parse("04/25/18"), DateTime.Parse("04/27/18"), true);
            ClaimsContent claimTwo = new ClaimsContent(2, ClaimType.Home, "House fire in kitchen", 4000.00,
                DateTime.Parse("04/11/18"), DateTime.Parse("04/12/18"), true);
            ClaimsContent claimThree = new ClaimsContent(3, ClaimType.Theft, "Stolen pancakes.", 4.00,
                DateTime.Parse("04/27/18"), DateTime.Parse("06/01/18"), false);

            _claimContentRepo.AddClaimsToList(claimOne);
            _claimContentRepo.AddClaimsToList(claimTwo);
            _claimContentRepo.AddClaimsToList(claimThree);
        }
    }
}
