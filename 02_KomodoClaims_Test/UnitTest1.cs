using System;
using System.Collections;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_KomodoClaims_Test
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void TestMethod1()
        {            
            Queue nextClaim = new Queue();
            nextClaim.Enqueue("ClaimID");
            nextClaim.Enqueue("Type");
            nextClaim.Enqueue("Description");
            nextClaim.Enqueue("Amount");
            nextClaim.Enqueue("DateOfAccident");
            nextClaim.Enqueue("DateOfClaim");
            nextClaim.Enqueue("IsValid");

            Console.WriteLine($"Number of claims = {nextClaim.Count}");

            //while (nextClaim.Count > 0)            
            //    Console.WriteLine(nextClaim.Dequeue());

            Console.WriteLine($"The peek of nextClaim is: {nextClaim.Peek()}");
            Console.WriteLine($"Number of claims = {nextClaim.Count}");

            //foreach (var element in nextClaim)
            //{
            //    Console.WriteLine(element);
            //}

            //notes: Enqueue() method to add elements
            //       Dequeue() method returns and removes top most element
            //       Peek() method returns, but does not remove top most element
            //       Dequeue() and Peek() on an empty queue throws an exception



            //date of claim -- this is what I had originally came up with, and it's wrong
            //Console.WriteLine("Enter the date of the new claim (mm/dd/yyyy):");
            //string cDate = "mm/dd/yyyy";
            //DateTime claimDate = DateTime.Parse(cDate);
            //newClaim.DateOfClaim = claimDate;

            //**BELOW DID NOT WORK EITHER

            //Console.WriteLine("\nEnter the date of the accident (mm/dd/yyyy):\n");
            //DateTime accidentDate = DateTime.Parse(Console.ReadLine());
            //accidentDate.ToString("mm/dd/yyyy");
            //newClaim.DateOfAccident = accidentDate;
        }          

    }
}
