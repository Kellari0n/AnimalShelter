using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class IncomeReportForm : Form {
        public IncomeReportForm() {
            InitializeComponent();

            _timePeriodBox.Items.AddRange(["Year", "Month"]);
        }

        private void GenerateButtonClick(object sender, EventArgs e) {
            using (var context = new AppDbContext()) { 
                List<Adoption> adoptions = new List<Adoption>();
                if (_timePeriodBox.SelectedIndex == 0) {
                    if (!int.TryParse(_timeBox.Text, out int year)) {
                        MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    adoptions = context.Adoptions.Include(a => a.Animal).Where(a => a.AdoptionDate.Year == year).ToList();
                }
                else if (_timePeriodBox.SelectedIndex == 0) {
                    if (!int.TryParse(_timeBox.Text, out int month)) {
                        MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    adoptions = context.Adoptions.Include(a => a.Animal).Where(a => a.AdoptionDate.Month == month).ToList();
                }

                adoptions.Add(new Adoption { AdoptionFee = adoptions.Sum(a => a.AdoptionFee) });
                _dataGridView.DataSource = adoptions;
                _dataGridView.Columns["AnimalID"].Visible = false;
            }
        }

        private void TimePeriodBoxSelectedIndexChanged(object sender, EventArgs e) {
            if (_timePeriodBox.SelectedIndex == 0) {
                _timeLabel.Text = "Year:";
                _timeBox.Text = DateTime.Now.Year.ToString();
            }
            else if (_timePeriodBox.SelectedIndex == 1) {
                _timeLabel.Text = "Month:";
                _timeBox.Text = DateTime.Now.Month.ToString();
            }
        }
    }
}
