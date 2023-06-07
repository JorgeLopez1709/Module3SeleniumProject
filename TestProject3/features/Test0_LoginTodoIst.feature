Feature: Test 0 Login to TodoIst

A short summary of the feature

@tag1
Scenario: Login to Todoist
	Given I have the valid credentials
	When I click on login button with the filled required fields
	Then the TodoIst Main page is displayed
