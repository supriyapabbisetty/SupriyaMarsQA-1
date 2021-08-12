using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddLanguageSteps
    {
        [Given(@"The data in the Excel sheet to create Language")]
        public void GivenTheDataInTheExcelSheetToCreateLanguage()
        {
            SpecflowPages.Pages.AddLaunage.AddLanguageFromExcel();
        }
        
        [Given(@"The seller wants to update existing language to Spanish")]
        public void GivenTheSellerWantsToUpdateExistingLanguageToSpanish()
        {
            SpecflowPages.Pages.AddLaunage.UpdateLanguagesFromInput();

        }

        [Given(@"The seller wanted to delete Spanish Language")]
        public void GivenTheSellerWantedToDeleteSpanishLanguage()
        {
            SpecflowPages.Pages.AddLaunage.DeleteLanguagesRecord();

        }
    }
}
