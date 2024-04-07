using Clean.Domain.Dtos;
using Clean.Domain.Entities;

namespace Clean.Application.interfaces;

public interface IEmploymentRepository
{
    public Task<Employment> GetEmploymentByIdAsync(string id);
    public IEnumerable<Employment> GetAllEmployments();
    public Task<bool> CreateEmploymentAsync(Employment employment);
    public Task<bool> UpdateEmploymentAsync(Employment employment);
    public Task<bool> DeleteEmploymentAsync(Employment employment);
    public Task<Employment> GetEmploymentByNationalCodeAsync(string nationalCode);
}
