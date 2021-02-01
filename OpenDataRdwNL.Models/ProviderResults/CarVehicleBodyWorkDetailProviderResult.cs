using System.Collections.Generic;
using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ProviderResults
{
    public class CarVehicleBodyWorkDetailProviderResult
    {
        public string ErrorDetail { get; set; }
        public bool IsSuccess { get; set; }
        public List<CarVehicleBodyWorkDetailApiResponse> Response { get; set; }
    }
}