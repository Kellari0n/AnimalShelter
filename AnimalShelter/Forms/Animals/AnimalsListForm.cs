using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class AnimalsListForm : BaseListForm<Animal> {
        public AnimalsListForm() {
            InitializeComponent();

            _dataGridView.Click += (sender, e) => {
                var rowIds = GetSelectedRowsIds();
                var animalId = GetSelectedEntitiesIds().First();

                if (rowIds.Count == 1) {
                    _adoptionButton.Visible = true;
                    var t = _dataGridView.Rows[rowIds.First()].Cells["IsAdopted"].Value;
                    if (_dataGridView.Rows[rowIds.First()].Cells["IsAdopted"].Value is true) {
                        _adoptionButton.Text = "Return";
                        _adoptionButton.Click += (sender, e) => {
                            using (var context = new AppDbContext()) {
                                var animal = context.Animals.Include(a => a.Cage).First(a => a.ID == animalId);
                                animal.IsAdopted = false;
                                animal.AdoptionDate = null;
                                context.Update(animal);

                                var adoption = context.Adoptions.First(a => a.AnimalID == animalId);
                                context.Remove(adoption);

                                if (animal.Cage.OccupiedCapacity < animal.Cage.MaxCapacity) {
                                    animal.Cage.OccupiedCapacity++;
                                }
                                else {
                                    MessageBox.Show("This cage is full.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                context.SaveChanges();
                            }
                            RefreshTable();
                            _adoptionButton.Visible = false;
                        };
                    }
                    else {
                        _adoptionButton.Text = "Adopt";
                        _adoptionButton.Click += (sender, e) => {
                            var form = new AdoptionForm(animalId);
                            form.FormClosed += (sender, e) => {
                                RefreshTable();
                                Visible = true;
                            };
                            Visible = false;
                            form.ShowDialog();

                            RefreshTable();
                            _adoptionButton.Visible = false;
                        };
                    }
                }
                else {
                    _adoptionButton.Visible = false;
                }
            };
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
            List<int> selectedId = GetSelectedEntitiesIds();

            if (selectedId.Count == 0) {
                MessageBox.Show("Select the animal you want to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            List<int> ids = GetSelectedEntitiesIds();
            if (ids.Count == 0) {
                MessageBox.Show("Select the animal to update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Please select single animal", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void DetailsButtonClick(object sender, EventArgs e) {
            base.DetailsButtonClick(sender, e);

            List<int> ids = GetSelectedEntitiesIds();
            if (ids.Count == 0) {
                MessageBox.Show("Select the animal to update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Please select single animal", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdoptionButtonClick(object sender, EventArgs e) {

        }

        protected override void RefreshTable() {
            using (var context = new AppDbContext()) {
                _dataGridView.DataSource = 
                    context.Animals
                    .Include(a => a.Cage)
                    .Include(a => a.AnimalType)
                    .ToArray();
            }
            _dataGridView.Columns["AnimalTypeID"].Visible = false;
            _dataGridView.Columns["CageID"].Visible = false;
            _dataGridView.Columns["PhotoUrl"].Visible = false;
        }
    }
}
