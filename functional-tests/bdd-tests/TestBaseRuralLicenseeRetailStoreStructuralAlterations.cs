﻿using System;
using OpenQA.Selenium;
using Protractor;
using Xunit.Gherkin.Quick;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I request a Rural LRS structural alteration application")]
        public void RLRSStructuralAlteration()
        {
            /* 
            Page Title: Structural Alteration Application
            */
         
            var proposedChanges = "Sample proposed changes";

            NgWebElement uiProposedChanges = null;
            for (var i = 0; i < 10; i++)
                try
                {
                    var names = ngDriver.FindElements(By.CssSelector("textarea[formcontrolname='description1']"));
                    if (names.Count > 0)
                    {
                        uiProposedChanges = names[0];
                        break;
                    }
                }
                catch (Exception)
                {
                }
            uiProposedChanges.SendKeys(proposedChanges);

            // select 'Yes' for 'Is the public permitted to walk into the cooler space?'
            var uiCoolerAccess = ngDriver.FindElement(By.Id("mat-button-toggle-1-button"));
            uiProposedChanges.Click();

            // upload the signage
            FileUpload("signage.pdf", "(//input[@type='file'])[2]");

            // upload the floor plan
            FileUpload("floor_plan.pdf", "(//input[@type='file'])[5]");

            // upload the site plan
            FileUpload("site_plan.pdf", "(//input[@type='file'])[8]");

            // select the authorized to submit checkbox
            var uiAuthorizedToSubmit = ngDriver.FindElement(By.Id("authorizedToSubmit"));
            uiAuthorizedToSubmit.Click();

            // select the signature agreement checkbox
            var uiSignatureAgreement = ngDriver.FindElement(By.Id("signatureAgreement"));
            uiSignatureAgreement.Click();
        }
    }
}