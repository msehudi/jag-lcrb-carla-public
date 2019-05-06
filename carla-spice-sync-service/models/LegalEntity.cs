﻿using System;
using System.Collections.Generic;

namespace SpdSync.models
{
    public class LegalEntity
    {
        public string Name { get; set; }
        public decimal? InterestPercentage { get; set; }
        public int? CommonVotingShares { get; set; }
        public DateTimeOffset? DateSharesIssued { get; set; }
        public DateTimeOffset? DateAppointed { get; set; }
        public Contact Contact { get; set; }
        public Account Account { get; set; }
        public List<Alias> Aliases { get; set; }
        public List<Address> PreviousAddresses { get; set; }
    }
}
