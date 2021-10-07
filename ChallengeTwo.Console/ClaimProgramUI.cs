
using ChallengeTwoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoConsole
{                
    public class ClaimProgramUI : Claims
    {
        public ClaimRepository _claimRepository = new ClaimRepository();
        public Claims updatedClaim = new Claims();
                                                   /// <summary>
                                                   /// need to build out next queue and bool isValid 
                                                   /// </summary>

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
                    "1. View all claims\n" +
                    "2. View Next Claim\n " +
                    "3. Create New Claim\n" +
                    "0. Exit"
                    );

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        ViewNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
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

        private void CreateNewClaim()
        {
            Console.Clear();

            Claims claim = new Claims();

            Console.WriteLine("Please enter Claim ID:");
            claim.ClaimID = Console.ReadLine();

            Console.WriteLine("Please enter a Type of Claim:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n");

            string typeOfClaimString = Console.ReadLine();
            int typeOfClaimId = int.Parse(typeOfClaimString);
            claim.TypeOfClaim = (ClaimType)typeOfClaimId;

            //claim.TypeOfClaim = (ClaimType)int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Description:");
            claim.Description = Console.ReadLine();

            Console.WriteLine("Please enter a Claim Amount:");
            claim.ClaimAmount = Console.ReadLine();

            Console.WriteLine("Please enter the Date Of the Incident:");
            claim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Please enter the Date Of the Claim:");
            claim.DateOfClaim = Console.ReadLine();

            Console.WriteLine("Please enter Y or N if Valid:");
            claim.IsValid = IsValid();

            _claimRepository.AddContentToDirectory(claim);
        }


        private void ViewAllClaims()
        {
            //Clean slate to work from
            Console.Clear();

            List<Claims> listOfContent = _claimRepository.GetContents();

            foreach (Claims claim in listOfContent)
            {
                //Using helper method
                DisplayContent(claim);
            }

            PressAnyKeyToContinue();
        }

        
        private void ViewNextClaim()
        {
            Console.Clear();

            Console.WriteLine("Do you want to deal with this claim now(y/n)?");
            string ClaimID = Console.ReadLine();

            Claims claim = _claimRepository.GetByClaimID(ClaimID);
            //Verify that content is in our repository

            if (claim != null)
            {
                //Using helper method
                DisplayContent(claim);
            }
            else
            {
                Console.WriteLine("Unfortunatley, There are no more claims");
            }

            PressAnyKeyToContinue();

        }


      //Helper Methods
        private void DisplayContent(Claims claim)
        {
            Console.WriteLine(
                    $"ClaimID: {claim.ClaimID}\n" +
                    $"ClaimType: {claim.TypeOfClaim}\n" +
                    $"Description: {claim.Description}\n" +
                    $"ClaimAmount: {claim.ClaimAmount}\n" +
                    $"DateOfIncident: { claim.DateOfIncident}\n" +
                    $"DateOfClaim: {claim.DateOfClaim}\n" +
                    $"IsValid: {claim.IsValid}\n");
        }
        private bool IsValid()
        {
            string userInput = Console.ReadLine();

            if (userInput == "y")
            {
                Console.WriteLine("This claim is valid");
                return true;
            }
            else 
            {
                Console.WriteLine("This claim is not valid");
                return false;
            }

        }


        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void SeedData()
        {
            Claims Car = new Claims("1", ClaimType.Car, "Car accident on 465", "$400.00", "4/25/18", "4/27/18", true);
            Claims Home = new Claims("2", ClaimType.Home, "House fire in kitchen", "$4000.00", "4/11/18", "4/12/18", true);
            Claims Theft = new Claims("3", ClaimType.Theft, "Stolen pancakes", "4.00", "4/27/18", "6/01/18", false);

            _claimRepository.AddContentToDirectory(Car);
            _claimRepository.AddContentToDirectory(Home);
            _claimRepository.AddContentToDirectory(Theft);
        }
    }
}

