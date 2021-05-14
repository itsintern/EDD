﻿using EDD.Models;

using System.Collections.Generic;

namespace EDD.Functions
{
    public class GetDomainShares : EDDFunction
    {
        public override string FunctionName => "GetDomainShares";

        public override string[] Execute(ParsedArgs args)
        {
            LDAP computerQuery = new LDAP();
            List<string> domainSystems = computerQuery.CaptureComputers();
            Amass shareMe = new Amass();
            string[] allShares = shareMe.GetShares(domainSystems, args.Threads);

            return allShares;
        }
    }
}