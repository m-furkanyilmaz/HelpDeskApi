using System.ComponentModel.DataAnnotations;

public class QuestionAssignment
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public int SoruId { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public bool isAnswered { get; set; }
}