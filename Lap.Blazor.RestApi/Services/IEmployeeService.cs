using Lap.Blazor.RestApi.Model;

namespace Lap.Blazor.RestApi.Services
{
    public interface IEmployeeService
    {
        Task<Employee[]> FetchCachedEmployeeAsync();
        Task<Employee[]> FetchLiveEmployeeAsync();
    }
}
