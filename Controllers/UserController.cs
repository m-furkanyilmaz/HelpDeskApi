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

    //[HttpGet("{UserId}")]
    //public ActionResult<User> GetUserById(Guid UserId)
    //{
    //    var result = _dbContext.users.Find(UserId);
    //    if (result == null)
    //    {
    //        return NotFound();
    //    }
    //    return result;
    //}
    //[HttpGet]
    //public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    //{
    //    return await _dbContext.users.ToListAsync();
    //}
    [HttpGet]
    [Route("users")]
    public ActionResult<User> GetAll()
    {

        var result = _dbContext.users.Find();
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }
    public List<User> GetAllUsers()
    {
        List<User> response = new List<User>();
        var dataList = _dbContext.users.ToList();
        dataList.ForEach(row => response.Add(new User()
        {
            UserID = row.UserID,
            TRIdentity = row.TRIdentity,
            Username = row.Username,
            Password = row.Password,
            Fullname = row.Fullname,
            Phone = row.Phone,
            Comment = row.Comment,
        }));
        return response;
    }

    [HttpPost]
    public ActionResult<User> CreateUser([FromBody] User req)
    {
        var domainModelUser = new User
        {
            UserID = req.UserID,
            TRIdentity = req.TRIdentity,
            Username = req.Username,
            Password = req.Password,
            Fullname = req.Fullname,
            Phone = req.Phone,
            Comment = req.Comment
        };
        _dbContext.users.Add(domainModelUser);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetAllUsers), new { id = req.UserID }, req);
    }
}