using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab1_Hardyk.Rest.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly PeopleDb db;

    public PeopleController(PeopleDb db)
    {
        this.db = db;
    }

    public async Task<ActionResult> Get()
    {
        return Ok(await db.People.ToListAsync());
    }
}