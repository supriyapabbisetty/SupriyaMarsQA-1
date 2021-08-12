Feature: Add Education
As a Seller
	I want the feature to add Education to my profile
	so that 
	People looking for Education can look into my details
	Acceptance Criteria
	Seller is able to add the Education


@mytag
Scenario:  01  Test Add Education
Given i able to add Education to the profile
	
@mytag
Scenario:  02 Test Add Education unsuccessful
Given the seller not able to add Education


	
	
	@ignore @web
	Scenario:  Test Adding same record successful
	Given the seller  able to add Education of the same record previsoly entered
	And click on the "Add New"enter Country,"University" from the drop down list selected,"Title"from the drop down list selected,Degree enterd,graduation Year"from the drop down list  selected
	When click on "Add New"
	Then seller able to see message "The information already existing" displayed on the right hand corner
	
	@ignore @web
	Scenario:  Test to update Education
	Given the seller  able to update Education 
	And click on the "Add New"enter Country,"University" from the drop down list selected,"Title"from the drop down list selected,Degree enterd,graduation Year"from the drop down list  selected
	When click on "Update"
	Then seller able to see message "Education has been Updated" displayed on the right hand corner
	

	
