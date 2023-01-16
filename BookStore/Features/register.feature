Feature: Register in https://demoqa.com/ website
    As a new user, I want to be able to create a new account to be registered in the website, being able to add and remove books from my collection, 

    Scenario: Successful registration
        Given I am in the register page https://demoqa.com/register
        When I fill the inputs "First Name", "Last Name", "Username" and "Password" with valid information
        And I check on the "I am not a robot" captcha
        And I click on the "Register" button
        Then a "User Register Successfully." alert message is displayed with the following title "demoqa.com"
        And with a button with the following label "Aceptar"

    Scenario: Failed registration because of invalid password
        Given I am in the register page https://demoqa.com/register
        When I fill the inputs "First Name", "Last Name", "Username" with valid information
        And "Password" with invalid information # e.g. None uppercase, or none lowercase, or none digits, or less than eight characters
        And I check on the "I am not a robot" captcha
        And I click on the "Register" button
        Then a red error validation message appears below the "Register" button with the following message: "Passwords must have at least one non alphanumeric character, one digit ('0'-'9'), one uppercase ('A'-'Z'), one lowercase ('a'-'z'), one special character and Password must be eight characters or longer."

    Scenario: Failed registration because of missing information
        Given I am in the register page https://demoqa.com/register
        When I click on the "Register" button
        Then the border colors of "First Name", "Last Name", "UserName" and "Password" inputs become red
        And warning icons appear inside at the end of the inputs