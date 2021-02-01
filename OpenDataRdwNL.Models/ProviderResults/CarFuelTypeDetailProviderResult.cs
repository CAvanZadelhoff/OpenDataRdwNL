using System.Collections.Generic;
using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ProviderResults
{
    public class CarFuelTypeDetailProviderResult
    {
        public string ErrorDetail { get; set; }
        public bool IsSuccess { get; set; }
        public List<CarFuelTypeDetailApiResponse> Response { get; set; }
    }
}