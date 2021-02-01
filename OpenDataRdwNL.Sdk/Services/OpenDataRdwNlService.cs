using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenDataRdwNL.Models;
using OpenDataRdwNL.Models.ServiceResults;
using OpenDataRdwNL.Sdk.ApiProviders.Contracts;
using OpenDataRdwNL.Sdk.Services.Contracts;

namespace OpenDataRdwNL.Sdk.Services
{
    public class OpenDataRdwNlService : IOpenDataRdwNlService
    {
        private readonly OpenDataRdwNlOptions _dataRdwNlOptions;
        private readonly IOpenDataRdwNlApiProvider _dataRdwNlApiProvider;

        public OpenDataRdwNlService(OpenDataRdwNlOptions dataRdwNlOptions,
            IOpenDataRdwNlApiProvider dataRdwNlApiProvider)
        {
            _dataRdwNlOptions = dataRdwNlOptions;
            _dataRdwNlApiProvider = dataRdwNlApiProvider;
        }

        public async Task<List<CarDetailServiceResult>> GetCarDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception("Can not find car detail, there is a problem in api provider transaction");

            if(apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarDetailServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarDetailServiceResult().ToServiceResult(_dataRdwNlOptions.OpenDataRdwNlLanguage, p)).ToList();
        }

        public async Task<List<CarFuelTypeDetailServiceResult>> GetCarFuelTypeDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarFuelTypeDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception("Can not find car fuel type detail, there is a problem in api provider transaction");

            if(apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarFuelTypeDetailServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarFuelTypeDetailServiceResult().ToServiceResult(_dataRdwNlOptions.OpenDataRdwNlLanguage, p)).ToList();
        }
        
        public async Task<List<CarVehicleBodyWorkDetailServiceResult>> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate)
        {
            var apiProviderResult = await _dataRdwNlApiProvider.GetCarVehicleBodyWorkDetailByLicensePlate(licensePlate);

            if (!apiProviderResult.IsSuccess)
                throw new Exception("Can not find car fuel type detail, there is a problem in api provider transaction");

            if(apiProviderResult.Response == null)
                throw new ArgumentNullException($"apiProviderResult.Response");

            return !apiProviderResult.Response.Any()
                ? new List<CarVehicleBodyWorkDetailServiceResult>()
                : apiProviderResult.Response.Select(p =>
                    new CarVehicleBodyWorkDetailServiceResult().ToServiceResult(_dataRdwNlOptions.OpenDataRdwNlLanguage, p)).ToList();
        }
    }
}