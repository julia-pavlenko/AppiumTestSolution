Feature: Login

@smoke
Scenario: Positive login
	Given I launch the application
	And I skip the welcome splash screen
	Then I see the Schedule screen
	When I click the Login item in Left menu
	Then I see the user Login screen 
	When I enter the username and password
	| Username      | Password |
	| test@test.com | pas123   |
	And click to the Login button 
	Then I see the Schedule screen
