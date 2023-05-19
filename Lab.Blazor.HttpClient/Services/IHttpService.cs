using Lab.Blazor.HttpClient.Data;
using Refit;

namespace Lab.Blazor.HttpClient.Services
{
    public interface IHttpService
    {
        [Get("/Employee/live/employees")]
        Task<Employee[]> GetLiveEmployeesAsync();

        [Get("/Employee/cached/employees")]
        Task<Employee[]> GetcachedEmployeesAsync();
    }
}
