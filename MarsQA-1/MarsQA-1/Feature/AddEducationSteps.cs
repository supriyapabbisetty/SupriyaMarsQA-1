using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddEducationSteps
    {
        [Given(@"i able to add Education to the profile")]
        public void GivenIAbleToAddEducationToTheProfile()
        {
            AddProfileEducation.AddEducation();
        }
        
        [Given(@"the seller not able to add Education")]
        public void GivenTheSellerNotAbleToAddEducation()
        {
            AddProfileEducation.AddEducationtovalidate();
        }
    }
}
