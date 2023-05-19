using Lap.Blazor.RestApi.Model;
using Lap.Blazor.RestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lap.Blazor.RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{

    private readonly ILogger<EmployeeController> _logger;
    private readonly IEmployeeService _employeeService;

    public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
    {
        _logger = logger;
        _employeeService = employeeService;
    }

    [HttpGet("cached/employees")]
    public async Task<ActionResult<Employee[]>> GetCachedEmployees()
    {
        return await _employeeService.FetchCachedEmployeeAsync();
    }

    [HttpGet("live/employees")]
    public async Task<ActionResult<Employee[]>> GetLiveEmployees()
    {
        return await _employeeService.FetchLiveEmployeeAsync();
    }
}