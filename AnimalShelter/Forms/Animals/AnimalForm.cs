using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AnimalShelter.Forms {
    public partial class AnimalForm : Form {
        private string? _photoUrl;
        private readonly string _defaultPhotoUrl;
        private readonly int _entityId;
        private readonly string _projectDirectory;

        public AnimalForm(ActionType action, int entityID = 0) {
            InitializeComponent();

            _entityId = entityID;
            _projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName!;
            _defaultPhotoUrl = "Photos\\placeholder-image-blue.gif";

            switch (action) {
                case ActionType.Create:
                    _actionButton.Text = "Create";
                    _actionButton.Click += Create;
                    _adoptionDateLabel.Visible = false;
                    _adoptionDateBox.Visible = false;

                    _arrivalDateBox.Text = DateTime.Now.ToString();

                    FillBoxes(entityID, false);
                    break;
                case ActionType.Read:
                    _nameBox.ReadOnly = true;
                    _typeBox.Enabled = false;
                    _breedBox.ReadOnly = true;
                    _cageBox.Enabled = false;
                    _arrivalDateBox.ReadOnly = true;
                    _adoptionDateBox.ReadOnly = true;
                    _actionButton.Enabled = false;
                    _actionButton.Visible = false;

                    _setImageButton.Visible = false;

                    FillBoxes(entityID, true);
                    break;
                case ActionType.Update:
                    _actionButton.Text = "Update";
                    _actionButton.Click += Update;
                    _cageBox.Enabled = false;

                    FillBoxes(entityID, false);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
        private void FillBoxes(int entityID, bool isReadOnly = false) {
            using (var context = new AppDbContext()) {
                if (entityID != 0) {
                    var entity = context.Animals
                        .Include(a => a.AnimalType)
                        .Include(a => a.Cage)
                        .Where(a => a.ID == entityID)
                        .FirstOrDefault();

                    if (entity != null) {
                        _nameBox.Text = entity.Name;
                        _typeBox.Text = entity.AnimalType.Type;
                        _breedBox.Text = entity.Breed;
                        _photoUrl = _projectDirectory + "\\" + entity.PhotoUrl;
                        _cageBox.Text = entity.Cage.CageNumber.ToString();
                        _arrivalDateBox.Text = entity.ArrivalDate.ToString();
                        if (entity.AdoptionDate == null) {

                        }
                        else {
                            _adoptionDateBox.Text = entity.AdoptionDate.Value.ToString();
                        }


                        try {
                            _imageBox.Load(_photoUrl);
                        }
                        catch {
                            _imageBox.Load(_projectDirectory + "\\" + _defaultPhotoUrl);
                        }
                    }
                    else {
                        MessageBox.Show("The entity could not be found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!isReadOnly) {
                        _typeBox.Items.AddRange(context.RefAnimalType.ToArray());
                        _cageBox.Items.AddRange(context.Cages.ToArray());
                    }
                    else {
                        _typeBox.Items.Add(context.RefAnimalType.First(at => at.ID == entity.AnimalTypeID));
                        _typeBox.SelectedIndex = 0;

                        _cageBox.Items.Add(context.Cages.First(c => c.ID == entity.CageID));
                        _cageBox.SelectedIndex = 0;
                    }
                }
                else {
                    _imageBox.Load(_projectDirectory + "\\" + _defaultPhotoUrl);
                }
            }
        }
        private void SetImageButtonClick(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG(*.jpg)|*.jpg|SVG(*.svg)|*.svg|PNG(*png)|*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                _photoUrl = fileDialog.FileName;
                try {
                    _imageBox.Load(_photoUrl);
                }
                catch {
                    _imageBox.Load(_defaultPhotoUrl);
                    _photoUrl = string.Empty;
                }
            }
        }
        private bool TryCreateEntityFromForm(out Animal? entity) {
            entity = null;

            string name = _nameBox.Text;
            if (string.IsNullOrEmpty(name)) { return false; }

            string breed = _breedBox.Text;

            if (!DateTime.TryParse(_arrivalDateBox.Text, out DateTime arrivalDate)) {
                return false;
            }

            if (!DateTime.TryParse(_adoptionDateBox.Text, out DateTime adoptionDate)) {

            }

            Cage? cage = _cageBox.SelectedItem as Cage;
            if (cage is null) { return false; }

            RefAnimalType? animalType = _typeBox.SelectedItem as RefAnimalType;
            if (animalType is null) { return false; }

            entity = new Animal {
                Name = name,
                AnimalType = animalType,
                AnimalTypeID = animalType.ID,
                Breed = breed,
                Cage = cage,
                CageID = cage.ID,
                ArrivalDate = arrivalDate,
                AdoptionDate = adoptionDate,
                PhotoUrl = "Photos\\animal" + _entityId
            };

            if (_photoUrl.IsNullOrEmpty()) {
                entity.PhotoUrl = string.Empty;
            }

            return true;
        }
        private void Create(object? sender, EventArgs e) {
            if (TryCreateEntityFromForm(out Animal? entity)) {
                if (entity!.Cage.AnimalType != entity.AnimalType) {
                    MessageBox.Show("This cage is intended for other animals.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (entity.Cage.OccupiedCapacity >= entity.Cage.MaxCapacity) {
                    MessageBox.Show("This cage is full.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                entity.AnimalType = null!;

                using (var context = new AppDbContext()) {
                    entity.Cage.OccupiedCapacity++;
                    context.Cages.Update(entity.Cage);
                    entity.Cage = null!;
                    context.Animals.Add(entity);
                    context.SaveChanges();
                }

                if (!_photoUrl.IsNullOrEmpty()) {
                    File.Copy(_photoUrl!, _projectDirectory + "\\Photos\\animal" + _entityId, true);
                }
                Close();
            }
            else {
                MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Update(object? sender, EventArgs e) {
            if (TryCreateEntityFromForm(out Animal? entity)) {
                if (entity!.Cage.OccupiedCapacity >= entity.Cage.MaxCapacity) {
                    MessageBox.Show("This cage is full.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (entity.Cage.AnimalType != entity.AnimalType) {
                    MessageBox.Show("This cage is intended for other animals.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                using (var context = new AppDbContext()) {
                    var oldEntity = context.Animals.Include(a => a.Cage).Include(a => a.Cage.Animals).FirstOrDefault(a => a.ID == _entityId);
                    if (oldEntity is not null) {
                        oldEntity.Name = entity!.Name;
                        oldEntity.AnimalTypeID = entity.AnimalTypeID;
                        oldEntity.Breed = entity.Breed;
                        oldEntity.CageID = entity.CageID;
                        oldEntity.ArrivalDate = entity.ArrivalDate;
                        oldEntity.AdoptionDate = entity.AdoptionDate;

                        context.Animals.Update(oldEntity);
                        context.SaveChanges();
                    }
                }

                if (!_photoUrl.IsNullOrEmpty() && _photoUrl != _projectDirectory + "\\Photos\\animal" + _entityId)
                    File.Copy(_photoUrl!, _projectDirectory + "\\Photos\\animal" + _entityId, true);
                Close();
            }
            else {
                MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Back(object sender, EventArgs e) {
            Close();
        }
    }
}