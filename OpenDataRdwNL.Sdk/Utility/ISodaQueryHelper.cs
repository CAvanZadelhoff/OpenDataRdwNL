using System.Text;

namespace OpenDataRdwNL.Sdk.Utility
{
    public interface ISodaQueryHelper
    {
        string GenerateQuery(string key, string value, int? limit, int? offset = 0);
    }

    public class SodaQueryHelper : ISodaQueryHelper
    {
        public string GenerateQuery(string key, string value, int? limit, int? offset)
        {
            var stBuilder = new StringBuilder();
            stBuilder.Append($"&{key}={value}");


            if (limit.HasValue)
            {
                limit = limit == 0 ? 5 : limit;
                stBuilder.Append($"&$limit={limit}");
            }
            
            if (offset.HasValue)
                stBuilder.Append($"&$offset={offset}");
            
            return stBuilder.ToString();
        }
    }
}