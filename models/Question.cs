using System.ComponentModel.DataAnnotations;

    public class Question
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int SoruId { get; set; }

        public required string Soru { get; set; }

        public required int UserId { get; set; }

        public required string RecordTime { get; set; }

    }
