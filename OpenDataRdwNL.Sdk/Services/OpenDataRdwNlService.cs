using OpenDataRdwNL.Models.ServiceResults;
using OpenDataRdwNL.Sdk.ApiProviders.Contracts;
using OpenDataRdwNL.Sdk.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenDataRdwNL.Sdk.Services
{
    public class OpenDataRdwNlService : IOpenDataRdwNlService
    {
        private readonly IOpenDataRdwNlApiProvider _dataRdwNlApiProvider;

        public OpenDataRdwNlService(IOpenDataRdwNlApiProvider dataRdwNlApiProvider)
        {
            _dataRdwNlApiProvider = dataRdwNlApiProvider;
        }

        public async Task<List<CarDetailNlServiceResult>> GetCarDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception($"Can not find car detail, there is a problem in api provider transaction - {apiProviderResult.ErrorDetail}");

            if (apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarDetailNlServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarDetailNlServiceResult(p)).ToList();
        }

        public async Task<List<CarFuelTypeDetailNlServiceResult>> GetCarFuelTypeDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarFuelTypeDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception($"Can not find car fuel type detail, there is a problem in api provider transaction - {apiProviderResult.ErrorDetail}");

            if (apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarFuelTypeDetailNlServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarFuelTypeDetailNlServiceResult(p)).ToList();
        }

        public async Task<List<CarVehicleBodyWorkDetailNlServiceResult>> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarVehicleBodyWorkDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception($"Can not find car body work detail, there is a problem in api provider transaction - {apiProviderResult.ErrorDetail}");

            if (apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarVehicleBodyWorkDetailNlServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarVehicleBodyWorkDetailNlServiceResult(p)).ToList();
        }
    }
}