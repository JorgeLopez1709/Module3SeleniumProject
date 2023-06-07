Feature: test 2 Update Project
  As a user
  I want to update an existing project
  So that I can modify its details

  Scenario: Update project name
    Given I am logged in TodoIst
    When I select the project to be updated
    And I update the project name
    And I click the Save button
    Then I should see the updated project name 
