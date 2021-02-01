using System;
using OpenDataRdwNL.Sdk.ApiProviders;

namespace OpenDataRdwNL.Sdk.Utility
{
    public interface ISodaResourceHelper
    {
        string GetResource(string recourceId,ResourceType resourceType);
    }
    
    public class SodaResourceHelper : ISodaResourceHelper
    {
        private string GetResourceTypeAsString(ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Json:
                    return ".json";
                case ResourceType.Csv:
                    return ".csv";
                default:
                    throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, null);
            }
        }

        public string GetResource(string recourceId, ResourceType resourceType)
        {
            var resourceIdPostFix = GetResourceTypeAsString(resourceType);
            return $"{recourceId}{resourceIdPostFix}";
        }
    }
}