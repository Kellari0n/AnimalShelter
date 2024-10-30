using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class IncomeReportForm : Form {
        public IncomeReportForm() {
            InitializeComponent();

            var _months = new[] {
                "All Year",
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            _monthBox.Items.AddRange(_months);
            _monthBox.SelectedIndex = 0;
            _yearBox.Text = DateTime.Now.Year.ToString();
        }

        private void GenerateButtonClick(object sender, EventArgs e) {
            using (var context = new AppDbContext()) {
                if (!int.TryParse(_yearBox.Text, out int year)) {
                    MessageBox.Show("Please ensure that all fields are filled out correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var adoptionsQuery = context.Adoptions
                    .Include(a => a.Animal)
                    .Where(a => a.AdoptionDate.Year == year);

                if (_monthBox.SelectedIndex != 0) {
                    adoptionsQuery = adoptionsQuery
                        .Where(a => a.AdoptionDate.Month == _monthBox.SelectedIndex);
                }

                var adoptions = adoptionsQuery.ToList();

                adoptions.Add(new Adoption { AdoptionFee = adoptions.Sum(a => a.AdoptionFee) });
                _dataGridView.DataSource = adoptions;
                _dataGridView.Columns["AnimalID"].Visible = false;
            }
        }

        private void BackButtonClick(object sender, EventArgs e) {
            Close();
        }
    }
}