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
    public static class AddProfileCertifications
    {
        public static void AddCertification()
        {
            ExcelLibHelper.PopulateInCollection(@"C:/Supriya/MarsQA-1/MarsQA-1/SpecflowTests/Data/DataCertifications.xlsx", "Certifications");

            for (int i = 2; i < 3; i++)
            {
                var certificate = ExcelLibHelper.ReadData(i, "Certificate");
                //Read Language Level from Excel
                var from = ExcelLibHelper.ReadData(i, "From");

                var year = ExcelLibHelper.ReadData(i, "Year");

                //Seller clicks on "Certifications"
                Driver.driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]")).Click();
                //Seller clicks on "AddNew"button
                Driver.driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]")).Click();
                //Seller enters data in "Certification OR Award"text field
                Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")).SendKeys(certificate);
                //Seller enters data in "Certified From"Text Field
                Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/input[1]")).SendKeys(from);
                //Seller selects the "Year"from dropdown list
                var selYear = Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]"));
                //Assign the value to Language Level
                var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(selYear);
                selectElement.SelectByText(year);

                //Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]/option[10]")).Click();
                //Seller clicks on "Add"button
                Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]")).Click();

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
                        string certificationText = lstTdElem[0].Text;
                        string certifiedfromText = lstTdElem[1].Text;
                        string yearText = lstTdElem[1].Text;
                        Assert.AreEqual("My Award", certificationText);
                        Assert.AreEqual("IBM", certifiedfromText);
                        Assert.AreEqual("2010", yearText);

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
                public static void UpdateCertification()
            {
            //seller clicks on"Certifications"
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]")).Click();
            //seller clicks on "AddNew"button
             Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[4]/span[1]/i[1]")).Click();
            //seller clears the data in both fields
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[1]/input[1]")).Clear();
            //seller enters "Java"in the "Certifications"text box
             Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[1]/input[1]")).SendKeys("Java");
            //seller enters "Oracle"in the "Certified From"text box
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[2]/input[1]")).SendKeys("Oracle");
            //seller selects "Year"from the drop down list
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[3]/select[1]/option[5]")).Click();
            //seller clicks on "Penicon"button to edit/update
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
                    string certificationText = lstTdElem[0].Text;
                    string certifiedfromText = lstTdElem[1].Text;
                    string yearText = lstTdElem[2].Text;
                    Assert.AreEqual("Java", certificationText);
                    Assert.AreEqual("Oracle", certifiedfromText);
                    Assert.AreEqual("2005", yearText);

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
            public static void DeleteCertification()
        {
            //seller clicks on "Certifications"
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]")).Click();
            //seller clicks on "Crossicon"to Delete data
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[4]/span[2]/i[1]")).Click();
            //Assertion
            Thread.Sleep(2000);
            //find xpath for sucess or failure popup message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            // assert expected result = actual result
            Assert.AreEqual("Java has been deleted from your certification", alerttext);


        }
    }
}
