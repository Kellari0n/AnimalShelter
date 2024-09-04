using AnimalShelter.Context;
using AnimalShelter.Entities;
using AnimalShelter.Forms.Animals;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class CageForm : Form {
        private readonly int _entityID;
        public CageForm(ActionType action, int entityID = 0) {
            InitializeComponent();
            _entityID = entityID;

            switch (action) {
                case ActionType.Create:
                    _actionButton.Text = "Create";
                    _actionButton.Click += Create;

                    FillBoxes(entityID, false);
                    break;
                case ActionType.Read:
                    _numberBox.ReadOnly = true;
                    _maxCapacityBox.ReadOnly = true;
                    _typeBox.Enabled = false;
                    _addTypeButton.Enabled = false;
                    _actionButton.Text = "Show animals";
                    _actionButton.Click += ShowAnimals;

                    FillBoxes(entityID, true);
                    break;
                case ActionType.Update:
                    _actionButton.Text = "Update";
                    _actionButton.Click += Update;

                    FillBoxes(entityID, false);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void FillBoxes(int entityID, bool isReadOnly = false) {
            using (var context = new AppDbContext()) {
                if (entityID != 0) {
                    var entity = context.Cages.Include(c => c.AnimalType).First(c => c.ID == entityID);

                    _numberBox.Text = entity.CageNumber.ToString();
                    _maxCapacityBox.Text = entity.MaxCapacity.ToString();

                    if (isReadOnly) {
                        _typeBox.Items.Add(context.RefAnimalType.First(at => at.ID == entity.AnimalTypeID));
                        _typeBox.SelectedIndex = 0;
                    }
                    else {
                        _typeBox.Items.AddRange(context.RefAnimalType.ToArray());
                        _typeBox.SelectedItem = entity.AnimalType;
                    }
                }
                else {
                    if (!isReadOnly) {
                        _typeBox.Items.AddRange(context.RefAnimalType.ToArray());
                    }
                }
            }
        }

        private bool TryCreateEntityFromForm(out Cage? entity) {
            entity = null;

            if (!int.TryParse(_numberBox.Text, out int number )) { return false; }

            if (!int.TryParse(_maxCapacityBox.Text, out int maxCapacity)) { return false; }

            var animalType = (_typeBox.SelectedItem as RefAnimalType);

            if (animalType == null) { return false; }

            entity = new Cage { CageNumber = number, AnimalTypeID = animalType.ID, MaxCapacity = maxCapacity };

            return true;
        }

        private void ShowAnimals(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void Create(object? sender, EventArgs e) {
            if (TryCreateEntityFromForm(out Cage? entity)) {
                using (var context = new AppDbContext()) {
                    if (context.Cages.Where(c => c!.CageNumber == entity!.CageNumber).AsEnumerable().FirstOrDefault(defaultValue: null) != null) {
                        MessageBox.Show("A cage with this number already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    context.Cages.Add(entity!);
                    context.SaveChanges();
                }
            }
            else {
                MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Close();
        }

        private void Update(object? sender, EventArgs e) {
            if (TryCreateEntityFromForm(out Cage? entity)) {
                using (var context = new AppDbContext()) {
                    if (context.Cages.Where(c => c!.ID != _entityID && c!.CageNumber == entity!.CageNumber).AsEnumerable().FirstOrDefault(defaultValue: null) != null) {
                        MessageBox.Show("A cage with this number already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var oldEntity = context.Cages.First(c => c.ID == _entityID);

                    if (oldEntity.AnimalTypeID != entity!.AnimalTypeID && oldEntity.OccupiedCapacity != 0) {
                        MessageBox.Show("Release the cage before changing the animal type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    oldEntity.CageNumber = entity!.CageNumber;
                    oldEntity.AnimalTypeID = entity.AnimalTypeID;
                    oldEntity.MaxCapacity = entity.MaxCapacity;

                    context.Cages.Update(oldEntity);
                    context.SaveChanges();
                }
            }
            else {
                MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Close();
        }

        private void Back(object sender, EventArgs e) {
            Close();
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
