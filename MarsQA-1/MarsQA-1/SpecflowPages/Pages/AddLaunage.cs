using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MarsQA_1.SpecflowPages.Pages
{
    public static class AddLaunage 
    {



        public static void AddLanguageFromExcel()
        {

            ExcelLibHelper.PopulateInCollection(@"C:/Supriya/MarsQA-1/MarsQA-1/SpecflowTests/Data/DataLaunage.xlsx", "Language");

            for (int i = 2; i < 3; i++)
            {
                //Call the driver for langaguage add for xpath finding
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
                //Read Language data from Excel 
                var launage = ExcelLibHelper.ReadData(i, "Language");
                //Read Language Level from Excel
                var level = ExcelLibHelper.ReadData(i, "Level");
                //Finding Language text field and enter data
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(launage);
                //Finding Level element from page from Excel
                var selLevel = Driver.driver.FindElement(By.Name("level"));
                //Assign the value to Language Level
                var selectElement = new SelectElement(selLevel);
                selectElement.SelectByText(level);
                //click on Add button
                Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]")).Click();
                // IAlert alert = Driver.driver.SwitchTo().Alert();
                // String alertContent = alert.Text;
                // Console.WriteLine("Text is"+ alertContent);

                //Assertion or Validate/validation/Assert
                //Find xpath for Success or Failure Message
                var popuptext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                // Assert expected result= actual result
                Assert.AreEqual("English has been added to your languages", popuptext);

                //xpath for Html table 
                var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]"));

                //Fetch all the rows of the table
                List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
                String strRowData = "";

                // Traverse each row
                foreach (var elemTr in lstTrElem)
                {
                    // Fetch the columns from a particuler row
                    List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                    if (lstTdElem.Count > 0)
                    {
                        // Traverse each column
                        foreach (var elemTd in lstTdElem)
                        {
                            // "\t\t" is used for Tab Space between two Text
                            strRowData = strRowData + elemTd.Text + "\t\t";
                            Console.WriteLine(elemTd.Text);
                        }
                        string LangText = lstTdElem[0].Text;
                        string LevelText = lstTdElem[1].Text;
                        Assert.AreEqual(launage, LangText);
                        Assert.AreEqual(level, LevelText);
                    }
                    else
                    {
                        // To print the data into the console
                        Console.WriteLine("This is Header Row");
                        Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                    }
                    Console.WriteLine(strRowData);
                    strRowData = String.Empty;




                }

            }
        }

        public static void UpdateLanguagesFromInput()
        {
            //Call the driver and click on Langaguage Add button for xpath finding
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]")).Click();

            //clear the Text Field in Language box 
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).Clear();

            //seller enters text in the Language field box to update
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).SendKeys("Spanish");

            //seller selects the Language Level from the drop down list to option 2 
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]/option[2]")).Click();

            //seller clicks on Update action button or edit
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]")).Click();
        }
        
        public static void DeleteLanguagesRecord()
        {
            //seller clicks on "Language"
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();

            //Call the driver and seller clicks on delete "crossicon"to delete the record
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[2]/i[1]")).Click();

            //Assertion
            Thread.Sleep(2000);
            //find xpath for sucess or failure popup message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            // assert expected result = actual result
            Assert.AreEqual("Spanish has been deleted from your languages", alerttext);



        }
        }

    

}
