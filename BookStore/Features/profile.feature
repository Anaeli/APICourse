Feature: View my Profile section in https://demoqa.com/books website
    As a user, I want to be able to access to my profile to visualize my books collection and to be able to delete my account.

    Scenario: Successful profile access
        Given I am in the books page https://demoqa.com/books
        And I am not authenticated
        When I click on the "Profile" option of the menu list at the left of the screen
        Then I am redirected to the profile page https://demoqa.com/profile
        And I access to my profile visualizing a table with my books collection
        And the following buttons below the table: "Go To Book Store", "Delete Account" and "Delete All Books"

    Scenario: Failed profile access
        Given I am in the books page https://demoqa.com/books
        And I am already authenticated
        When I click on the "Profile" option of the menu list at the left of the screen
        Then I am redirected to the profile page https://demoqa.com/profile
        And the following message is displayed "Currently you are not logged into the Book Store application, please visit the login page to enter or register page to register yourself."

