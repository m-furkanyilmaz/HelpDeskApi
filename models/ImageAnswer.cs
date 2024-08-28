using System.ComponentModel.DataAnnotations;

    public class ImageAnswer
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public required int SoruId { get; set; }

        public required int UserId { get; set; }

        public required string Image { get; set; }

    }
