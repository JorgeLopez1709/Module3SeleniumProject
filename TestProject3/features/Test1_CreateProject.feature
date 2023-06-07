Feature: Test 1 Create Project
  As a user
  I want to create a new project
  So that I can manage my tasks effectively

  Scenario: Create a new project
    Given I am logged in TodoIst
    When I click on the Add New Project button
    And I enter a valid project name
    And I click the Save button
    Then I should see the new project name displayed


