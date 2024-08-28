using System.ComponentModel.DataAnnotations;


public class User
{

    [System.ComponentModel.DataAnnotations.Key]
    public int UserID { get; set; }         

    public required int TRIdentity { get; set; }

    public required string Username { get; set; }

    public required string Password { get; set; }

    public required string Fullname { get; set; }

    public required string Phone { get; set; }

    public required string Comment { get; set; }
}
