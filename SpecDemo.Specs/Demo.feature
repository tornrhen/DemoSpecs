Feature: Demo
	As a math idiot
	In order to avoid silly mistakes
	I want to be told the sum of two numbers


Scenario: Add two numbers
	Given I have entered '50,70' into the calculator
	When I press add
	Then the result should be '120' on the screen

Scenario: Add zero numbers
	Given I have entered '' into the calculator
	When I press add
	Then the result should be '0' on the screen 
