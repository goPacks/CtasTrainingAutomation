Feature: Name

A short summary of the feature

@tag1
Scenario: AUD - Test Generic Template Happy Path
	Given I navigate to "https://www.saucedemo.com/"
	Then Set Step 1
	Then Set Step 2
	Given I am on page titled "Swag Labs" 
	Then I will move to element
	
#
#@tag2
#Scenario: TRP - Test Generic Template Not Happy Path
#	Given I navigate to "https://www.saucedemo.com/"
#	Then Set Step 1
#	Then Set Step 2
#	When I am on page titled "Swag Labs123" 
#	Then Set Step 3
	