Feature:  Add Certifications
	As a Seller
	I want the feature to add a Certifications  to my profile
	so that 
	People looking for Certifications can look into my details
	Acceptance Criteria
	Seller is able to add the Certifications


@mytag
Scenario: 01 Test Add certifications
Given The seller was able to add certifications to the profile

	
@mytag
Scenario: 02 Test update certifications successful
Given The seller was able update certification details

@mytag
Scenario: 03 Test delete certifications successful
Given The seller was able delete certifications
	
	

	
	@ignore @web
Scenario:  Test Add certifications successfully	
	Given The seller should able to enter all fields in certifications
	And  the seller should enter in Certificate or Award,certified From,select "Year"from the dropdown list
	When Click on "Add New"action button
	Then seller able to see certifications added successful message on the right hand side corner
	
	@ignore @web
Scenario:  Test Add certifications unsuccessful	
	Given The seller should not enter few fields in certifications
	And  the seller should enter in Certificate or Award,certified From, seller not selected "Year"from the dropdown list
	When Click on "Add New"action button
	Then seller able to see error message"please enter the certificate,certificate From,Year"on the right hand side corner
	
	@ignore @web
Scenario:  Test Adding same certifications successfully	
	Given The seller should able to enter all fields in certifications
	And  the seller  entered the same Certificate or Award,certified From,select "Year"from the dropdown list
	When Click on "Add New"action button
	Then seller able to see certifications added successful message on the right hand side corner

	