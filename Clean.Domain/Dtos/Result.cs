using Clean.Domain.Enum;
using System.Diagnostics.CodeAnalysis;

namespace Clean.Domain.Dtos;

public class Result
    (
    ResultStatusCode statusCode, 
    Error? message = default!, 
    ErrorRepresentationType representationType = ErrorRepresentationType.None, 
    string? debugMessage = default!
    )
{
    public int StatusCode { get; private set; } = (int)statusCode;

    [AllowNull]
    public Error Message { get; private set; } = message;

    [AllowNull]
    public string DebugMessage { get; private set; } = debugMessage;

    public ErrorRepresentationType RepresentationType { get; private set; } = representationType;


    public static implicit operator Result(RepresentationError e)
    {
        return new Result(ResultStatusCode.BadRequest, e.Error, e.RepresentationType);
    }

    public static Result Success()
    {
        return new(ResultStatusCode.Ok);
    }

    public static Result Failure(string message)
    {
        return new(ResultStatusCode.ServerError, null, ErrorRepresentationType.None, message);
    }
}

public sealed class Result<TData>(
    ResultStatusCode statusCode, 
    TData? data, 
    Error? error = default!,
    ErrorRepresentationType representationType = ErrorRepresentationType.None,
    string debugMessage = default!
    ) : 
    Result(statusCode, error, representationType, debugMessage) where TData : class
{
    [AllowNull]
    public TData Data { get; private set; } = data;

    public static implicit operator Result<TData>(RepresentationError e)
    {
        return new(ResultStatusCode.BadRequest, null, e.Error, e.RepresentationType);
    }

    public static implicit operator Result<TData>(TData data)
    {
        return new Result<TData>(ResultStatusCode.Ok, data);
    }
}

