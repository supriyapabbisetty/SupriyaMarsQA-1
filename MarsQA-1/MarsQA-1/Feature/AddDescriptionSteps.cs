using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddDescriptionSteps
    {
        [Given(@"i able to add Description to my profile")]
        public void GivenIAbleToAddDescriptionToMyProfile()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileDescription.AddDescription();
        }
        
        [Given(@"seller not able to enter the Description successfully")]
        public void GivenSellerNotAbleToEnterTheDescriptionSuccessfully()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileDescription.AddDescriptionnotsuccessfull();

        }
    }
}
