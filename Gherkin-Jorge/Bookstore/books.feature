Feature: Search for a book
 As a user
 I want to search for a book with an specific name
 To show it in my front page

Scenario: Search for a book title
 Given The user is on https://demoqa.com/books
 When the user types an existing book name in the input box
 Then The page will filter the books accordingly to the one I typed

Feature: Read book description
 As a user
 I want to read the whole description of a book
 Whenever I click on it

Scenario: Go to book page
 Given The user is on https://demoqa.com/books
 When the user clicks on a book title
 Then The page will reload and take me to the book description page

Feature: Register and Login
 As a user
 I want to be able to Register
 To login afterwards

Scenario: Register
 Given The user is on https://demoqa.com/books
 When the user clicks on the Login button
 And when the page reloads I click on the New User button
 And the user fills the "First Name" input box
 And the user fills the "Last Name" input box
 And the user fills the "UserName" input box
 And the user fills the "Password" input box with a valid password
 And the user clicks on the I'm no a robot
 And validate that I'm not a robot
 And click on the "Register" button
 Then the page should show an alert thelling me that the "User Register Successfully"
 When the user clicks "Back to Login"
 And the user enters the correct email and password
 And they click on the "Login" button
 Then they should be logged in to the website


