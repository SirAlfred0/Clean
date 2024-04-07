using Clean.Domain.Enum;
using System.Diagnostics.CodeAnalysis;

namespace Clean.Domain.Dtos;

public class RepresentationError
{
    public required Error Error { get; set; }
    public required ErrorRepresentationType RepresentationType { get; set; }

}
