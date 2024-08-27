using System.ComponentModel.DataAnnotations;

public class Question
{
    [Key]
    [Required]
    public int SoruId { get; set; }
	[Required]
    public string Soru { get; set; } = string.Empty;
    [Required]
    public int UserId { get; set; }
    [Required]
    public string RecordTime { get; set; } = string.Empty;
    
}