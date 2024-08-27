using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class SoruAtamaController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public SoruAtamaController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //[HttpGet]
    //public ActionResult<IEnumerable<soru>> GetSorus()
    //{
    //    return _dbContext.sorus.ToList();
    //}

    [HttpGet("Id")]
    public ActionResult<QuestionAssignment> GetAtananSoruById(int id)
    {
        var result = _dbContext.questionassignments.Find(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }

    [HttpPost]
    public ActionResult<QuestionAssignment> CreateSoruAtama([FromBody] QuestionAssignment req)
    {
        _dbContext.questionassignments.Add(req);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetAtananSoruById), new { id = req.Id }, req);
    }
}