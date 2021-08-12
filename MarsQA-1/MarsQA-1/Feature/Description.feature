Feature:  Add Description
	As a Seller
	I want the feature to add a Description  to my profile
	so that 
	People looking for Description can look into my details
	Acceptance Criteria
	Seller is able to add the Description


@mytag
Scenario: 01 Test Add Description 
Given seller able to add Description to my profile

@mytag
Scenario: 02 Test Add Description unsuccessful
Given seller not able to save the Description successfully	
	
	@ignore @web
	Scenario:  Test Description can accept upto 600 characters	
	Given The seller able to enter Description by clicking on "pen"icon
	And  the seller able to enter upto 600 characters 
	When Click on "Save" button
	Then seller able to see "Description added successful" message on the right hand side corner
	
	