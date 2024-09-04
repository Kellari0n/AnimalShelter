namespace AnimalShelter.Forms {
    partial class CageForm {
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
            _typeBox = new ComboBox();
            _numberLabel = new Label();
            _numberBox = new TextBox();
            _typeLabel = new Label();
            _maxcapacityLabel = new Label();
            _maxCapacityBox = new TextBox();
            _backButton = new Button();
            _actionButton = new Button();
            _addTypeButton = new Button();
            SuspendLayout();
            // 
            // _typeBox
            // 
            _typeBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            _typeBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeBox.FormattingEnabled = true;
            _typeBox.Location = new Point(162, 76);
            _typeBox.Name = "_typeBox";
            _typeBox.Size = new Size(107, 23);
            _typeBox.TabIndex = 0;
            // 
            // _numberLabel
            // 
            _numberLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _numberLabel.Location = new Point(22, 26);
            _numberLabel.Name = "_numberLabel";
            _numberLabel.Size = new Size(133, 23);
            _numberLabel.TabIndex = 6;
            _numberLabel.Text = "Number";
            _numberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _numberBox
            // 
            _numberBox.Location = new Point(162, 26);
            _numberBox.Name = "_numberBox";
            _numberBox.Size = new Size(130, 23);
            _numberBox.TabIndex = 5;
            // 
            // _typeLabel
            // 
            _typeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _typeLabel.Location = new Point(22, 76);
            _typeLabel.Name = "_typeLabel";
            _typeLabel.Size = new Size(133, 23);
            _typeLabel.TabIndex = 7;
            _typeLabel.Text = "Type";
            _typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _maxcapacityLabel
            // 
            _maxcapacityLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _maxcapacityLabel.Location = new Point(22, 126);
            _maxcapacityLabel.Name = "_maxcapacityLabel";
            _maxcapacityLabel.Size = new Size(133, 23);
            _maxcapacityLabel.TabIndex = 9;
            _maxcapacityLabel.Text = "Max Capacity";
            _maxcapacityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _maxCapacityBox
            // 
            _maxCapacityBox.Location = new Point(162, 126);
            _maxCapacityBox.Name = "_maxCapacityBox";
            _maxCapacityBox.Size = new Size(130, 23);
            _maxCapacityBox.TabIndex = 8;
            // 
            // _backButton
            // 
            _backButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _backButton.Location = new Point(22, 169);
            _backButton.Name = "_backButton";
            _backButton.Size = new Size(100, 30);
            _backButton.TabIndex = 19;
            _backButton.Text = "Back";
            _backButton.UseVisualStyleBackColor = true;
            _backButton.Click += Back;
            // 
            // _actionButton
            // 
            _actionButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _actionButton.Location = new Point(181, 169);
            _actionButton.Name = "_actionButton";
            _actionButton.Size = new Size(100, 30);
            _actionButton.TabIndex = 20;
            _actionButton.Text = "Action";
            _actionButton.UseVisualStyleBackColor = true;
            // 
            // _addTypeButton
            // 
            _addTypeButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _addTypeButton.Location = new Point(267, 75);
            _addTypeButton.Name = "_addTypeButton";
            _addTypeButton.Size = new Size(25, 25);
            _addTypeButton.TabIndex = 21;
            _addTypeButton.Text = "+";
            _addTypeButton.TextAlign = ContentAlignment.TopCenter;
            _addTypeButton.UseVisualStyleBackColor = true;
            _addTypeButton.Click += AddTypeButtonClick;
            // 
            // CageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 211);
            Controls.Add(_addTypeButton);
            Controls.Add(_actionButton);
            Controls.Add(_backButton);
            Controls.Add(_maxcapacityLabel);
            Controls.Add(_maxCapacityBox);
            Controls.Add(_typeLabel);
            Controls.Add(_numberLabel);
            Controls.Add(_numberBox);
            Controls.Add(_typeBox);
            Name = "CageForm";
            Text = "CageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _typeBox;
        private Label _numberLabel;
        private TextBox _numberBox;
        private Label _typeLabel;
        private Label _maxcapacityLabel;
        private TextBox _maxCapacityBox;
        private Button _backButton;
        private Button _actionButton;
        private Button _addTypeButton;
    }
}