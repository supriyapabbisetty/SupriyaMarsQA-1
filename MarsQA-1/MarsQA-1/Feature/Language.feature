Feature: Add  Language
	As a Seller
	I want the feature to add a Language to my profile
	so that 
	People looking for specific Language can look into my details
	Acceptance Criteria
	Seller is able to add the Lanuguage 

	
	@mytag
	Scenario: 01 Test Add language from Excel successfully
	Given The data in the Excel sheet to create Language

	@mytag
	Scenario: 02 Test add language successfully updated
	Given The seller wants to update existing language to Spanish 

	@mytag
	Scenario: 03 Test add language successfully Deleted
	Given The seller wanted to delete Spanish Language 

	@ignore @web	
Scenario:  Test Add Language from user keyed input successfully	
	Given The seller should enter the language as English
	And  the seller should select the Level from the dropdown box as "Basic"
	When Click on "Add New"action button
	Then Language should be added to your profile,then a pop up message should say "English" is added to your profile
			
     @ignore @web
    Scenario:  Test if the Language  is not entered and selected the Level from "choose the level"	
	Given The seller not entered the Language
	And  selected the language level
	When then click on "Add New"action button
	Then  it should throw an error saying "please enter language and level"on the right hand corner.
	
	 @ignore @web
	Scenario:  Test if Level from "choose the level" not entered
	Given The seller  entered the Language and not choose the Launguage Level
	And  selected the language and not choose the Language level
	When then click on "Add New"action button
	Then   it should throw an error saying "please enter language and level"on the right hand corner.
	
	 @ignore @web
	Scenario: Test the seller can add only upto 4 languages and doesn't all duplicate
	Given The seller is able to enter upto 4 languages
	And  seller choose the level of language from the drop down list
	When same Language is selected
	Then  it should throw error "Language already exists"
	