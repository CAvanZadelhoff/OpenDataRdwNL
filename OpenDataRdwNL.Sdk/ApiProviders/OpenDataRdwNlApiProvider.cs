using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenDataRdwNL.Models;
using OpenDataRdwNL.Models.ApiResponses;
using OpenDataRdwNL.Models.ProviderResults;
using OpenDataRdwNL.Sdk.ApiProviders.Contracts;
using OpenDataRdwNL.Sdk.Utility;

namespace OpenDataRdwNL.Sdk.ApiProviders
{
    public class OpenDataRdwNlApiProvider : IOpenDataRdwNlApiProvider
    {
        private readonly string _appToken;
        private readonly string _serviceAddress;
        private readonly ISodaRequestHelper _sodaRequest;
        private readonly ISodaQueryHelper _sodaQuery;
        private readonly ISodaTokenHelper _sodaToken;
        
        public OpenDataRdwNlApiProvider(OpenDataRdwNlOptions dataRdwNlOptions, ISodaRequestHelper sodaRequest, ISodaQueryHelper sodaQuery, ISodaTokenHelper sodaToken)
        {
            _sodaRequest = sodaRequest;
            _sodaQuery = sodaQuery;
            _sodaToken = sodaToken;
            _serviceAddress = dataRdwNlOptions.OpenDataRdwNlServiceAddress ??
                                 throw new ArgumentNullException(nameof(dataRdwNlOptions.OpenDataRdwNlServiceAddress));

            _appToken = dataRdwNlOptions.AppToken ?? throw new ArgumentNullException("AppToken");
        }
        
        public async Task<CarDetailProviderResult> GetCarDetailByLicensePlate(string licensePlate,ResourceType resourceType = ResourceType.Json,int limit = 5)
        {
            if (licensePlate == null)
                throw new ArgumentNullException(nameof(licensePlate));

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var rqToken = _sodaToken.GenerateTokenQuery(_appToken);
                    
                    var rqQuery = _sodaQuery.GenerateQuery("kenteken", licensePlate, limit);
                    
                    var rqUri = _sodaRequest.GenerateRequest(_serviceAddress, resourceType,
                        OpenDataRdwNlApi.GetCarDetail.ResourceId, rqToken, rqQuery);

                    
                    var result = await httpClient.GetStringAsync(rqUri);
                    var data = JsonConvert.DeserializeObject<List<CarDetailApiResponse>>(result);
                    return new CarDetailProviderResult
                    {
                        Response = data,
                        IsSuccess = true
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return new CarDetailProviderResult
                {
                    IsSuccess = false,
                    ErrorDetail = e.Message
                };
            }
            

        }

        public async Task<CarFuelTypeDetailProviderResult> GetCarFuelTypeDetailByLicensePlate(string licensePlate,ResourceType resourceType = ResourceType.Json, int limit = 5)
        {
            if (licensePlate == null)
                throw new ArgumentNullException(nameof(licensePlate));

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var rqToken = _sodaToken.GenerateTokenQuery(_appToken);
                    
                    var rqQuery = _sodaQuery.GenerateQuery("kenteken", licensePlate, limit);
                    
                    var rqUri = _sodaRequest.GenerateRequest(_serviceAddress, resourceType,
                        OpenDataRdwNlApi.GetCarFuelTypeDetail.ResourceId, rqToken, rqQuery);
                    
                    var result = await httpClient.GetStringAsync(rqUri);
                    var data = JsonConvert.DeserializeObject<List<CarFuelTypeDetailApiResponse>>(result);
                    return new CarFuelTypeDetailProviderResult
                    {
                        Response = data,
                        IsSuccess = true
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return new CarFuelTypeDetailProviderResult
                {
                    IsSuccess = false,
                    ErrorDetail = e.Message
                };
            }
        }

        public async Task<CarVehicleBodyWorkDetailProviderResult> GetCarVehicleBodyWorkDetailByLicensePlate(string licensePlate, ResourceType resourceType = ResourceType.Json,
            int limit = 5)
        {
            if (licensePlate == null)
                throw new ArgumentNullException(nameof(licensePlate));

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var rqToken = _sodaToken.GenerateTokenQuery(_appToken);
                    
                    var rqQuery = _sodaQuery.GenerateQuery("kenteken", licensePlate, limit);
                    
                    var rqUri = _sodaRequest.GenerateRequest(_serviceAddress, resourceType,
                        OpenDataRdwNlApi.GetCarVehicleBodyWorkDetail.ResourceId, rqToken, rqQuery);
                    
                    var result = await httpClient.GetStringAsync(rqUri);
                    var data = JsonConvert.DeserializeObject<List<CarVehicleBodyWorkDetailApiResponse>>(result);
                    return new CarVehicleBodyWorkDetailProviderResult
                    {
                        Response = data,
                        IsSuccess = true
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return new CarVehicleBodyWorkDetailProviderResult
                {
                    IsSuccess = false,
                    ErrorDetail = e.Message
                };
            }
        }
    }
}