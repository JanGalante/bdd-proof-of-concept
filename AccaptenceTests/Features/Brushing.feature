Feature: Brushing
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
#
#@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen


Scenario: Sucessfull brushing
	Given there is 2 grams of Brand X toothpaste on the brush
		And the mouth is open
	When the backteeth are brushed
	Then the teeth look clean
		And the mouth feels fresh
		But the braces aren't damaged


Scenario: Another sucessfull brushing
	Given I have the following tools:
		| ToolName | ToolQuality |
		| paste    | medium      |
		| brush    | high        |
		| water    | low         |
		And the mouth is open
	When the backteeth are brushed
	Then the teeth look clean
		And the mouth feels fresh
		But the braces aren't damaged
		

#@ignore
Scenario Outline: Teetth whiteness
	Given I'm using <brand> brand toothpaste
	When I brush for <mins> minutes
	Then the teeth look <percent> white

	Examples: 
	| brand   | mins | percent |
	| Brand X | 1    | 80      |
	| Brand Y | 3    | 100     |
	| Brand Z | 10   | 50      |

