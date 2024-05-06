Feature: RegScenarioPortal

A short summary of the feature

@tag1
Scenario: PMSE Registration Portal
	Given I navigate to TpPortal at @"https://tpportal-qa.intranet.pajak.go.id"
	And   I click on New Registration
	Then  I will check if am on RegPage titled "Registration Portal"
	Then  Set Step 2
	And   I click on And I click on Foreign eCommerce VAT Collector
	Then  Set Step 3
	Then  on Representive Tab I click on the Next Button
	Then  Set Step 4
	Then  on Taxpayer Identity Tab I enter Company Name as "Pt. ABC Company"
	Then  Taxpayer Identity Tab I click on the Next Button
	Then  Set Step 5
	Then  on Contact Detail Tab I enter email address as "hardeepdive@gmail.com"
	Then  I will click Verify 
	And   I will enter OTP "1234"
	Then  I will click OTP Verify 