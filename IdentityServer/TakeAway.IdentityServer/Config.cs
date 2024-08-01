// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace TakeAway.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
         {
           new ApiResource("ResourceCatalog"){Scopes={"CatalogFullPermisson","CatalogReadPermission"}},
           new ApiResource("ReseourceDiscount"){Scopes={"DiscountFullPermission"}},
           new ApiResource("ResourceOrder"){Scopes={"OrderFullPermission"}},
           new ApiResource("ResourceCargo"){Scopes={"CargoFullPermission"}},
           new ApiResource("ResourceBasket"){Scopes={"BasketFullPermission"}},
           new ApiResource("ResourceComment"){Scopes={"CommentFullPermission"}},
           new ApiResource("ResourceMessage"){Scopes={"MessageFullPermission"}},
           new ApiResource("ResourceOcelot"){Scopes={"OcelotFullPermission"}},
           new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
         };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermisson","Full authority for catalog operations"),
            new ApiScope("CatalogReadPermission","Reading authority for catalog operations"),
            new ApiScope("DiscountFullPermission","Full authority for discount operations "),
            new ApiScope("OrderFullPermission","Full authority for Order operations "),
            new ApiScope("CargoFullPermission","Full authority for Cargo operations "),
            new ApiScope("BasketFullPermission","Full authority for Basket operations"),
            new ApiScope("CommentFullPermission","Full authority for Comment operations"),
            new ApiScope("MessageFullPermission","Full authority for Message operations"),
            new ApiScope("OcelotFullPermission","Full authority for Ocelot operations"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            //visitor
            new Client
            {
                ClientId="TakeAwayVisitorId",
                ClientName="Take Away Visitor User",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={new Secret("takeawaysecret".Sha256())},
                AllowedScopes={ "CatalogFullPermisson", IdentityServerConstants.LocalApi.ScopeName },
                AllowAccessTokensViaBrowser=true
            },

            //Admin
            new Client
            {
                ClientId="MultiShopAdminId",
                ClientName="Multi Shop Admin User",
                AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                ClientSecrets={new Secret("multishopsecret".Sha256())},
                AllowedScopes={ "CatalogFullPermisson" ,"CatalogReadPermission" ,"DiscountFullPermission" , "OrderFullPermission" ,"CargoFullPermission","BasketFullPermission","CommentFullPermission","MessageFullPermission","OcelotFullPermission"
                    ,IdentityServerConstants.LocalApi.ScopeName,IdentityServerConstants.StandardScopes.Email,IdentityServerConstants.StandardScopes.OpenId,IdentityServerConstants.StandardScopes.Profile },
                AccessTokenLifetime=600

            }
        };
    }
}