using System.Windows.Forms;

namespace AnimalShelter.Forms {
    partial class IncomeReportForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            _backButton = new Button();
            _timePeriodBox = new ComboBox();
            _generateButton = new Button();
            _timeBox = new TextBox();
            _timeLabel = new Label();
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
            // _backButton
            // 
            _backButton.Location = new Point(12, 416);
            _backButton.Name = "_backButton";
            _backButton.Size = new Size(75, 23);
            _backButton.TabIndex = 10;
            _backButton.Text = "Back";
            _backButton.UseVisualStyleBackColor = true;
            // 
            // _timePeriodBox
            // 
            _timePeriodBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            _timePeriodBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _timePeriodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _timePeriodBox.FormattingEnabled = true;
            _timePeriodBox.Location = new Point(390, 416);
            _timePeriodBox.Name = "_timePeriodBox";
            _timePeriodBox.Size = new Size(121, 23);
            _timePeriodBox.TabIndex = 11;
            _timePeriodBox.SelectedIndexChanged += TimePeriodBoxSelectedIndexChanged;
            // 
            // _generateButton
            // 
            _generateButton.Location = new Point(713, 416);
            _generateButton.Name = "_generateButton";
            _generateButton.Size = new Size(75, 23);
            _generateButton.TabIndex = 12;
            _generateButton.Text = "Generate";
            _generateButton.UseVisualStyleBackColor = true;
            _generateButton.Click += GenerateButtonClick;
            // 
            // _timeBox
            // 
            _timeBox.Location = new Point(592, 416);
            _timeBox.Name = "_timeBox";
            _timeBox.Size = new Size(100, 23);
            _timeBox.TabIndex = 13;
            // 
            // _timeLabel
            // 
            _timeLabel.Location = new Point(532, 416);
            _timeLabel.Name = "_timeLabel";
            _timeLabel.Size = new Size(54, 23);
            _timeLabel.TabIndex = 14;
            _timeLabel.Text = "Year:";
            _timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IncomeReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(_timeLabel);
            Controls.Add(_timeBox);
            Controls.Add(_generateButton);
            Controls.Add(_timePeriodBox);
            Controls.Add(_backButton);
            Controls.Add(_dataGridView);
            MaximizeBox = false;
            MaximumSize = new Size(820, 500);
            MinimumSize = new Size(820, 500);
            Name = "IncomeReportForm";
            Text = "List";
            ((System.ComponentModel.ISupportInitialize)_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected DataGridView _dataGridView;
        protected Button _backButton;
        private ComboBox _timePeriodBox;
        protected Button _generateButton;
        private TextBox _timeBox;
        private Label _timeLabel;
    }
}