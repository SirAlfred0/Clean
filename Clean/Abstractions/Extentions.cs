using Clean.Domain.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Clean.API.Abstractions;

public static class Extentions
{
    public static IActionResult ToIActionResult(this Result result)
    {
        var success = new OkObjectResult(result);
        var error = new BadRequestObjectResult(result);

        return result.StatusCode == 200 ? success : error;
    }
}
