Feature:  Add Skills
	As a Seller
	I want the feature to add Skills to my profile
	so that 
	People looking for specific Skills can look into my details
	Acceptance Criteria
	Seller is able to add the  Skills

	@mytag
	Scenario: 01 Test Add Skills
	Given I able to add skills to the profile
	
	@mytag
	Scenario: 02 Test Update Skills
	Given i was able to update skills successfully
	

	@mytag
	Scenario: 03 Test delete Skills
	Given i was able to delete the skill


	@ignore @web
   Scenario: Test check if  Skills duplicate accepted
  Given the seller adds same skills 
  And click on the "Add New"enter skill and enter "choose skill level" from the drop down list as "Beginner"
  When click on "Add New"
  Then it should throw error "Duplicated Data"

@ignore @web
Scenario:  Test Add Skills and not selected  Skill Level
Given seller enterd the skill 
And seller not selected the "Skill Level"from the drop down box
When seller clicked on "Add"button
Then it should throw an error "Please enter the skill and level"on the right hand corner

@ignore @web
Scenario:  Test not adding Skills and selected  Skill Level
Given seller  not enterd the skill 
And seller selected the "Skill Level"from the drop down box as "Beginner"
When seller clicked on "Add"button
Then it should throw an error "Please enter the skill and level"on the right hand corner

	
	
	
