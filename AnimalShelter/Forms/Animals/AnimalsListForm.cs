using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class AnimalsListForm : BaseListForm<Animal> {
        public AnimalsListForm() {
            InitializeComponent();
        }

        protected override void AddButtonClick(object sender, EventArgs e) {
            base.AddButtonClick(sender, e);

            var form = new AnimalForm(ActionType.Create);
            form.FormClosed += (sender, e) => {
                RefreshTable();
                Visible = true;
            };
            Visible = false;
            form.ShowDialog();
        }

        protected override void DeleteButtonClick(object sender, EventArgs e) {
            List<int> selectedId = GetSelectedIds();

            if (selectedId.Count == 0) {
                MessageBox.Show("Select the entity you want to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var res = MessageBox.Show("Are you sure you want to delete these entities", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes) {
                    using (var context = new AppDbContext()) {
                        var animals = context.Animals.Where(e => selectedId.Contains(e.ID));
                        var cages = animals.Select(a => a.Cage);
                        foreach (var cage in cages) {
                            cage.OccupiedCapacity--;
                        }
                        context.Cages.UpdateRange(cages);
                        context.Animals.RemoveRange(animals);
                        context.SaveChanges();
                    }
                }
            }
            RefreshTable();
        }

        protected override void UpdateButtonClick(object sender, EventArgs e) {
            base.UpdateButtonClick(sender, e);

            List<int> ids = GetSelectedIds();
            if (ids.Count == 0) {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ids.Count == 1) {
                var form = new AnimalForm(ActionType.Update, ids.First());
                form.FormClosed += (sender, e) => {
                    RefreshTable();
                    Visible = true;
                };
                Visible = false;
                form.ShowDialog();
            }
            else {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void DetailsButtonClick(object sender, EventArgs e) {
            base.DetailsButtonClick(sender, e);

            List<int> ids = GetSelectedIds();
            if (ids.Count == 0) {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ids.Count == 1) {
                var form = new AnimalForm(ActionType.Read, ids.First());
                form.FormClosed += (sender, e) => {
                    RefreshTable();
                    Visible = true;
                };
                Visible = false;
                form.ShowDialog();
            }
            else {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void RefreshTable() {
            using (var context = new AppDbContext()) {
                _dataGridView.DataSource = 
                    context.Animals
                    .Include(a => a.Cage)
                    .Include(a => a.AnimalType)
                    .ToArray();
            }
        }
    }
}
