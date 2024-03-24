﻿using Duende.IdentityServer.Models;

namespace IdentityService;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("auctionApp","Auction app full access")
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "postman",
                ClientName = "Postman",
                AllowedScopes = {"openid", "profile", "auctionApp"},
                RedirectUris = {"https://www.google.com"},
                ClientSecrets = new[] {new Secret("NotASecret".Sha256())},
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                // ClientSecrets = {new Secret(config["ClientSecret"].Sha256())},
                // AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                // RequirePkce = false,
                // RedirectUris = {config["ClientApp"] + "/api/auth/callback/id-server"},
                // AllowOfflineAccess = true,
                // AccessTokenLifetime = 3600*24*30,
                // AlwaysIncludeUserClaimsInIdToken = true
            }
        };
}
