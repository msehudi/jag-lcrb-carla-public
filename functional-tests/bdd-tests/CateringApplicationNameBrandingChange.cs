﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: CateringApplicationNameBrandingChange
    As a logged in business user
    I want to pay the first year catering licence fee
    And submit a name branding change for different business types

Scenario: Catering Indigenous Nation Name Branding Change
    Given I am logged in to the dashboard as an indigenous nation
    And the account is deleted
    And I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

Scenario: Catering Partnership Name Branding Change
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

Scenario: Catering Private Corporation Name Branding Change
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

Scenario: Catering Public Corporation Name Branding Change
    Given I am logged in to the dashboard as a public corporation
    And the account is deleted
    And I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

Scenario: Catering Society Name Branding Change
    Given I am logged in to the dashboard as a society
    And the account is deleted
    And I am logged in to the dashboard as a society
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

Scenario: Catering Sole Proprietorship Name Branding Change
    Given I am logged in to the dashboard as a sole proprietorship
    And the account is deleted
    And I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./CateringApplicationNameBrandingChange.feature")]
    public sealed class CateringApplicationNameBrandingChange : TestBase
    {
        [Given(@"I am logged in to the dashboard as an (.*)")]
        public void Given_I_view_the_dashboard_IN(string businessType)
        {
            CheckFeatureFlagsLiquor();

            CarlaLogin(businessType);
        }


        [And(@"I am logged in to the dashboard as an (.*)")]
        public void And_I_view_the_dashboard_IN(string businessType)
        {
            CarlaLogin(businessType);
        }


        [Given(@"I am logged in to the dashboard as a (.*)")]
        public void Given_I_view_the_dashboard(string businessType)
        {
            CheckFeatureFlagsLiquor();

            CarlaLogin(businessType);
        }
    }
}