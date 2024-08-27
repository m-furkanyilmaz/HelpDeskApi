using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UserRoleController : ControllerBase
{
	private readonly AppDbContext _dbContext;

	public UserRoleController(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	//[HttpGet]
	//public ActionResult<IEnumerable<soru>> GetSorus()
	//{
	//    return _dbContext.sorus.ToList();
	//}

	[HttpGet("RoleId")]
	public ActionResult<UserRole> GetUserRoleById(int id)
	{
		var result = _dbContext.userroles.Find(id);
		if (result == null)
		{
			return NotFound();
		}
		return result;
	}

	[HttpPost]
	public ActionResult<UserRole> CreateSoru([FromBody] UserRole req)
	{
		_dbContext.userroles.Add(req);
		_dbContext.SaveChanges();
		return CreatedAtAction(nameof(GetUserRoleById), new { id = req.RoleID }, req);
	}
}