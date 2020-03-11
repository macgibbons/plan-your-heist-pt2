using System;
namespace plan_your_heist_pt2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill (Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine ($"{Name} is hacking the alarm. Decreased Alarm Score by {SkillLevel} points");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine ($"{Name} has disabled the alarm.");

            }
        }
    }
}