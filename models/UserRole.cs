using System.ComponentModel.DataAnnotations;

public class UserRole
{
    [Key]
    [Required]
    public int RoleID { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public bool isAdmin { get; set; }
    [Required]
    public bool canAssignment { get; set; }
    [Required]
    public bool canQuestion { get; set; }
    [Required]
    public bool canAsk { get; set; }
}