using Microsoft.Extensions.Options;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace PTApi.Helpers
{
    public class JwtFactory : IJwtFactory
    {
        private readonly JwtIssuerOptions _jwtOptions;

        public JwtFactory(IOptions<JwtIssuerOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
            ThrowIfInvalidOptions(_jwtOptions);
        }

        public async Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(_jwtOptions.IssuedAt).ToString(), ClaimValueTypes.Integer64),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Rol),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.RolGroup),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Id),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Comp),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Firstname),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Avatar),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Lastname),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Email),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.ResourceId),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.AllowRec),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Compcurrencylng),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Compcurrencysht),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Compcurrencysym),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Doempsworkweekends),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Standarddailyhrs),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Financerepperiod),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.CompanyName),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Financerepyear),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.ReportingDay),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.CompanyLogo),
                identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Freezefore)


            };

            // Create the JWT security token and encode it.
            var jwt = new JwtSecurityToken(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                notBefore: _jwtOptions.NotBefore,
                expires: _jwtOptions.Expiration,
                signingCredentials: _jwtOptions.SigningCredentials);

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return encodedJwt;
        }



        public ClaimsIdentity GenerateClaimsIdentity(

            string userName, string id,string companyId, string appUserRole, string roleGroup, string firstname, string avatar, string lastname, string email,
            string resourceId, string allowRec, string financeRepPeriod, string companyName, string financeRepYear, string reportingDay, string companyLogo, string freezeForecast, string standardDailyHrs,
            string doEmployeesWorkWeekends,string currencyLongName, string currencyShortName, string currencySymbol)
        {
            return new ClaimsIdentity(new GenericIdentity(userName, "Token"), new[]
            {
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Id, id),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Comp, companyId),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Rol, appUserRole),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Rol, roleGroup),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Firstname, firstname),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Avatar, avatar),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Lastname, lastname),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Email, email),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.ResourceId, resourceId),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.AllowRec, allowRec),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Financerepperiod, financeRepPeriod),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.CompanyName, companyName),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Financerepyear, financeRepYear),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.ReportingDay, reportingDay),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.CompanyLogo, companyLogo),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Freezefore, freezeForecast),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Standarddailyhrs, standardDailyHrs),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Doempsworkweekends, doEmployeesWorkWeekends),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Compcurrencylng, currencyLongName),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Compcurrencysht, currencyShortName),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Compcurrencysym, currencySymbol),
            });
        }

        /// <returns>Date converted to seconds since Unix epoch (Jan 1, 1970, midnight UTC).</returns>
        private static long ToUnixEpochDate(DateTime date) => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);

        private static void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.ValidFor <= TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(JwtIssuerOptions.ValidFor));
            }

            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));
            }

            if (options.JtiGenerator == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
            }
        }
    }
}
