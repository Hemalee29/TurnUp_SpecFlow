Feature: TurnUp


	#Gherkin--> Gherkin Parser
Scenario: Create an Employee
 
# you have condition
Given I login into the Turnup portal

# you perform an action
When I  click the "Employee" under Drop on the main page

# Verfication for the action
Then I verify that I am on the Employee Page 