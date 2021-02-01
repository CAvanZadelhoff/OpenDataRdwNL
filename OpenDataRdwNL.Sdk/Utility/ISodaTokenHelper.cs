using System;

namespace OpenDataRdwNL.Sdk.Utility
{
    public interface ISodaTokenHelper
    {
        string GenerateTokenQuery(string appToken);
    }

    public class SodaTokenHelper : ISodaTokenHelper
    {
        public string GenerateTokenQuery(string appToken)
        {
            if (appToken == null) throw new ArgumentNullException(nameof(appToken));

            return $"&$$app_token={appToken}";
        }
    }
}