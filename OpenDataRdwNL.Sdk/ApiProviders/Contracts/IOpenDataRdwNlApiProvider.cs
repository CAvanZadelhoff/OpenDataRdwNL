using System.Threading.Tasks;
using OpenDataRdwNL.Models.ProviderResults;

namespace OpenDataRdwNL.Sdk.ApiProviders.Contracts
{
    public interface IOpenDataRdwNlApiProvider
    {
        Task<CarDetailProviderResult> GetCarDetailByLicensePlate(string licensePlate,ResourceType resourceType = ResourceType.Json,int limit = 5);
        Task<CarFuelTypeDetailProviderResult> GetCarFuelTypeDetailByLicensePlate(string licensePlate,ResourceType resourceType = ResourceType.Json,int limit = 5);

        Task<CarVehicleBodyWorkDetailProviderResult> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate,ResourceType resourceType = ResourceType.Json,int limit = 5);
    }
}