using System.ComponentModel.DataAnnotations;

public class Answer
{
    [Key]
    [Required]
    public int Id{ get; set; }
    [Required]
    public int SoruId { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public string Username { get; set; } = string.Empty;
    [Required]
    public string answer {  get; set; } = string.Empty;
    public string Institute { get; set; } = string.Empty ;
}