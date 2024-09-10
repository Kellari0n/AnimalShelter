using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AnimalShelter.Forms {
    public partial class AdoptionForm : Form {
        private readonly int _animalId;
        public AdoptionForm(int animalId) {
            InitializeComponent();

            _animalId = animalId;
            _dateBox.Text = DateTime.Now.ToString();
        }

        public bool TryCreateFromForm(out Adoption? result) {
            result = null;

            if (!DateTime.TryParse(_dateBox.Text, out DateTime date)) {
                return false;
            }

            if (!decimal.TryParse(_feeBox.Text, out decimal fee)) {
                return false;
            }

            if (_nameBox.Text.IsNullOrEmpty()) {
                return false;
            }

            if (_dateBox.Text.IsNullOrEmpty()) {
                return false;
            }

            if (_contactsBox.Text.IsNullOrEmpty()) {
                return false;
            }

            result = new Adoption {
                AnimalID = _animalId,
                AdopterName = _nameBox.Text,
                AdoptionDate = date,
                AdoptionFee = fee,
                AdopterContact = _contactsBox.Text
            };

            return true;
        }

        public void AdoptButtonClick(object sender, EventArgs e) {
            if (TryCreateFromForm(out Adoption? result)) {
                using (var context = new AppDbContext()) {
                    Animal animal = context.Animals.Include(a => a.Cage).First(a => a.ID == _animalId);

                    context.Adoptions.Add(result!);
                    animal.AdoptionDate = result!.AdoptionDate;
                    animal.IsAdopted = true;
                    animal.Cage.OccupiedCapacity--;
                    context.Cages.Update(animal.Cage);
                    context.Animals.Update(animal);
                    context.SaveChanges();
                }
                Close();
            }
            else {
                MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CancelButtonClick(object sender, EventArgs e) {
            Close();
        }
    }
}
