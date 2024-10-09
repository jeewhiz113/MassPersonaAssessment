using System.ComponentModel.DataAnnotations;

namespace MassPersonaAssessment.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string Title {  get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string ReviewText { get; set; }

        [Required]
        public int Rating { get; set; }

        public DateTime DateReviewed {  get; set; }
    }
}
