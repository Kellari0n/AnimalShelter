using AnimalShelter.Context;
using AnimalShelter.Forms.Animals;

namespace AnimalShelter.Forms {
    public partial class CageForm : Form {
        public CageForm() {
            InitializeComponent();
        }

        public void RefreshTypeBox() {
            using (var context = new AppDbContext()) {
                _typeBox.Items.AddRange(context.RefAnimalType.ToArray());
            }
        }

        private void AddTypeButtonClick(object? sender, EventArgs e) {
            var form = new AddAnimalTypeForm();
            form.FormClosed += (sender, e) => {
                RefreshTypeBox();
                Visible = true;
            };
            Visible = false;
            form.ShowDialog();
        }
    }
}
