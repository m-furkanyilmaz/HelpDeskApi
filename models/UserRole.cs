using System.ComponentModel.DataAnnotations;


public class UserRole
{
    [System.ComponentModel.DataAnnotations.Key]
    public int RoleID { get; set; }

    public required int UserId { get; set; }

    public required bool isAdmin { get; set; }

    public required bool canAssignment { get; set; }

    public required bool canQuestion { get; set; }

    public required bool canAsk { get; set; }
}