using Clean.API.Abstractions;
using Clean.Application.interfaces;
using Clean.Application.MediatR.Employments;
using Clean.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class EmploymentController(IMediator mediator) : ControllerBase
{

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateEmploymentRequest request)
    {
        var result = await mediator.Send(request);

        return result.ToIActionResult();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await mediator.Send(new GetAllEmploymentsRequest());

        return result.ToIActionResult();
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery] GetEmploymentByIdRequest request)
    {
        var result = await mediator.Send(request);

        return result.ToIActionResult();
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateEmploymentRequest request)
    {
        var result = await mediator.Send(request);

        return result.ToIActionResult();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteEmploymentRequest request)
    {
        var result = await mediator.Send(request);

        return result.ToIActionResult();
    }
}
