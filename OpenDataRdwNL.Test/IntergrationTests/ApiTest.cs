using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Xunit.Extensions.Ordering;

namespace OpenDataRdwNL.Test.IntergrationTests
{
    [Order(3)]
    public class ApiTest : BasicConfig
    {
        #region snippet_CarDetailSodaApiTest_Test1
        [Fact,Order(1)]
        public async Task Test01_GetCarDetailList_By_LicensePlate_Should_ReturnOk_FilledList()
        {
            var response = await SdkService.GetCarDetailByLicensePlate("WJTH78");
            
            response.Should().NotBeNull();
            response.Count.Should().Be(1);
        }
        #endregion
        
        #region snippet_CarFuelTypeDetailSodaApiTest_Test1
        [Fact,Order(2)]
        public async Task Test02_GetCarFuelTypeDetailList_By_LicensePlate_Should_ReturnOk_FilledList()
        {
            var response = await SdkService.GetCarFuelTypeDetailByLicensePlate("TK098V");
            
            response.Should().NotBeNull();
            response.Count.Should().Be(3);
        }
        #endregion
        
        #region snippet_CarFuelTypeDetailSodaApiTest_Test2
        [Fact,Order(3)]
        public async Task Test03_GetCarFuelTypeDetailList_By_LicensePlate_Should_ReturnOk_EmptyList()
        {
            var response = await SdkService.GetCarFuelTypeDetailByLicensePlate("WJTH78");
            
            response.Should().NotBeNull();
            response.Count.Should().Be(0);
        }
        #endregion
        
        #region snippet_CarVehicleBodyWorkDetailSodaApiTest_Test1
        [Fact,Order(4)]
        public async Task Test03_GetCarVehicleBodyWorkDetailList_By_LicensePlate_Should_ReturnOk_EmptyList()
        {
            var response = await SdkService.GetCarVehicleBodyWorkDetailByLicensePlate("WJTH78");
            
            response.Should().NotBeNull();
            response.Count.Should().Be(0);
        }
        #endregion
        
        #region snippet_CarVehicleBodyWorkDetailSodaApiTest_Test1
        [Fact,Order(4)]
        public async Task Test04_GetCarVehicleBodyWorkDetailList_By_LicensePlate_Should_ReturnOk_FilledList()
        {
            var response = await SdkService.GetCarVehicleBodyWorkDetailByLicensePlate("V525PX");
            
            response.Should().NotBeNull();
            response.Count.Should().Be(1);
        }
        #endregion
    }
}