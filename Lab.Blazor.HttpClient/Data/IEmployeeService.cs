namespace Lab.Blazor.HttpClient.Data;

public interface IEmployeeService
{
    Task<Employee[]> GetLiveEmployees();
    Task<Employee[]> GetCachedEmployees();
}