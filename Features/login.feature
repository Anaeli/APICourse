@tagPlaceholder1 @tagPlaceholder2
Feature: Login to website
  As a user, I want to be able to login in the website so that I can access into my account.

  Scenario: Successful login 
    Given I am on the login page
     When I enter my username and password
     And I click on the login button
     Then I should be redirected to the homepage
     And I should see a label saying "User Name:" and a label saying "[username]"

