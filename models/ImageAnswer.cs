using System.ComponentModel.DataAnnotations;

public class ImageAnswer
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public int SoruId { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public string Image { get; set; } = string.Empty;
    
}