

using Clean.Domain.Dtos;
using Clean.Domain.Enum;

namespace Clean.Domain.Abstractions;

public static class Extentions
{
    public static RepresentationError HideError(this Error e)
    {
        return new()
        {
            Error = e,
            RepresentationType = ErrorRepresentationType.None
        };
    }

    public static RepresentationError ShowAsToastError(this Error e)
    {
        return new()
        {
            Error = e,
            RepresentationType = ErrorRepresentationType.ToastError
        };
    }


    public static RepresentationError ShowAsFormError(this Error e)
    {
        return new()
        {
            Error = e,
            RepresentationType = ErrorRepresentationType.FormError
        };
    }
}
