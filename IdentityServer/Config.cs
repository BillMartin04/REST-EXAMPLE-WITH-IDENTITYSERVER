using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "PeopleClientRestApi",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secretPassword".Sha256())
                    },
                    AllowedScopes = {"peopleRestAPI"}
                }
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("peopleRestAPI", "REST API for People")
            };
        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {

            };
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {

            };
        public static List<TestUser> TestUsers =>
            new List<TestUser>
            {

            };

    }
}
