

using Amazon.Runtime.Internal;
using Clean.Domain.Dtos;
using MediatR;

namespace Clean.Application.MediatR.Employments;

public class CreateEmploymentRequest : IRequest<Result>
{
    public string FullName { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;
    public int BirthCityId { get; set; } = default!;
    public string NationalCode { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public int GenderId { get; set; } = default!;
}

public class UpdateEmploymentRequest : IRequest<Result>
{
    public string Id { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;
    public int BirthCityId { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public int GenderId { get; set; } = default!;
}

public class DeleteEmploymentRequest : IRequest<Result>
{
    public string Id { get; set; } = default!;
}