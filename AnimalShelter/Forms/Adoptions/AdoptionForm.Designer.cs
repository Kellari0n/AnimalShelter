namespace AnimalShelter.Forms {
    partial class AdoptionForm {
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
            _nameLabel = new Label();
            _nameBox = new TextBox();
            _dateLabel = new Label();
            _dateBox = new TextBox();
            _feeLabel = new Label();
            _feeBox = new TextBox();
            _contactsLabel = new Label();
            _contactsBox = new TextBox();
            _actionButton = new Button();
            _backButton = new Button();
            SuspendLayout();
            // 
            // _nameLabel
            // 
            _nameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _nameLabel.Location = new Point(22, 26);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(133, 23);
            _nameLabel.TabIndex = 6;
            _nameLabel.Text = "Adopter Name";
            _nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _nameBox
            // 
            _nameBox.Location = new Point(161, 26);
            _nameBox.Name = "_nameBox";
            _nameBox.Size = new Size(130, 23);
            _nameBox.TabIndex = 5;
            // 
            // _dateLabel
            // 
            _dateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _dateLabel.Location = new Point(22, 76);
            _dateLabel.Name = "_dateLabel";
            _dateLabel.Size = new Size(133, 23);
            _dateLabel.TabIndex = 8;
            _dateLabel.Text = "Date";
            _dateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _dateBox
            // 
            _dateBox.Location = new Point(161, 76);
            _dateBox.Name = "_dateBox";
            _dateBox.Size = new Size(130, 23);
            _dateBox.TabIndex = 7;
            // 
            // _feeLabel
            // 
            _feeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _feeLabel.Location = new Point(22, 126);
            _feeLabel.Name = "_feeLabel";
            _feeLabel.Size = new Size(133, 23);
            _feeLabel.TabIndex = 10;
            _feeLabel.Text = "Fee";
            _feeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _feeBox
            // 
            _feeBox.Location = new Point(161, 126);
            _feeBox.Name = "_feeBox";
            _feeBox.Size = new Size(130, 23);
            _feeBox.TabIndex = 9;
            // 
            // _contactsLabel
            // 
            _contactsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _contactsLabel.Location = new Point(22, 176);
            _contactsLabel.Name = "_contactsLabel";
            _contactsLabel.Size = new Size(133, 23);
            _contactsLabel.TabIndex = 12;
            _contactsLabel.Text = "Contacts";
            _contactsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _contactsBox
            // 
            _contactsBox.Location = new Point(161, 176);
            _contactsBox.Multiline = true;
            _contactsBox.Name = "_contactsBox";
            _contactsBox.Size = new Size(130, 92);
            _contactsBox.TabIndex = 11;
            // 
            // _actionButton
            // 
            _actionButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _actionButton.Location = new Point(181, 279);
            _actionButton.Name = "_actionButton";
            _actionButton.Size = new Size(100, 30);
            _actionButton.TabIndex = 22;
            _actionButton.Text = "Adopt";
            _actionButton.UseVisualStyleBackColor = true;
            _actionButton.Click += AdoptButtonClick;
            // 
            // _backButton
            // 
            _backButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _backButton.Location = new Point(22, 279);
            _backButton.Name = "_backButton";
            _backButton.Size = new Size(100, 30);
            _backButton.TabIndex = 21;
            _backButton.Text = "Back";
            _backButton.UseVisualStyleBackColor = true;
            _backButton.Click += CancelButtonClick;
            // 
            // AdoptionForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(304, 321);
            Controls.Add(_actionButton);
            Controls.Add(_backButton);
            Controls.Add(_contactsLabel);
            Controls.Add(_contactsBox);
            Controls.Add(_feeLabel);
            Controls.Add(_feeBox);
            Controls.Add(_dateLabel);
            Controls.Add(_dateBox);
            Controls.Add(_nameLabel);
            Controls.Add(_nameBox);
            Name = "AdoptionForm";
            Text = "AdoptionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _nameLabel;
        private TextBox _nameBox;
        private Label _dateLabel;
        private TextBox _dateBox;
        private Label _feeLabel;
        private TextBox _feeBox;
        private Label _contactsLabel;
        private TextBox _contactsBox;
        private Button _actionButton;
        private Button _backButton;
    }
}