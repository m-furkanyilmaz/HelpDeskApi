using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public required int SoruId { get; set; }

        public required int UserId { get; set; }

        public required string Username { get; set; }

        public required string answer { get; set; }
        public string Institute { get; set; } = string.Empty;
    }
