using AnimalShelter.Context;
using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Forms {
    public partial class BaseListForm<EntityT> : TableDesign where EntityT : class {
        public BaseListForm() : base() {
            InitializeComponent();
        }

        protected virtual void AddButtonClick(object sender, EventArgs e) {

        }
        protected virtual void DeleteButtonClick(object sender, EventArgs e) {
            List<int> selectedId = GetSelectedIds();

            if (selectedId.Count == 0) { 
                MessageBox.Show("Select the entity you want to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var res = MessageBox.Show("Are you sure you want to delete these entities", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes) {
                    using (var context = new AppDbContext()) {
                        context.Set<EntityT>().RemoveRange(context.Set<EntityT>().Where(e => selectedId.Contains(((IEntity)e).ID)));
                        context.SaveChanges();
                    }
                }
            }
            RefreshTable();
        }
        protected virtual void UpdateButtonClick(object sender, EventArgs e) {

        }
        protected virtual void DetailsButtonClick(object sender, EventArgs e) {

        }
        protected virtual void RefreshButtonClick(object sender, EventArgs e) {
            RefreshTable();
        }
        protected virtual void BackButtonClick(object sender, EventArgs e) {
            Close();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            RefreshTable();    
        }

        protected virtual async void RefreshTable() {
            using (var context = new AppDbContext()) {
                _dataGridView.DataSource = await context.Set<EntityT>().ToListAsync();
            }
        }

        protected List<int> GetSelectedIds() {
            List<int> selectedRows = new();
            for (int i = 0; i < _dataGridView.SelectedCells.Count; i++) {
                if (!selectedRows.Contains(_dataGridView.SelectedCells[i].RowIndex)) {
                    selectedRows.Add(_dataGridView.SelectedCells[i].RowIndex);
                }
            }

            List<int> selectedIds = new();
            foreach (int i in selectedRows) {
                selectedIds.Add((int)_dataGridView.Rows[i].Cells[0].Value);
            }

            return selectedIds;
        }
    }
}
