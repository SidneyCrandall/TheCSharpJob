using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------");
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
            
        }
    }
}
