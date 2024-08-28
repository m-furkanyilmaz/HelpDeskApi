using System.ComponentModel.DataAnnotations;
 
public class QuestionAssignment
{
    [System.ComponentModel.DataAnnotations.Key]
    public int Id { get; set; }

    public required int SoruId { get; set; }

    public required int UserId { get; set; }

    public required bool isAnswered { get; set; }
}
