using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class CagesListForm : BaseListForm<Cage> {
        public CagesListForm() {
            InitializeComponent();

            RefreshTable();
        }

        protected override void AddButtonClick(object sender, EventArgs e) {
            var form = new CageForm(ActionType.Create);
            form.FormClosed += (sender, e) => {
                RefreshTable();
                Visible = true;
            };
            Visible = false;
            form.ShowDialog();
        }

        protected override void UpdateButtonClick(object sender, EventArgs e) {
            List<int> ids = GetSelectedEntitiesIds();
            if (ids.Count == 0) {
                MessageBox.Show("Select the entity to update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ids.Count == 1) {
                var form = new CageForm(ActionType.Update, ids.First());
                form.FormClosed += (sender, e) => {
                    RefreshTable();
                    Visible = true;
                };
                Visible = false;
                form.ShowDialog();
            }
            else {
                MessageBox.Show("Please select single entity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void DetailsButtonClick(object sender, EventArgs e) {
            List<int> ids = GetSelectedEntitiesIds();
            if (ids.Count == 0) {
                MessageBox.Show("Select the entity to update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ids.Count == 1) {
                var form = new CageForm(ActionType.Read, ids.First());
                form.FormClosed += (sender, e) => {
                    RefreshTable();
                    Visible = true;
                };
                Visible = false;
                form.ShowDialog();
            }
            else {
                MessageBox.Show("Please select single entity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void RefreshTable() {
            using (var context = new AppDbContext()) {
                _dataGridView.DataSource = context.Cages
                    .Include(c => c.AnimalType)
                    .Include(c => c.Shelter)
                    .ToArray();
            }
            _dataGridView.Columns["AnimalTypeID"].Visible = false;
            _dataGridView.Columns["ShelterID"].Visible = false;
            _dataGridView.Columns["Shelter"].Visible = false;
        }
    }
}
