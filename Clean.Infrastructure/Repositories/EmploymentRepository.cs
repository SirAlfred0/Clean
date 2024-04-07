using Clean.Application.interfaces;
using Clean.Domain.Dtos;
using Clean.Domain.Entities;
using Clean.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Clean.Infrastructure.Repositories;

internal class EmploymentRepository(CleanDbContext dbContext) : IEmploymentRepository
{
    private readonly CleanDbContext _dbContext = dbContext;

    public async Task<bool> CreateEmploymentAsync(Employment employment)
    {
        await _dbContext.Employments.AddAsync(employment);

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteEmploymentAsync(Employment employment)
    {
        _dbContext.Employments.Update(employment);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<Employment> GetEmploymentByIdAsync(string _id)
    {
        var result = await _dbContext.Employments.FirstOrDefaultAsync(e => e.Id == _id && e.IsDeleted == false);

        return result!;
    }

    public async Task<Employment> GetEmploymentByNationalCodeAsync(string _nationalCode)
    {
        var employment = await _dbContext.Employments.FirstOrDefaultAsync(e => e.NationalCode == _nationalCode && e.IsDeleted == false);

        return employment!;
    }

    public async Task<bool> UpdateEmploymentAsync(Employment employment)
    {
        _dbContext.Employments.Update(employment);

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public IEnumerable<Employment> GetAllEmployments()
    {
        var result = _dbContext.Employments.Select(e => e).Where(e => e.IsDeleted == false);

        return result;
    }
}
