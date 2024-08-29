using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Entities {
    public class Adoption : IEntity {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Animal")]
        public int AnimalID { get; set; }

        [Required]
        public DateTime AdoptionDate { get; set; }

        [Required]
        public decimal AdoptionFee { get; set; }

        [Required]
        [MaxLength(64)]
        public string AdopterName { get; set; } = string.Empty;

        [Required]
        [MaxLength(64)]
        public string AdopterContact { get; set; } = string.Empty;

        public Animal Animal { get; set; } = null!;
    }
}