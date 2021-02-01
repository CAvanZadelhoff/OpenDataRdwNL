using System.Collections.Generic;
using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ProviderResults
{
    public class CarDetailProviderResult
    {
        public string ErrorDetail { get; set; }
        public bool IsSuccess { get; set; }
        public List<CarDetailApiResponse> Response { get; set; }
    }
}