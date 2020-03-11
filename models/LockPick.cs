using System;
namespace plan_your_heist_pt2
{
    public class LockPick : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill (Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine ($"{Name} is picking the lock. Decreased Vault Strength by {SkillLevel} points");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine ($"{Name} has opened the vault");

            }
        }

    }
}