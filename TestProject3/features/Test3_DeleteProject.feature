Feature: Test 3 Delete Project
  As a user
  I want to delete an existing project
  So that I can remove it from my projects list

  Scenario: Delete project
    Given I am logged in TodoIst
    When I click on the project to be Deleted
    And I click on the Delete button
    And I confirm the deletion
    Then I should not see the Deleted project 
