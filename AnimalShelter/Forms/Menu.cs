using AnimalShelter.Forms;

namespace AnimalShelter {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
        }

        public void AnimalButtonClick(object sender, EventArgs e) {
            var form = new AnimalsListForm();
            form.FormClosed += (sender, e) => {
                Visible = true;
            };
            Visible = false;
            form.ShowDialog();
        }

        public void CagesButtonClick(object sender, EventArgs e) {
            var form = new CagesListForm();
            form.FormClosed += (sender, e) => {
                Visible = true;
            };
            Visible = false;
            form.ShowDialog();
        }

        public void ReportsButtonClick(object sender, EventArgs e) {
            var form = new IncomeReportsListForm();
            form.FormClosed += (sender, e) => {
                Visible = true;
            };
            Visible = false;
            form.ShowDialog();
        }
    }
}
