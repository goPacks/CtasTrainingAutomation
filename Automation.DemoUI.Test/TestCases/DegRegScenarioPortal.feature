Feature: DegRegScenarioPortal

A short summary of the feature

@tag1
Scenario: Taxpayer De-registration Portal
	Given I navigate to TpPortal at @"https://tpportal-qa.intranet.pajak.go.id"
	When  I will check if am on page titled "CATS"
	Then  I enter "3301111512840002" as TIN and "1q2w3e4r5t" as Password
	And   I manually enter Captcha
	And   I press Login Button
	Then  I will check if am on page titled "Home"