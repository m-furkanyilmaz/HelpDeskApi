using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //[HttpGet]
    //public ActionResult<IEnumerable<soru>> GetSorus()
    //{
    //    return _dbContext.sorus.ToList();
    //}

    [HttpGet("UserId")]
    public ActionResult<User> GetUserById(int id)
    {
        var result = _dbContext.users.Find(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }

    [HttpPost]
    public ActionResult<User> CreateUser([FromBody] User req)
    {
        _dbContext.users.Add(req);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetUserById), new { id = req.UserID }, req);
    }
}