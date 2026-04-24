using Cashflow.Application.Services;
using Cashflow.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cashflow.Api.Controllers;

[ApiController]
[Route("cashflow")]
public class CashflowController : ControllerBase
{
    private readonly CashflowService _service;

    public CashflowController(CashflowService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CashflowEntry entry)
    {
        entry.Id = Guid.NewGuid();
        _service.Add(entry);
        return Ok(entry);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetAll());
    }
}