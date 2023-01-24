@acceptance
@items
Feature: CreateNewItem

Validate that a new item is created using POST method for JSON format.

Background:
	Given the user is authenticated

Scenario: Create new item with required information
	When the user send POST request to "items.json"
		And the user write in the body with item information
		"""
		{
			"Content": "Item by API"
		}
		"""
		And the user send the request
	Then the user should see that the request has been successfully completed
		And the user should see the correct response with Item information
	When the user send GET request to "items/[item_id].json" with ItemID
		And the user send the request
	Then the user should see that the request has been successfully completed
		And the user should see the correct response with Item information