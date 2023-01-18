@https://demoqa.com/ @book_shop
Feature: Books API
  As a user, I want to be able to create and retrieve a list of books
  so that I can manage my bookstore.
  Scenario: Create a new book
    Given I am an authenticated user
    When I send a PUT request to the "/books" endpoint with the following data:
        | isbn | title  | subTitle |   author   |       publish_date       | publisher | pages | description |   website   |
        | 1kd2 | Ponies | Fantasy  |   Pepito   | 2023-01-12T23:24:30.331Z |  Oceano   |  50   |   Cuentos   | example.com |
    Then I should receive a 201 response with the created book's isbn

  Scenario: Retrieve a list of books
    Given I am an authenticated user
    When I send a GET request to the "/books" endpoint
    Then I should receive a 200 response with a list of all of my books

  Scenario: Retrieve a specific book
    Given I am an authenticated user
    When I send a GET request to the "/books/{isbn}" endpoint with the isbn of a book I have created
    Then I should receive a 200 response with the details of that specific book

