﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Connect.Models;
using Thinktecture.IdentityServer.Core.Services;

namespace Thinktecture.IdentityServer.TestServices
{
    public class TestConsentService : IConsentService
    {
        public bool RequiresConsent(Client client, ClaimsPrincipal user, IEnumerable<string> scopes)
        {
            return client.RequireConsent;
        }
        
        public void UpdateConsent(Client client, ClaimsPrincipal user, IEnumerable<string> scopes)
        {
            // TODO
        }
    }
}