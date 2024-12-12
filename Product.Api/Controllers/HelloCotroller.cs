using Microsoft.AspNetCore.Mvc;

namespace Product.Api.COntrollers;

[ApiController, Route("api/v1[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string SayHello() => "Hello, World!";
}