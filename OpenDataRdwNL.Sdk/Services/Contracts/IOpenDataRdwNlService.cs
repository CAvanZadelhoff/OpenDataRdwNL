using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDataRdwNL.Models.ServiceResults;

namespace OpenDataRdwNL.Sdk.Services.Contracts
{
    public interface IOpenDataRdwNlService
    {
        Task<List<CarDetailServiceResult>> GetCarDetailByLicensePlate(string licensePlate);
        Task<List<CarFuelTypeDetailServiceResult>> GetCarFuelTypeDetailByLicensePlate(string licensePlate);
        Task<List<CarVehicleBodyWorkDetailServiceResult>> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate);
    }
}