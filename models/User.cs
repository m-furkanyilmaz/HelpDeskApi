using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    [Required]
    public int UserID { get; set; }         
    [Required]
    public int TRIdentity { get; set; } = 0;
    [Required]
    public string Username { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
    [Required]
    public string Fullname { get; set; } = string.Empty;
    [Required]
    public string Phone { get; set; } = string.Empty;
    [Required]
    public string Comment { get; set; } = string.Empty;
}