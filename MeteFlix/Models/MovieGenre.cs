using System.ComponentModel.DataAnnotations.Schema;

namespace MeteFlix.Models;
[Table("MovieGenre")]

    public class MovieGenre
    {
        [Key, Column(Order = 1)]
        public int MovieId { get; set; }
        [foreignKey("MovieId")]
        public Movie Movie { get; set; }

        [Key, Column(Order = 2)]
        public byte GenreId { get; set; }
        [foreignKey("GenreId")]
        public Genre Genre { get; set; }




    }
