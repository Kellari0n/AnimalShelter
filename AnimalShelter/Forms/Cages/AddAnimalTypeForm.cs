using AnimalShelter.Context;
using AnimalShelter.Entities;

namespace AnimalShelter.Forms.Animals {
    public partial class AddAnimalTypeForm : Form {
        public AddAnimalTypeForm() {
            InitializeComponent();
        }

        public void AddButtonClick(object sender, EventArgs e) {
            var type = new RefAnimalType() { Type = _typeBox.Text };

            using (AppDbContext dbContext = new AppDbContext()) {
                dbContext.Add(type);
                dbContext.SaveChanges();
            }
            Close();
        }

        public void CancelButtonClick(object sender, EventArgs e) {
            Close();
        }
    }
}
