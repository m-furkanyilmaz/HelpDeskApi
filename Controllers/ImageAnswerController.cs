using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ImageAnswerController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public ImageAnswerController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //[HttpGet]
    //public ActionResult<IEnumerable<soru>> GetSorus()
    //{
    //    return _dbContext.sorus.ToList();
    //}

    [HttpGet("Id")]
    public ActionResult<ImageAnswer> GetImageAnswerById(int id)
    {
        var result = _dbContext.imageanswers.Find(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }

    [HttpPost]
    public ActionResult<ImageAnswer> CreateImageAnswer([FromBody] ImageAnswer req)
    {
        _dbContext.imageanswers.Add(req);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetImageAnswerById), new { id = req.Id }, req);
    }
}