
namespace Clean.Domain.Entities;

public class Employment
{
    public string Id { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;
    public int BirthCityId { get; set; } = default!;
    public string NationalCode { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public int GenderId { get; set; } = default!;
    public DateTime CreationDate { get; set; } = default!;
    public DateTime ModificationDate { get; set; } = default!;
    public bool IsDeleted { get; set; }
}
