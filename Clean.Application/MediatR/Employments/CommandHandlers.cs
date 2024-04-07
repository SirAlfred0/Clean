

using Clean.Application.interfaces;
using Clean.Domain.Abstractions;
using Clean.Domain.Dtos;
using Clean.Domain.Entities;
using IdGen;
using MediatR;

namespace Clean.Application.MediatR.Employments;

public class CreateEmploymentHandler(IEmploymentService _service) : IRequestHandler<CreateEmploymentRequest, Result>
{
    public async Task<Result> Handle(CreateEmploymentRequest request, CancellationToken cancellationToken)
    {
        var alreadySentRequest = await _service.GetEmploymentByNationalCodeAsync(request.NationalCode) != null;

        if (alreadySentRequest) return EmploymentErrors.RequestAlreadyExist.ShowAsFormError();

        await _service.CreateEmploymentAsync(request);

        return Result.Success();
    }
}

public class UpdateEmploymentHandler(IEmploymentService _service) : IRequestHandler<UpdateEmploymentRequest, Result>
{
    public async Task<Result> Handle(UpdateEmploymentRequest request, CancellationToken cancellationToken)
    {
        var record = await _service.GetEmploymentByIdAsync(request.Id);

        if (record is null) return EmploymentErrors.NoRequestExist.ShowAsFormError();

        await _service.UpdateEmploymentAsync(record, request);

        return Result.Success();
    }
}

public class DeleteEmploymentHandler(IEmploymentService _service) : IRequestHandler<DeleteEmploymentRequest, Result>
{
    public async Task<Result> Handle(DeleteEmploymentRequest request, CancellationToken cancellationToken)
    {
        var record = await _service.GetEmploymentByIdAsync(request.Id);

        if (record is null) return EmploymentErrors.NoRequestExist.ShowAsToastError();

        await _service.DeleteEmploymentAsync(record);

        return Result.Success();
    }
}
