using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDataRdwNL.Models.ServiceResults;

namespace OpenDataRdwNL.Sdk.Services.Contracts
{
    public interface IOpenDataRdwNlService
    {
        Task<List<CarDetailNlServiceResult>> GetCarDetailByLicensePlate(string licensePlate);
        Task<List<CarFuelTypeDetailNlServiceResult>> GetCarFuelTypeDetailByLicensePlate(string licensePlate);
        Task<List<CarVehicleBodyWorkDetailNlServiceResult>> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate);
    }
    
    public interface IOpenDataRdwEnService
    {
        Task<List<CarDetailEnServiceResult>> GetCarDetailByLicensePlate(string licensePlate);
        Task<List<CarFuelTypeDetailEnServiceResult>> GetCarFuelTypeDetailByLicensePlate(string licensePlate);
        Task<List<CarVehicleBodyWorkDetailEnServiceResult>> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate);
    }
}