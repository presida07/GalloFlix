using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeteFlix.Models;

    [Table("Genre")]
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Name { get; set; } 

        public ICollection<MovieGenre> Movies { get; set; }
    }
 