# OpenDataRdwNL

> .net core SDK library

This library offer services include:

Get Car detail by license plate number in Netherland
you must signup and get your specially token from https://opendata.rdw.nl/profile/edit/developer_settings

Install NugetPackage:
```
Install-Package OpenDataRdwNL.Sdk -Version 1.1.1
```


Add to Startup.cs

```
public void ConfigureServices(IServiceCollection services)
{
  services.AddOpenDataRdwNlServices(opt =>
  {
      opt.AppToken = "<Add_YOUR_APP_TOKEN>";
      opt.OpenDataRdwNlServiceAddress = "https://opendata.rdw.nl";
  });
  
  services.AddMvc();
}
```

use (English version) in  apiController:
```
[ApiController]
[Route("/api/[controller]")]
[Produces("application/json")]
public class OpenDataRdwController : ControllerBase
{
    private readonly IOpenDataRdwEnService _dataRdwEnService;
        
    public OpenDataRdwController(IOpenDataRdwEnService dataRdwEnService)
    {
       _dataRdwEnService = dataRdwEnService;
    }
        
    [HttpGet("[action]")]
    [ProducesResponseType(typeof(List<CarDetailEnServiceResult>), 200)]
    public async Task<IActionResult> CarDetail([FromQuery] string licensePlate)
    {
        var models = await _dataRdwEnService.GetCarDetailByLicensePlate(licensePlate);
        return Ok(models);
     }
}
```

use (Dutch version) in  apiController:
```
[ApiController]
[Route("/api/[controller]")]
[Produces("application/json")]
public class OpenDataRdwController : ControllerBase
{
    private readonly IOpenDataRdwNlService _dataRdwNlService;
        
    public OpenDataRdwController(IOpenDataRdwNlService dataRdwNlService)
    {
       _dataRdwNlService = dataRdwNlService;
    }
        
    [HttpGet("[action]")]
    [ProducesResponseType(typeof(List<CarDetailNlServiceResult>), 200)]
    public async Task<IActionResult> CarDetail([FromQuery] string licensePlate)
    {
        var models = await _dataRdwNlService.GetCarDetailByLicensePlate(licensePlate);
        return Ok(models);
     }
}
```

After that you can use this library in your .Net core Projects

Good luck!
