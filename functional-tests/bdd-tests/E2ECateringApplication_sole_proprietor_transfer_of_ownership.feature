﻿Feature: E2ECateringApplication_sole_proprietor_transfer_of_ownership
    As a logged in business user
    I want to pay the first year catering licence fee
    And request a transfer of ownership for a sole proprietorship

Scenario: Pay First Year Catering Licence and Request a Transfer of Ownership
    Given I am logged in to the dashboard as a sole proprietorship
    And the account is deleted
    And I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page