using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(AppDbContext context) : ControllerBase
{
    [HttpGet]

    public ActionResult<IEnumerable<AppUser>> GetMember()
    {
        var users = context.Users.ToList();
        return users;
    }
    
    [HttpGet("{id}")]
    public ActionResult<AppUser> GetMember(string id){
        var member = context.Users.Find(id);
        if(member == null) return BadRequest();
        else return member;

    }


}
