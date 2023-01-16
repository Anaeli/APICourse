# Feature: Online Book Store
As a user, I want to be able to browse a list of books and add them to my collection.<br>
When I click on a book from the list, I want to be able to view its details and add it to my collection.<br>
And, I want to be able to view my collection of books in my profile.<br>

## Scenario: View book list
**Given** I am on the homepage of the online book store<br>
**When** I navigate to the books section<br>
**Then** I should see a list of books.<br>

## Scenario: View book details
**Given** I am on the homepage of the online book store<br>
**And** I navigate to the books section<br>
**When** I click on a book from the list<br>
**Then** I should be able to see the book's ID, title, subtitle, author, publisher, total pages, description, and website.<br>
**And** there should be a button to go back to the book list.<br>
**And** a button to add the book to my collection.<br>

## Scenario: Add book to collection
**Given** I am on the homepage of the online book store<br>
**And** I navigate to the books section<br>
**And** I click on a book from the list<br>
**When** I click on the "Add to Collection" button<br>
**Then** the selected book should be added to my collection.<br>

## Scenario: View my collection
**Given** I am on the homepage of the online book store<br>
**And** I navigate to my profile<br>
**Then** I should see a list of books in my collection.<br>

## Scenario: Search for a book
**Given** I am on the homepage of the online book store<br>
**And** I navigate to the books section<br>
**When** I search for a book using a keyword<br>
**Then** I should see a list of books that match the keyword.<br>

## Scenario: Filter books by author
**Given** I am on the homepage of the online book store<br>
**And** I navigate to the books section<br>
**When** I filter books by author<br>
**Then** I should see a list of books written by the selected author.<br>

## Scenario: Sort books by publisher
**Given** I am on the homepage of the online book store<br>
**And** I navigate to the books section<br>
**When** I sort books by publisher<br>
**Then** I should see a list of books sorted by publisher name in ascending order.<br>
<br>

# Feature: Register & Login
As a user, I want to be able to login to my account and see my collection.<br>
When I enter my login and my password, I want to be able to login into my account.<br>
And, I want to be able to view the books from my collection.<br>

## Scenario: View registration page
**Given** a customer wants to create a new account on the online book store<br>
**When** the customer clicks the "new user" button on the login page<br>
**Then** the customer should be directed to a registration page<br>
**And** the registration page should have form fields for first name, last name, nickname, password and a checkbox to confirm they are not a robot<br>
**And** a "register" button.<br>

## Scenario: Create a new account
**Given** a customer has entered all the required information on the registration page<br>
**When** the customer clicks the "register" button<br>
**Then** the customer's account should be created<br>
**And** the customer should be logged in to the online book store.<br>

## Scenario: Login to existing account
**Given** a customer wants to login to their existing account on the online book store<br>
**When** the customer enters their login and password on the login page<br>
**And** clicks the "login" button<br>
**Then** the customer should be logged in to the online book store.<br>

## Scenario: Incorrect password
**Given** a customer has entered an incorrect login and/or password<br>
**When** the customer clicks the "login" button<br>
**Then** an error message should be displayed, indicating that the login information is incorrect.<br>
