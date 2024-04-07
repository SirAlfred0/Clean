

using Clean.Domain.Dtos;

namespace Clean.Domain.Abstractions
{
    public record EmploymentErrors
    {
        public static Error RequestAlreadyExist = new(100, "Dear user, you have a pending request still on progress.");
        public static Error NoRequestExist = new(101, "Dear user, there is no request available");
    }
}
