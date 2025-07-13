using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(AppDbContext context) : ControllerBase
{
    [HttpGet]

    public async Task<ActionResult<IEnumerable<AppUser>>> GetMember()
    {
        var users = await context.Users.ToListAsync();
        return users;
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetMember(string id){
        var member = await context.Users.FindAsync(id);
        if(member == null) return BadRequest();
        else return member;

    }


}
