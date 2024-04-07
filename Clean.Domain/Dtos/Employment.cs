

namespace Clean.Domain.Dtos;

public class GetAllEmploymentDto
{
    public string Id { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;
    public string NationalCode { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public DateTime CreationDate { get; set; } = default!;
}

public class GetEmploymentDto
{
    public string Id { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;
    public string NationalCode { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public DateTime CreationDate { get; set; } = default!;
}
