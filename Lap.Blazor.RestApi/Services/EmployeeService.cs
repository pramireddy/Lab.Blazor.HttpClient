using Lap.Blazor.RestApi.Model;

namespace Lap.Blazor.RestApi.Services;

public class EmployeeService : IEmployeeService
{
    public Task<Employee[]> FetchCachedEmployeeAsync()
    {
        Thread.Sleep(1000);

        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Employee
        {
            StandardId = $"Name-{index}",
            DisplayName = $"Description-{index}",
            EMail = $"EMail-{index}"
        }).ToArray());
    }

    public Task<Employee[]> FetchLiveEmployeeAsync()
    {
        Thread.Sleep(2000);

        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Employee
        {
            StandardId = $"Name-{index}",
            DisplayName = $"Description-{index}",
            EMail = $"EMail-{index}"
        }).ToArray());
    }
}