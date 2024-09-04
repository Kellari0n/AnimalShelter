using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelter.Entities {
    public class Cage : IEntity {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CageNumber { get; set; }

        [Required]
        public int MaxCapacity { get; set; } = 1;

        public int OccupiedCapacity { get; set; }

        [ForeignKey("Shelter")]
        public int ShelterID { get; set; } = 1;
        public Shelter Shelter { get; set; } = null!;

        [Required]
        [ForeignKey("AnimalType")]
        public required int AnimalTypeID { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public RefAnimalType AnimalType { get; set; } = null!; 

        public List<Animal> Animals { get; set; } = [];

        public override string ToString() {
            return CageNumber.ToString();
        }
    }
}