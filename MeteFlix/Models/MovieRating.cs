using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeteFlix.Models;
[Table("MovieRating")]

    public class MovieRating
    {
        [Key, Column(Order = 1)]
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]

        public Movie Movie { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }

        [Required]
        public byte RatingValue { get; set; }

        [Required]
        public DateTime RatingDate { get; set; } = DateTime.Now; 
    }
