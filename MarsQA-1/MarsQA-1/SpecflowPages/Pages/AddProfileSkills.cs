using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class AddProfileSkills
    {

        public static void Addskills()
        {


            ExcelLibHelper.PopulateInCollection(@"C:/Supriya/MarsQA-1/MarsQA-1/SpecflowTests/Data/DataSkills.xlsx", "Skills");

            for (int i = 2; i < 3; i++)
            {

                //Seller clicks on the Skills Tab
                Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
                //seller clicks on "AddNew"
                Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]")).Click();
                var skill = ExcelLibHelper.ReadData(i, "Skill");
                //Read Language Level from Excel
                var level = ExcelLibHelper.ReadData(i, "Level");

                //seller enters text in "Addskill"Selenium in textbox
                Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]")).SendKeys(skill);
                var selLevel = Driver.driver.FindElement(By.Name("level"));
                //Assign the value to Language Level
                var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(selLevel);
                selectElement.SelectByText(level);

                //seller selects from "Choose skill Level"from the dropdown list as opiton 2
                //Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]/option[2]")).Click();
                //sellers clicks on "Add"button
                Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]")).Click();


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
                        string skillText = lstTdElem[0].Text;
                        string LevelText = lstTdElem[1].Text;
                        Assert.AreEqual("Selenium", skillText);
                        Assert.AreEqual("Beginner", LevelText);
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
        public static void Updateskills()
        {
            //Seller clicks on "Skils"
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
            //seller clicks on "AddNew"
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]")).Click();
            //seller clears both the Fields "Add skills"and"Choose skill Level"to UpdateSkills
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).Clear();
            //seller enters text as "Spcflow"in the "AddNew"text field box
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).SendKeys("Specflow");
            //seller selects the "Choose Skill Level"form the dropdown box to option3
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]/option[3]")).Click();
            //seller clicks on"Add"button
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]")).Click();
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
                    string skillText = lstTdElem[0].Text;
                    string LevelText = lstTdElem[1].Text;
                    Assert.AreEqual("Specflow", skillText);
                    Assert.AreEqual("Intermediate", LevelText);
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
            public static void Deleteskill()
        {
        //seller clicks "Skill"
        Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
        //seller clicks on "Crossicon"to Delete data
        Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[2]/i[1]")).Click();
            //Assertion
            Thread.Sleep(2000);
            //find xpath for sucess or failure popup message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            // assert expected result = actual result
            Assert.AreEqual("Specflow has been deleted", alerttext);



        }

    }
}
