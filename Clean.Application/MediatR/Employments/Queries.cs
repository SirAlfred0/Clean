using Clean.Domain.Dtos;
using Clean.Domain.Entities;
using MediatR;

namespace Clean.Application.MediatR.Employments;

public class GetAllEmploymentsRequest : IRequest<Result<GetAllEmploymentDto[]>>
{ 

}

public class GetEmploymentByIdRequest : IRequest<Result<GetEmploymentDto>>
{
    public string Id { get; set; } = default!;
}

public class GetEmploymentByNationalCodeRequest : IRequest<Result<GetEmploymentDto>>
{
    public string NationalCode { get; set; } = default!;
}
