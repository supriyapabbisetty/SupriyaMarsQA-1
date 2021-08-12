using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddCertificationsSteps
    {
        [Given(@"The seller was able to add certifications to the profile")]
        public void GivenTheSellerWasAbleToAddCertificationsToTheProfile()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileCertifications.AddCertification();

        }

        [Given(@"The seller was able update certification details")]
        public void GivenTheSellerWasAbleUpdateCertificationDetails()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileCertifications.UpdateCertification();

        }

        [Given(@"The seller was able delete certifications")]
        public void GivenTheSellerWasAbleDeleteCertifications()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileCertifications.DeleteCertification();

        }
    }
}
