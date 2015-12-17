Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have a username and password for my company
	When I go to the company login page
	And ender my credentials
	Then I should be logged in
	And my name should be presented
