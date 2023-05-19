using Lab.Blazor.HttpClient.Services;
using Refit;

namespace Lab.Blazor.HttpClient.Data;

public class EmployeeService : IEmployeeService
{
    private const string EmployeeApiAddress = "https://localhost:7147";

    public async Task<Employee[]> GetLiveEmployees()
    {
        var employeeApi = RestService.For<IHttpService>(EmployeeApiAddress);
        return await employeeApi.GetLiveEmployeesAsync();
    }

    public async Task<Employee[]> GetCachedEmployees()
    {
        var employeeApi = RestService.For<IHttpService>(EmployeeApiAddress);
        return await employeeApi.GetcachedEmployeesAsync();
    }
}