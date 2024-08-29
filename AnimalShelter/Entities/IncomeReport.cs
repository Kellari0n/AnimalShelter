using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Entities {
    public class IncomeReport : IEntity {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Month { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal TotalIncome { get; set; }

        [ForeignKey("Shelter")]
        public int ShelterID { get; set; }

        public Shelter Shelter { get; set; } = null!;
    }
}