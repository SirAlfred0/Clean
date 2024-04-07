

using Clean.Application.interfaces;
using Clean.Application.MediatR.Employments;
using Clean.Domain.Dtos;
using Clean.Domain.Entities;
using IdGen;
using MediatR;

namespace Clean.Application.services;

public class EmploymentService(IEmploymentRepository repository) : IEmploymentService
{
    public async Task<bool> CreateEmploymentAsync(CreateEmploymentRequest employment)
    {
        var generator = new IdGenerator(0);

        var e = new Employment() {
            Id = generator.CreateId().ToString(),
            CreationDate = DateTime.Now,
            IsDeleted = false,
            ModificationDate = DateTime.Now,
            BirthCityId = employment.BirthCityId,
            BirthDate = employment.BirthDate,
            FullName = employment.FullName,
            GenderId = employment.GenderId,
            NationalCode = employment.NationalCode,
            PhoneNumber = employment.PhoneNumber,
        };

        var result = await repository.CreateEmploymentAsync(e);

        return result;
    }

    public async Task<bool> DeleteEmploymentAsync(Employment record)
    {
        record.IsDeleted = true;

        return await repository.DeleteEmploymentAsync(record);
    }

    public IEnumerable<GetAllEmploymentDto> GetAllEmployments()
    {
        var result = repository.GetAllEmployments().Select<Employment, GetAllEmploymentDto>(e => new()
        {
            Id = e.Id,
            FullName = e.FullName,
            BirthDate = e.BirthDate,
            NationalCode = e.NationalCode,
            PhoneNumber = e.PhoneNumber,
            CreationDate = e.CreationDate
        }).OrderBy(e => e.CreationDate);

        return result;
    }

    public async Task<Employment> GetEmploymentByIdAsync(string id)
    {
        return await repository.GetEmploymentByIdAsync(id);
    }

    public async Task<Employment> GetEmploymentByNationalCodeAsync(string nationaCode)
    {
        return await repository.GetEmploymentByNationalCodeAsync(nationaCode);
    }

    public async Task<bool> UpdateEmploymentAsync(Employment record, UpdateEmploymentRequest request)
    {
        record.FullName = request.FullName;
        record.BirthDate = request.BirthDate;
        record.BirthCityId = request.BirthCityId;
        record.PhoneNumber = record.PhoneNumber;
        record.GenderId = request.GenderId;

        return await repository.UpdateEmploymentAsync(record);
    }
}
