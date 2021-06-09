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
                PercentageCut = 35,
            };

            Hacker psi = new Hacker()
            {
                Name = "Psi",
                SkillLevel = 75,
                PercentageCut = 25,
            };

            LockSpecialist saibra = new LockSpecialist()
            {
                Name = "Saibra",
                SkillLevel = 60,
                PercentageCut = 30,
            };

            LockSpecialist clara = new LockSpecialist()
            {
                Name = "Clara Oswald",
                SkillLevel = 75,
                PercentageCut = 45,
            };

            Muscle danny = new Muscle()
            {
                Name = "Danny Pink",
                SkillLevel = 65,
                PercentageCut = 25,
            };

            Muscle teller = new Muscle()
            {
                Name = "The Teller",
                SkillLevel = 85,
                PercentageCut = 47,
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
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    Console.WriteLine(@"Your survival depends on following my instructions. All the information you need is in this case. The Bank of Karabraxos is impregnable. The Bank of Karabraxos has never been breached. You will rob the Bank of Karabraxos.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    return;
                }
                else
                {
                    Console.WriteLine("What do they spcialize in?");
                    Console.Write(@"
                    [1] Hacker (Disables alarms)
                    [2] Muscle (Disarms guards)
                    [3] Lock Specialist (Cracks vault): ");
                    // parse the string entered into an integer for the program
                    int Speciality = Int32.Parse(Console.ReadLine());

                    /*Once the user has selected a specialty, prompt them to enter the crew member's skill level as an integer between 1 and 100. 
                    Then prompt the user to enter the percentage cut the crew member demands for each mission. Once the user has entered the crew member's name, specialty, skill level, and cut, 
                    you should instantiate the appropriate class for that crew member (based on their specialty) and they should be added to the rolodex.*/
                    Console.Write($"What's {name} skill level (1-100): ");
                    int skill = Int32.Parse(Console.ReadLine());

                    Console.Write($"What will {name} cut be? (1-100): ");
                    int cut = Int32.Parse(Console.ReadLine());

                    if (Speciality == 1)
                    {
                        Hacker hacker = new Hacker()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut,
                        };
                        rolodex.Add(hacker);
                    }
                    else if (Speciality == 2)
                    {
                        Muscle muscle = new Muscle()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut,
                        };
                        rolodex.Add(muscle);
                    }
                    else if (Speciality == 3)
                    {
                        LockSpecialist lockSpecialist = new LockSpecialist()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut,
                        };
                        rolodex.Add(lockSpecialist);
                    }
                    else
                    {
                        Console.WriteLine("You will rob the Bank of Karabraxos.");
                        return;
                    }
                    BuildYourCrew();
                }
            }

            /*Once the user is finished with their rolodex, it's time to begin a new heist
              The program should create a new bank object and randomly assign values for these properties:
              AlarmScore (between 0 and 100)
              VaultScore (between 0 and 100)
              SecurityGuardScore (between 0 and 100)
              CashOnHand (between 50,000 and 1 million)*/
            Bank bank = new Bank()
            {
                AlarmScore = new Random().Next(50000, 10000001),
                VaultScore = new Random().Next(1, 101),
                SecurityGuardSccore = new Random().Next(1, 101),
                CashOnHand = new Random().Next(1, 101),
            };

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("The Bank is as Follows: ");

            /*Let's do a little recon next. Print out a Recon Report to the user.
             This should tell the user what the bank's most secure system is, and what its least secure system is 
             (don't print the actual integer scores--just the name, i.e. Most Secure: Alarm Least Secure: Vault*/
            Recon();
            void Recon()
            {
                if (bank.AlarmScore > bank.VaultScore && bank.AlarmScore > bank.SecurityGuardSccore)
                {
                    if (bank.VaultScore > bank.SecurityGuardSccore)
                    {
                        Console.WriteLine("Most Secure: Alarm || Least Secure: Security Guard");
                    }
                    else
                    {
                        Console.WriteLine("Most Secure Alarm || Least Secure: Vault");
                    }
                }
                else if (bank.VaultScore > bank.AlarmScore && bank.VaultScore > bank.SecurityGuardSccore)
                {
                    if (bank.AlarmScore > bank.SecurityGuardSccore)
                    {
                        Console.WriteLine("Most Secure: Vault || Least Secure: Security Guard");
                    }
                    else
                    {
                        Console.WriteLine("Most Secure: Vault || Least Secure: Alarm");
                    }
                }
                else
                {
                    if (bank.VaultScore > bank.AlarmScore)
                    {
                        Console.WriteLine("Most Secure: Security Guard || Least Secure: Alarm");
                    }
                    else
                    {
                        Console.WriteLine("Most Secure: Security Guard || Least Secure: Vault");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------");
            }

            /*Print out a report of the rolodex that includes each person's name, specialty, skill level, and cut. 
            Include an index in the report for each operative so that the user can select them by that index in the next step. 
            (You may want to update the IRobber interface and/or the implementing classes to be able to print out the specialty)*/
            Console.WriteLine("This is your crew:");
            Console.WriteLine("-----------------------------------------------------------");
            
            /*Create a new List<IRobber> and store it in a variable called crew. 
            Prompt the user to enter the index of the operative they'd like to include in the heist. 
            Once the user selects an operative, add them to the crew list.*/
            List<IRobber> crew = new List<IRobber>();

            foreach (IRobber robber in crew)
            {
                Console.WriteLine($@"
                Name: {robber.Name}
                Speciality: {robber.Speciality}
                Skill Level: {robber.SkillLevel}
                Cut: {robber.PercentageCut}
             ");
            }
        }
    }
}
