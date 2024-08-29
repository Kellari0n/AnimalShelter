using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Entities {
    public class Shelter : IEntity {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(256)]
        public string Location { get; set; } = string.Empty;

        public List<Cage> Cages { get; set; } = [];

        public List<Animal> Animals { get; set; } = [];
    }
}