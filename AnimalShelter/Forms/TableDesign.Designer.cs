namespace AnimalShelter.Forms
{
    partial class TableDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            _dataGridView = new DataGridView();
            _addButton = new Button();
            _deleteButton = new Button();
            _updateButton = new Button();
            _refreshButton = new Button();
            _backButton = new Button();
            _detailsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // _dataGridView
            // 
            _dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridView.Location = new Point(12, 12);
            _dataGridView.Name = "_dataGridView";
            _dataGridView.ReadOnly = true;
            _dataGridView.Size = new Size(776, 397);
            _dataGridView.TabIndex = 0;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(313, 416);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(75, 23);
            _addButton.TabIndex = 1;
            _addButton.Text = "Add";
            _addButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(413, 416);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(75, 23);
            _deleteButton.TabIndex = 2;
            _deleteButton.Text = "Delete";
            _deleteButton.UseVisualStyleBackColor = true;
            // 
            // _updateButton
            // 
            _updateButton.Location = new Point(513, 416);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(75, 23);
            _updateButton.TabIndex = 3;
            _updateButton.Text = "Update";
            _updateButton.UseVisualStyleBackColor = true;
            // 
            // _refreshButton
            // 
            _refreshButton.Location = new Point(713, 416);
            _refreshButton.Name = "_refreshButton";
            _refreshButton.Size = new Size(75, 23);
            _refreshButton.TabIndex = 9;
            _refreshButton.Text = "Refresh";
            _refreshButton.UseVisualStyleBackColor = true;
            // 
            // _backButton
            // 
            _backButton.Location = new Point(12, 416);
            _backButton.Name = "_backButton";
            _backButton.Size = new Size(75, 23);
            _backButton.TabIndex = 10;
            _backButton.Text = "Back";
            _backButton.UseVisualStyleBackColor = true;
            // 
            // _detailsButton
            // 
            _detailsButton.Location = new Point(613, 416);
            _detailsButton.Name = "_detailsButton";
            _detailsButton.Size = new Size(75, 23);
            _detailsButton.TabIndex = 8;
            _detailsButton.Text = "Details";
            _detailsButton.UseVisualStyleBackColor = true;
            // 
            // TableDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(_backButton);
            Controls.Add(_refreshButton);
            Controls.Add(_detailsButton);
            Controls.Add(_updateButton);
            Controls.Add(_deleteButton);
            Controls.Add(_addButton);
            Controls.Add(_dataGridView);
            MaximizeBox = false;
            MaximumSize = new Size(820, 500);
            MinimumSize = new Size(820, 500);
            Name = "TableDesign";
            Text = "List";
            ((System.ComponentModel.ISupportInitialize)_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected DataGridView _dataGridView;
        protected Button _addButton;
        protected Button _deleteButton;
        protected Button _updateButton;
        protected Button _refreshButton;
        protected Button _backButton;
        protected Button _detailsButton;
    }
}