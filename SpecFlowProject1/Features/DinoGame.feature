Feature: Feature1

A short summary of the feature

@tag1
Scenario: step tester
	When When time increments
	Then the man steps

	Scenario: step tester2
	When When time increments
	Then the man steps
	When When time increments
	Then the man stands


Scenario: Cuctus moves

	When When time increments
	Then cactus moves forward 1 cell

	@tag2
Scenario: dino hit
	Given cactus at 3,3
	When When time increments
	Then the dino is hit and dies