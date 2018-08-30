﻿using Gov.Lclb.Cllb.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class AliasExtensions
    {
        /// <summary>
        /// Convert a given voteQuestion to a ViewModel
        /// </summary>        
        public static ViewModels.Alias ToViewModel(this MicrosoftDynamicsCRMadoxioAlias alias)
        {
            ViewModels.Alias result = null;
            if (alias != null)
            {
                result = new ViewModels.Alias();
                if (alias.AdoxioAliasid != null)
                {
                    result.Id = alias.AdoxioAliasid;
                }

                result.firstname = alias.AdoxioFirstname;
                result.lastname = alias.AdoxioLastname;
                result.workerId = alias._adoxioWorkeridValue;
                result.contactId = alias._adoxioContactidValue;
            }
            return result;
        }


        public static void CopyValues(this MicrosoftDynamicsCRMadoxioWorker to, ViewModels.Worker from)
        {
            to.AdoxioFirstname = from.firstname;
            to.AdoxioLastname = from.lastname;
            // to._adoxioWorkeridValue = from.workerId;
            // to._adoxioContactidValue = from.contactId;
        }
    }
}
