using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddSkillsSteps
    {
        [Given(@"I able to add skills to the profile")]
        public void GivenIAbleToAddSkillsToTheProfile()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileSkills.Addskills();
        }
        
        [Given(@"i was able to update skills successfully")]
        public void GivenIWasAbleToUpdateSkillsSuccessfully()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileSkills.Updateskills();

        }

        [Given(@"i was able to delete the skill")]
        public void GivenIWasAbleToDeleteTheSkill()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileSkills.Deleteskill();

        }
    }
}
