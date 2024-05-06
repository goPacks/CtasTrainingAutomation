Feature: PMT

A short summary of the feature

@tag1 
Scenario: Balance Transfer Request
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	When  I will check if am on Core page titled "DJP Connect | Login"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	And   I press Login Button
	Then  I will check if am on core page titled "Home"  
	When  I click on Menu label "Payment"
	When  I click on SubMenu label "Balance Transfer Request"
	Then  I will check if am on core payment page   
	And   I click on Create New Balance Transfer Request menu
	And   I enter new request "CL009871" on  New Balance Transfer Request Details Form

@tag2
Scenario: Automatic Balance Transfer from Tax Arrears
	Given I navigate to TpPortal at @"https://tpportal-mtra.intranet.pajak.go.id"
	Given I am on page titled "CATS"
	Then  I will enter "1091031210910452" as TIN and "VOTAqg2zRCX5hQxK" as Password
	And   I will click on Login Button
	Given I am on page titled "Home"
	Then  I will click on "Payment" menu
	When  I click on SubMenu label "Tax Arrears Billing Code"
	Then  I will AutoTransfer on Portal Payment Page
	
@tag3
    Scenario:Self Service Billing Code Creation
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	When  I will check if am on Core page titled "DJP Connect | Login"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	And   I press Login Button
	Then  I will check if am on core page titled "Home"  
	When  I click on Menu label "Payment"
	When  I click on SubMenu label "Self-Service Billing Code Creation"
	Then  I will check if am on core payment page  
	Then  I will perform Self Service Billing with "0729150458413000" on Core Payment page  
