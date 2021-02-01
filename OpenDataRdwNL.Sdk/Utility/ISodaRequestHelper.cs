using OpenDataRdwNL.Sdk.ApiProviders;

namespace OpenDataRdwNL.Sdk.Utility
{
    public interface ISodaRequestHelper
    {
        string GenerateRequest(string baseUri, ResourceType resourceType, string resourceId,string token,string query = null);
    }
    
    public class SodaRequestHelper : ISodaRequestHelper
    {
        private readonly ISodaResourceHelper _resourceHelper;
        
        public SodaRequestHelper(ISodaResourceHelper resourceHelper)
        {
            _resourceHelper = resourceHelper;
        }
        
        public string GenerateRequest(string baseUri, ResourceType resourceType, string resourceId,string token,string query = null)
        {
            return $"{baseUri}" +
                   $"{OpenDataRdwNlApi.Basic.ResourceUrl}" +
                   $"{_resourceHelper.GetResource(resourceId,resourceType)}?{token}{query}";
        }
    }

    
}