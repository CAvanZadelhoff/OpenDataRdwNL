using OpenDataRdwNL.Models.ServiceResults;
using OpenDataRdwNL.Sdk.ApiProviders.Contracts;
using OpenDataRdwNL.Sdk.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenDataRdwNL.Sdk.Services
{
    public class OpenDataRdwEnService : IOpenDataRdwEnService
    {

        private readonly IOpenDataRdwNlApiProvider _dataRdwNlApiProvider;

        public OpenDataRdwEnService(
            IOpenDataRdwNlApiProvider dataRdwNlApiProvider)
        {

            _dataRdwNlApiProvider = dataRdwNlApiProvider;
        }

        public async Task<List<CarDetailEnServiceResult>> GetCarDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception($"Can not find car detail, there is a problem in api provider transaction - {apiProviderResult.ErrorDetail}");

            if (apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarDetailEnServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarDetailEnServiceResult(p)).ToList();
        }

        public async Task<List<CarFuelTypeDetailEnServiceResult>> GetCarFuelTypeDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarFuelTypeDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception($"Can not find car fuel type detail, there is a problem in api provider transaction - {apiProviderResult.ErrorDetail}");

            if (apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarFuelTypeDetailEnServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarFuelTypeDetailEnServiceResult(p)).ToList();
        }

        public async Task<List<CarVehicleBodyWorkDetailEnServiceResult>> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarVehicleBodyWorkDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception($"Can not find car body work detail, there is a problem in api provider transaction - {apiProviderResult.ErrorDetail}");

            if (apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarVehicleBodyWorkDetailEnServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarVehicleBodyWorkDetailEnServiceResult(p)).ToList();
        }
    }
}