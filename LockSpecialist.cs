using System;

namespace HeistPartII
{
    /*Since bank security consists of alarms, vaults, and security guards; we'll need crew members that can deal with each of them. 
    We'll need hacker to take care of the alarms; lock pick specialists to crack the vaults, and some good old fashion muscle to handle the security guards. 
    Create three classes: Hacker, Muscle, and LockSpecialist. They should all implement the IRobber interface. */
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        // Each implementation for PerformSkill should do three things:
        public void PerformSkill(Bank bank)
        {
            //Take the Bank parameter and decrement its appropriate security score by the SkillLevel. i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
            int LockPicker = bank.AlarmScore - SkillLevel;
            // Print to the console the name of the robber and what action they are performing. i.e. "Mr. Pink is hacking the alarm system. Decreased security 50 points"
            Console.WriteLine($"{Name} is picking lock. Decreased security by {SkillLevel}.");
            // If the appropriate security score has be reduced to 0 or below, print a message to the console, i.e. "Mr Pink has disabled the alarm system!"
            if (LockPicker <= 0)
            {
                Console.WriteLine($"{Name} cracked open the safe!");
            }
        }
    }
}