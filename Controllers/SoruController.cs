using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class SoruController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public SoruController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Question>> GetSoru()
    {
        return _dbContext.questions.ToList();
    }

    [HttpGet("SoruId")]
    public ActionResult<Question> GetSoruById(int id)
    {
        var result = _dbContext.questions.Find(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }

    [HttpPost]
    public ActionResult<Question> CreateSoru([FromBody] Question req)
    {
        _dbContext.questions.Add(req);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetSoruById), new { id = req.SoruId }, req);
    }

    //[HttpPut("{id}")]
    //public IActionResult UpdateSoru(int id, [FromBody] soru updatedTodo)
    //{
    //    var todo = _dbContext.Todos.Find(id);
    //    if (todo == null)
    //    {
    //        return NotFound();
    //    }

    //    todo.Title = updatedTodo.Title;
    //    _dbContext.SaveChanges();
    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //public IActionResult DeleteTodo(int id)
    //{
    //    var todo = _dbContext.Todos.Find(id);
    //    if (todo == null)
    //    {
    //        return NotFound();
    //    }

    //    _dbContext.Todos.Remove(todo);
    //    _dbContext.SaveChanges();
    //    return NoContent();
    //}
}