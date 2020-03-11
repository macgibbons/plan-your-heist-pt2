// Each type of robber will have a special skill that will come in handy while knocking over banks. Start by creating an interface called IRobber. The interface should include:

// A string property for Name
// An integer property for SkillLevel
// An integer property for PercentageCut
// A method called PerformSkill that takes in a Bank parameter and doesn't return anything.
namespace plan_your_heist_pt2
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill (Bank bank);

    }
}