using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelter.Entities {
    public class Animal : IEntity {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        [MaxLength(64)]
        public string Breed { get; set; }

        [Url]
        [MaxLength(64)]
        public string PhotoUrl { get; set; }

        [Required]
        public required DateTime ArrivalDate { get; set; }

        public DateTime? AdoptionDate { get; set; }

        [Required]
        public bool IsAdopted { get; set; } = false;

        [ForeignKey("Cage")]
        public required int CageID { get; set; }

        [Required]
        public Cage Cage { get; set; }
    }
}