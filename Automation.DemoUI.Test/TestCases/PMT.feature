Feature: PMT

A short summary of the feature

@PaymentPortal
Scenario: Automatic Balance Transfer from Tax Arrears
	Given I navigate to TpPortal at @"https://tpportal-mtra.intranet.pajak.go.id"
	When  I am on page titled "CATS"
	Then  I will enter "1091031210910452" as TIN and "VOTAqg2zRCX5hQxK" as Password
	And   I will click on Login Button
	When  I am on page titled "Home"
	When  I click on Portal Home Menu label "Payment" 
	When  I click on Portal Home SubMenu label "Tax Arrears Billing Code"
	Then  I will AutoTransfer on Portal Payment Page

	
@PaymentCore
Scenario: Balance Transfer Request
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	When  I am on page titled "DJP Connect | Login"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Payment"
	Then  I click on Core Home SubMenu label "Balance Transfer Request"
	When  I am on page titled "Payment"
	Then  I click on Create New Balance Transfer Request menu
	Then  I enter new request "CL009871" on  New Balance Transfer Request Details Form


	
@PaymentCore
    Scenario:Self Service Billing Code Creation
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	When  I am on page titled "DJP Connect | Login"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	And   I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Payment"
	Then  I click on Core Home SubMenu label "Self-Service Billing Code Creation"
	When  I am on page titled "Payment"
	Then  I will perform Self Service Billing with "0729150458413000" on Core Payment page  
