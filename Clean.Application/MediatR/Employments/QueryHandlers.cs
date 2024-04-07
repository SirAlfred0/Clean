

using Clean.Application.interfaces;
using Clean.Domain.Abstractions;
using Clean.Domain.Dtos;
using IdGen;
using MediatR;

namespace Clean.Application.MediatR.Employments;

public class GetAllEmploymentsHandler(IEmploymentService _service) : IRequestHandler<GetAllEmploymentsRequest, Result<GetAllEmploymentDto[]>>
{
    public async Task<Result<GetAllEmploymentDto[]>> Handle(GetAllEmploymentsRequest request, CancellationToken cancellationToken)
    {
        var records = _service.GetAllEmployments();

        return records.ToArray();
    }
}

public class GetEmploymentByIdHandler(IEmploymentService _service) : IRequestHandler<GetEmploymentByIdRequest, Result<GetEmploymentDto>>
{
    public async Task<Result<GetEmploymentDto>> Handle(GetEmploymentByIdRequest request, CancellationToken cancellationToken)
    {
        var record = await _service.GetEmploymentByIdAsync(request.Id);

        if (record is null) return EmploymentErrors.NoRequestExist.ShowAsToastError();


        return new GetEmploymentDto
        {
            Id = record.Id,
            BirthDate = record.BirthDate,
            CreationDate = record.CreationDate,
            FullName = record.FullName,
            PhoneNumber = record.PhoneNumber,
            NationalCode = record.NationalCode
        };
    }
}


public class GetEmploymentByNationalCodeHandler(IEmploymentService _service) : IRequestHandler<GetEmploymentByNationalCodeRequest, Result<GetEmploymentDto>>
{
    public async Task<Result<GetEmploymentDto>> Handle(GetEmploymentByNationalCodeRequest request, CancellationToken cancellationToken)
    {
        var record = await _service.GetEmploymentByNationalCodeAsync(request.NationalCode);

        if (record is null) return EmploymentErrors.NoRequestExist.ShowAsToastError();

        return new GetEmploymentDto()
        {
            Id = record.Id,
            BirthDate = record.BirthDate,
            CreationDate = record.CreationDate,
            FullName = record.FullName,
            PhoneNumber = record.PhoneNumber,
            NationalCode = record.NationalCode,
        };
    }
}
