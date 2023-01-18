Feature: Register for Demoqa.com website
    As a new user, I want to be able to register for the website so that I can create an account

    Scenario: Successful registration
        Given I am on the registration page 
        When I enter my first name, last name, username, password, and check the "I am not a robot" captcha
        And I click the register button
        Then I should be redirected to the homepage
        And I should see an alert message displayed with the following "User Register Successfully." with the title "demoqa.com"
        And I should redirect to the registration page
