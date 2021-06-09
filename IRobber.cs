using System;

namespace HeistPartII
{
    // Each type of robber will have a special skill that will come in handy while knocking over banks. Start by creating an interface called IRobber.
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        // A method called PerformSkill that takes in a Bank parameter and doesn't return anything.
        void PerformSkill(Bank bank);
    }
}