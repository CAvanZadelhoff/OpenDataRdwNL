# OpenDataRdwNL

> .net core SDK library

This library offer services include:

Get Car detail by license plate number in Netherland
you must signup and get your specially token from https://opendata.rdw.nl/profile/edit/developer_settings

```
public void ConfigureServices(IServiceCollection services)
{
  services.AddOpenDataRdwNlServices(opt =>
  {
      opt.AppToken = "NeFe3Tst7DTa8DgAWkDFIVwfs";
      opt.OpenDataRdwNlLanguage = OpenDataRdwNlLanguage.En;
      opt.OpenDataRdwNlServiceAddress = "https://opendata.rdw.nl";
  });
  
  services.AddMvc();
}
```

use in apiController:
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
    [ProducesResponseType(typeof(List<CarDetailServiceResult>), 200)]
    public async Task<IActionResult> CarDetail([FromQuery] string licensePlate)
    {
        var models = await _dataRdwNlService.GetCarDetailByLicensePlate(licensePlate);
        return Ok(models);
     }
}
```

After that you can use this library in your .Net core Projects

Good luck!
