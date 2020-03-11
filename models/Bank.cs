// Give the Bank class the following properties:

// An integer property for CashOnHand
// An integer property for AlarmScore
// An integer property for VaultScore
// An integer property for SecurityGuardScore
// A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true
namespace plan_your_heist_pt2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool isSecure
        {
            get
            {
                if (AlarmScore <= 0 && AlarmScore <= 0 && VaultScore <= 0)
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