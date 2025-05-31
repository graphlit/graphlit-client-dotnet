using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace GraphlitClient
{
    internal class JwtHelpers
    {
        public static string GenerateJwt(string organizationId = null, string environmentId = null, string jwtSecret = null, string ownerId = null, string userId = null)
        {
            const string DEFAULT_ISSUER = "graphlit";
            const string DEFAULT_AUDIENCE = "https://portal.graphlit.io";
            const string DEFAULT_ROLE = "Owner";

            if (String.IsNullOrEmpty(organizationId))
                organizationId = Environment.GetEnvironmentVariable("GRAPHLIT_ORGANIZATION_ID");

            if (String.IsNullOrEmpty(environmentId))
                environmentId = Environment.GetEnvironmentVariable("GRAPHLIT_ENVIRONMENT_ID");

            if (String.IsNullOrEmpty(ownerId))
                ownerId = Environment.GetEnvironmentVariable("GRAPHLIT_OWNER_ID");

            if (String.IsNullOrEmpty(userId))
                userId = Environment.GetEnvironmentVariable("GRAPHLIT_USER_ID");

            if (String.IsNullOrEmpty(jwtSecret))
                jwtSecret = Environment.GetEnvironmentVariable("GRAPHLIT_JWT_SECRET");

            if (String.IsNullOrEmpty(organizationId))
                throw new ArgumentNullException(nameof(organizationId));

            if (String.IsNullOrEmpty(environmentId))
                throw new ArgumentNullException(nameof(environmentId));

            if (String.IsNullOrEmpty(jwtSecret))
                throw new ArgumentNullException(nameof(jwtSecret));

            //
            // NOTE: ownerId is optional
            //

            // Specify the expiration (one hour from now)
            var expiration = DateTime.UtcNow.AddHours(1);

            // Create the security key
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(jwtSecret));

            // Create the signing credentials
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var options = new Dictionary<string, string>
            {
                ["x-graphlit-environment-id"] = environmentId,
                ["x-graphlit-organization-id"] = organizationId,
                ["x-graphlit-role"] = DEFAULT_ROLE
            };

            if (!String.IsNullOrEmpty(ownerId))
                options["x-graphlit-owner-id"] = ownerId;

            if (!String.IsNullOrEmpty(userId))
                options["x-graphlit-user-id"] = userId;

            // Create the claims
            var claims = new Claim[]
            {
                new Claim("https://graphlit.io/jwt/claims", JsonConvert.SerializeObject(options, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.None }), JsonClaimValueTypes.Json)
            };

            // Create the JWT and write it to a string
            var token = new JwtSecurityToken(DEFAULT_ISSUER, DEFAULT_AUDIENCE, claims, expires: expiration, signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
