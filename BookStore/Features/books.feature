Feature: Book Store in https://demoqa.com website
    As an authenticated user, I want to be able to visualize a list of books, access to their details and add them to my collection.

    Scenario: Visualize Book List
        Given I am on the home page https://demoqa.com/
        And I am already authenticated
        When I click on the "Book Store Application" option
        Then I am redirected to the books page https://demoqa.com/books
        And I am able to visualize a table with four columns with the following titles "Image", "Title", "Author", "Publisher"
        And search input above the table 
        And a "Login" button to the right of the search input

    Scenario: Access to a book details
        Given I am on the books page https://demoqa.com/books
        When I click on any of the books titles from the book list
        Then I am redirected to the book id page
        And I am able to see the book's ISBN, Title, Sub Title, AAuthor, Publisher, Total Pages, Description, Website
        And a "Back To Book Store" button to come back to the book page below the details
        And a "Add To Your Collection" button to add the book to my collection below the details
        And a "Log out" button to log out above the details

    Scenario: Add a specific book to my collection
        Given I am on the books page https://demoqa.com/books
        And I click on the book title that I want to add to my collection
        And I am redirected to the book id page
        When I click on the "Add To Your Collection" button
        Then a "Book added to your collection." alert message is displayed with the following title "demoqa.com"
        And with a button with the following label "Aceptar"
        And the book is added to my collection list on my Profile section



   