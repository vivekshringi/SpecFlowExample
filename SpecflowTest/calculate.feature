Feature: Calculate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two number


Background: I would like to check 
Given Some precondition can be covered in background


@single
Scenario: Adding two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@single
Scenario: Deduct two numbers 
	Given I have entered 70 into the calculator
	And I have also entered 30 into the calculator
	When I press deduct
	Then the result should be 40 on the screen

@multiple
Scenario Outline: Add Multiple Adds
Given I have entered <firstNo> into the calculator
And I have also entered <Second> into the calculator
When I press add
Then the result should be <Result> on the screen

Examples: 
| firstNo | Second | Result |
|    20   | 10   |  30      |
|    30   | 30   |  60      |


@single
Scenario: Multipling two values 
Given I have entered 40 into the calculator
And I have also entered 10 into the calculator
When I press multiple
Then the result should be 400 on the screen


@single
Scenario: Divide two values 
Given I have entered 40 into the calculator
And I have also entered 10 into the calculator
When I press divide
Then the result should be 4 on the screen


@single
Scenario: Mod test
Given I have entered 34 into the calculator
And I have also entered 10 into the calculator
When I press mod
Then the result should be 4 on the screen

@random
Scenario: Random No. generator 
Given I entered min value as 1 into the calculator
And I also entered max value as 10 into the calculator
When I press generate random number
Then the result should be between 1 and 10


@single
Scenario: Power Test 
Given I have entered 2 into the calculator
And I have also entered 10 into the calculator
When I press power
Then the result should be 1024 on the screen

