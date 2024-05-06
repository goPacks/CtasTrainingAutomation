Feature: TRP

Test TRP Readiness 

@tag1
Scenario: Create Output eTaxInvoice
	Given I navigate to TpPortal at @"https://tpportal-qa.intranet.pajak.go.id"
	Given I am on page titled "CATS"
	Then  I will enter "3301111512840002" as TIN and "1q2w3e4r5t" as Password
	And   I manually enter Captcha
	And   I will click on Login Button
	Given I am on page titled "Home"
	Then  I will click on "eTax Invoice" menu
	Given I am on page titled "E-Invoice Portal" 
	Then  I will click on Output Tax menu
	Given I am on page titled "Output Tax" 
	Then  I will click on Create Output Invoice button