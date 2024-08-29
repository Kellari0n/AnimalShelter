using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Entities {
    public class Cage : IEntity {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CageNumber { get; set; }

        [Required]
        public int MaxCapacity { get; set; } = 1;

        public int OccupiedCapacity { get; set; } = 0;

        public List<Animal> Animals { get; set; } = [];
    }
}