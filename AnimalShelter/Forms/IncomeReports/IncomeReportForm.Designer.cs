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
            _generateButton = new Button();
            _yearBox = new TextBox();
            _yearLabel = new Label();
            _monthLabel = new Label();
            _monthBox = new ComboBox();
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
            _backButton.Click += BackButtonClick;
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
            // _yearBox
            // 
            _yearBox.Location = new Point(444, 417);
            _yearBox.Name = "_yearBox";
            _yearBox.Size = new Size(100, 23);
            _yearBox.TabIndex = 13;
            // 
            // _yearLabel
            // 
            _yearLabel.Location = new Point(384, 417);
            _yearLabel.Name = "_yearLabel";
            _yearLabel.Size = new Size(54, 23);
            _yearLabel.TabIndex = 14;
            _yearLabel.Text = "Year:";
            _yearLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // _monthLabel
            // 
            _monthLabel.Location = new Point(547, 417);
            _monthLabel.Name = "_monthLabel";
            _monthLabel.Size = new Size(54, 23);
            _monthLabel.TabIndex = 16;
            _monthLabel.Text = "Month:";
            _monthLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // _monthBox
            // 
            _monthBox.FormattingEnabled = true;
            _monthBox.Location = new Point(607, 416);
            _monthBox.Name = "_monthBox";
            _monthBox.Size = new Size(100, 23);
            _monthBox.TabIndex = 17;
            // 
            // IncomeReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(_monthBox);
            Controls.Add(_monthLabel);
            Controls.Add(_yearLabel);
            Controls.Add(_yearBox);
            Controls.Add(_generateButton);
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
        protected Button _generateButton;
        private TextBox _yearBox;
        private Label _yearLabel;
        private Label _monthLabel;
        private ComboBox _monthBox;
    }
}