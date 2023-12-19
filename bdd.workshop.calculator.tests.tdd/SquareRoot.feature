Feature: SquareRoot
	As Alice (the customer)
	I want to calculate the square root
	So I can save my time


Scenario: calculate square root
	Given the number to calculate is 16
	When the square root is taken
	Then the result will be 4

Scenario: calculate square root zero
	Given the number to calculate is 0
	When the square root is taken
	Then the result will be 0

Scenario: calculate square root one
	Given the number to calculate is 1
	When the square root is taken
	Then the result will be 1