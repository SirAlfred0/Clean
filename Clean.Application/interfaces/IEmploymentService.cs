
using Clean.Application.MediatR.Employments;
using Clean.Domain.Dtos;
using Clean.Domain.Entities;

namespace Clean.Application.interfaces;

public interface IEmploymentService
{
    public Task<Employment> GetEmploymentByIdAsync(string id);
    public IEnumerable<GetAllEmploymentDto> GetAllEmployments();
    public Task<bool> CreateEmploymentAsync(CreateEmploymentRequest employment);
    public Task<bool> UpdateEmploymentAsync(Employment record, UpdateEmploymentRequest request);
    public Task<bool> DeleteEmploymentAsync(Employment record);
    public Task<Employment> GetEmploymentByNationalCodeAsync(string nationaCode);
}
