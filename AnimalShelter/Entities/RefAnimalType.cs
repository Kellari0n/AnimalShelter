using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Entities {
    public class RefAnimalType : IEntity {
        [Key]
        public int ID { get; set; }
        [Required]
        public required string Type { get; set; }

        public override string ToString() {
            return Type;
        }
    }
}