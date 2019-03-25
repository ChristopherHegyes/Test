Feature: Website tests
	

Scenario Outline: REQ-UI-01
	Given I have opened '<page>'
	Then the Title should be '<title>'

	Examples: 
	  | page                                     | title           |
	  | http://uitest.duodecadits.com/           | UI Testing Site |
	  | http://uitest.duodecadits.com/form.html  | UI Testing Site |
	  | http://uitest.duodecadits.com/hello.html | UI Testing Site |
	  | http://uitest.duodecadits.com/error      | UI Testing Site |


Scenario Outline: REQ-UI-02
	Given I have opened '<page>'
	Then the logo_src should be <logo_src>

	Examples: 
	| page                                     | logo_src                                    |
	| http://uitest.duodecadits.com/           | assets/img/dh_company_lux_doclerholding.jpg |
	| http://uitest.duodecadits.com/form.html  | assets/img/dh_company_lux_doclerholding.jpg |
	| http://uitest.duodecadits.com/hello.html | assets/img/dh_company_lux_doclerholding.jpg |
	| http://uitest.duodecadits.com/error      | assets/img/dh_company_lux_doclerholding.jpg |


Scenario Outline: REQ-UI-03
	Given I have opened '<page>'
	When I click on the Home button 
	Then I should get navigated to http://uitest.duodecadits.com/

	Examples: 
	| page                                    |
	| http://uitest.duodecadits.com/          |
	| http://uitest.duodecadits.com/form.html |


Scenario Outline: REQ-UI-04
	Given I have opened '<page>'
	When I click on the Home button 
	Then Home button should turn to active status

	Examples: 
	| page                                    |
	| http://uitest.duodecadits.com/          |
	| http://uitest.duodecadits.com/form.html |


Scenario Outline: REQ-UI-05
	Given I have opened '<page>'
	When I click on the Form button 
	Then I should get navigated to http://uitest.duodecadits.com/form.html

	Examples: 
	| page                                    |
	| http://uitest.duodecadits.com/          |
	| http://uitest.duodecadits.com/form.html |


Scenario Outline: REQ-UI-06
	Given I have opened '<page>'
	When I click on the Form button 
	Then Form button should turn to active status

	Examples: 
	| page                                    |
	| http://uitest.duodecadits.com/          |
	| http://uitest.duodecadits.com/form.html |


Scenario Outline: REQ-UI-07
	Given I have opened '<page>'
	When I click on the Error button 
	Then I should get navigated to http://uitest.duodecadits.com/error
	And I should get a 404 HTTP response code

	Examples: 
	| page                                    |
	| http://uitest.duodecadits.com/          |
	| http://uitest.duodecadits.com/form.html |


Scenario Outline: REQ-UI-08
	Given I have opened '<page>'
	When I click on the UI Testing button 
	Then I should get navigated to http://uitest.duodecadits.com/

	Examples: 
	| page                                    |
	| http://uitest.duodecadits.com/          |
	| http://uitest.duodecadits.com/form.html |


Scenario: REQ-UI-09
	Given I have opened the Home page
	Then h1 tag should have Welcome to the Docler Holding QA Department as text


Scenario: REQ-UI-10
	Given I have opened the Home page
	Then p tag should have This site is dedicated to perform some exercises and demonstrate automated web testing. as text


Scenario: REQ-UI-11
	Given I have opened the Form page
	Then I should see one input box and one submit button


Scenario Outline: REQ-UI-12
	Given I have opened the Form page
	When I enter <name> to input form and click on the submit button
	Then I shoud get redirected to the Hello page
	And <text> text should appear

	Examples: 
	  | name    | text           |
	  | John    | Hello John!    |
	  | Sophia  | Hello Sophia!  |
	  | Charlie | Hello Charlie! |
	  | Emily   | Hello Emily!   |