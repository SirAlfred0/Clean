using System.ComponentModel.DataAnnotations;

namespace Clean.Domain.Dtos;

public sealed class Error(int code, string message)
{
    public int Code { get; set; } = code;
    public string Message { get; set; } = message;
}
