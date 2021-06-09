using System;

namespace HeistPartII
{
    // Let's create a Bank class to represent the security we're up against. Give the Bank class the following properties:
    public interface Bank 
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; } 
        public int VaultScore { get; set; }
        public int SecurtityGuardSccore { get; set; }
        // A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true
        public bool IsSecure
        {
            get
            {
                if (CashOnHand <= 0 && VaultScore <= 0 && SecurtityGuardSccore <= 0)
                {
                    return false;
                }
                else
                {
                    return true; 
                }
            }
        }
    }
}