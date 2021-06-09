using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Robbing a bank! Robbing a whole bank! Beat that for a date!");
            Console.WriteLine("-----------------------------------------------------------");

            // Let's build out a rolodex of possible recruits first.
            Hacker dcotor = new Hacker()
            {
                Name = "The Doctor",
                SkillLevel = 90,
                PercentageCut = 35
            };

            Hacker psi = new Hacker()
            {
                Name = "Psi",
                SkillLevel = 75,
                PercentageCut = 25 
            };

            LockSpecialist saibra = new LockSpecialist()
            {
                Name = "Saibra",
                SkillLevel = 60,
                PercentageCut = 30
            };

            LockSpecialist clara = new LockSpecialist()
            {
                Name = "Clara Oswald",
                SkillLevel = 75,
                PercentageCut = 45
            };

            Muscle danny = new Muscle()
            {
                Name = "Danny Pink",
                SkillLevel = 65,
                PercentageCut =  25
            };

            Muscle teller = new Muscle()
            {
                Name = "The Teller",
                SkillLevel = 85,
                PercentageCut = 47
            };

            /*In the Main method, create a List<IRobber> and store it in a variable named rolodex.
             This list will contain all possible operatives that we could employ for future heists. 
             We want to give the user the opportunity to add new operatives to this list, but for now 
             let's pre-populate the list with 5 or 6 robbers (give it a mix of Hackers, Lock Specialists, and Muscle).*/
            List<IRobber> rolodex = new List<IRobber>()
            {
                dcotor, psi, saibra, clara, danny, teller
            };

            /*When the program starts, print out the number of current operatives in the rolodex. 
            Then prompt the user to enter the name of a new possible crew member. 
            Once the user has entered a name, print out a list of possible specialties and have the user select which specialty this operative has. 
            The list should contain the following options.*/
            BuildYourCrew();
            void BuildYourCrew()
            {
                Console.WriteLine($"Current crew for heist: {rolodex.Count}.");
                Console.WriteLine();
                Console.WriteLine("We need to get the 'band' back together...");
                Console.Write("Who do we need: ");
                string operativeName = Console.ReadLine(); 
                if (operativeName == "")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    Console.WriteLine(@"
                    Your survival depends on following my instructions. 
                    All the information you need is in this case. The Bank of Karabraxos is impregnable. 
                    The Bank of Karabraxos has never been breached. You will rob the Bank of Karabraxos.
                    ");
                    return;
                }
                else 
                {
                    Console.WriteLine("Who do we need?");
                    Console.Write(@"
                    [1] Hacker (Disables alarms)
                    [2] Muscle (Disarms guards)
                    [3] Lock Specialist (Cracks vault): ");
                    // parse the string entered into an integer for the program
                    int operativeRole = Int32.Parse(Console.ReadLine());
                    /*Once the user has selected a specialty, prompt them to enter the crew member's skill level as an integer between 1 and 100. 
                    Then prompt the user to enter the percentage cut the crew member demands for each mission. Once the user has entered the crew member's name, specialty, skill level, and cut, 
                    you should instantiate the appropriate class for that crew member (based on their specialty) and they should be added to the rolodex.*/
                    Console.Write($"What's {operativeName} skill level (1-100): ");
                    int skillSet = Int32.Parse(Console.ReadLine());

                    Console.Write($"What will {operativeName} cut be? (1-100): ");
                    int cut = Int32.Parse(Console.ReadLine());
                }
            }

        }
    }
}
