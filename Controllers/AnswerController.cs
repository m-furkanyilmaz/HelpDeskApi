using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AnswerController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public AnswerController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //[HttpGet]
    //public ActionResult<IEnumerable<soru>> GetSorus()
    //{
    //    return _dbContext.sorus.ToList();
    //}

    [HttpGet("Id")]
    public ActionResult<Answer> GetAnswerById(int id)
    {
        var result = _dbContext.answers.Find(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }

    [HttpPost]
    public ActionResult<Answer> CreateAnswer([FromBody] Answer req)
    {
        _dbContext.answers.Add(req);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetAnswerById), new { id = req.Id }, req);
    }
}