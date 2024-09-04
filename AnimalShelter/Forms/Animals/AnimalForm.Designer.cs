namespace AnimalShelter.Forms {
    partial class AnimalForm {
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
            _imageBox = new PictureBox();
            _setImageButton = new Button();
            _nameBox = new TextBox();
            _nameLabel = new Label();
            _typeLabel = new Label();
            _typeBox = new ComboBox();
            _breedLabel = new Label();
            _breedBox = new TextBox();
            _cageLabel = new Label();
            _cageBox = new ComboBox();
            _arrivalDateLabel = new Label();
            _arrivalDateBox = new TextBox();
            _adoptionDateLabel = new Label();
            _adoptionDateBox = new TextBox();
            _actionButton = new Button();
            _backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_imageBox).BeginInit();
            SuspendLayout();
            // 
            // _imageBox
            // 
            _imageBox.Location = new Point(15, 15);
            _imageBox.Name = "_imageBox";
            _imageBox.Size = new Size(200, 200);
            _imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            _imageBox.TabIndex = 0;
            _imageBox.TabStop = false;
            // 
            // _setImageButton
            // 
            _setImageButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _setImageButton.Location = new Point(65, 220);
            _setImageButton.Name = "_setImageButton";
            _setImageButton.Size = new Size(100, 30);
            _setImageButton.TabIndex = 1;
            _setImageButton.Text = "Set image";
            _setImageButton.UseVisualStyleBackColor = true;
            _setImageButton.Click += SetImageButtonClick;
            // 
            // _nameBox
            // 
            _nameBox.Location = new Point(380, 20);
            _nameBox.Name = "_nameBox";
            _nameBox.Size = new Size(130, 23);
            _nameBox.TabIndex = 3;
            // 
            // _nameLabel
            // 
            _nameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _nameLabel.Location = new Point(240, 20);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(133, 23);
            _nameLabel.TabIndex = 4;
            _nameLabel.Text = "Name";
            _nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _typeLabel
            // 
            _typeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _typeLabel.Location = new Point(240, 60);
            _typeLabel.Name = "_typeLabel";
            _typeLabel.Size = new Size(133, 23);
            _typeLabel.TabIndex = 6;
            _typeLabel.Text = "Type";
            _typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _typeBox
            // 
            _typeBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            _typeBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeBox.Location = new Point(380, 60);
            _typeBox.Name = "_typeBox";
            _typeBox.Size = new Size(130, 23);
            _typeBox.TabIndex = 5;
            // 
            // _breedLabel
            // 
            _breedLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _breedLabel.Location = new Point(240, 100);
            _breedLabel.Name = "_breedLabel";
            _breedLabel.Size = new Size(133, 23);
            _breedLabel.TabIndex = 8;
            _breedLabel.Text = "Breed";
            _breedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _breedBox
            // 
            _breedBox.Location = new Point(380, 100);
            _breedBox.Name = "_breedBox";
            _breedBox.Size = new Size(130, 23);
            _breedBox.TabIndex = 7;
            // 
            // _cageLabel
            // 
            _cageLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _cageLabel.Location = new Point(240, 140);
            _cageLabel.Name = "_cageLabel";
            _cageLabel.Size = new Size(133, 23);
            _cageLabel.TabIndex = 10;
            _cageLabel.Text = "Cage";
            _cageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _cageBox
            // 
            _cageBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cageBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cageBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _cageBox.Location = new Point(380, 140);
            _cageBox.Name = "_cageBox";
            _cageBox.Size = new Size(130, 23);
            _cageBox.TabIndex = 9;
            // 
            // _arrivalDateLabel
            // 
            _arrivalDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _arrivalDateLabel.Location = new Point(240, 180);
            _arrivalDateLabel.Name = "_arrivalDateLabel";
            _arrivalDateLabel.Size = new Size(133, 23);
            _arrivalDateLabel.TabIndex = 12;
            _arrivalDateLabel.Text = "Arrival Date";
            _arrivalDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _arrivalDateBox
            // 
            _arrivalDateBox.Location = new Point(380, 180);
            _arrivalDateBox.Name = "_arrivalDateBox";
            _arrivalDateBox.Size = new Size(130, 23);
            _arrivalDateBox.TabIndex = 11;
            // 
            // _adoptionDateLabel
            // 
            _adoptionDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _adoptionDateLabel.Location = new Point(240, 220);
            _adoptionDateLabel.Name = "_adoptionDateLabel";
            _adoptionDateLabel.Size = new Size(133, 23);
            _adoptionDateLabel.TabIndex = 14;
            _adoptionDateLabel.Text = "Adoption Date";
            _adoptionDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _adoptionDateBox
            // 
            _adoptionDateBox.Location = new Point(380, 220);
            _adoptionDateBox.Name = "_adoptionDateBox";
            _adoptionDateBox.Size = new Size(130, 23);
            _adoptionDateBox.TabIndex = 13;
            // 
            // _actionButton
            // 
            _actionButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _actionButton.Location = new Point(386, 279);
            _actionButton.Name = "_actionButton";
            _actionButton.Size = new Size(100, 30);
            _actionButton.TabIndex = 16;
            _actionButton.Text = "Action";
            _actionButton.UseVisualStyleBackColor = true;
            // 
            // _backButton
            // 
            _backButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _backButton.Location = new Point(42, 279);
            _backButton.Name = "_backButton";
            _backButton.Size = new Size(100, 30);
            _backButton.TabIndex = 18;
            _backButton.Text = "Back";
            _backButton.UseVisualStyleBackColor = true;
            _backButton.Click += Back;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 321);
            Controls.Add(_backButton);
            Controls.Add(_actionButton);
            Controls.Add(_adoptionDateLabel);
            Controls.Add(_adoptionDateBox);
            Controls.Add(_arrivalDateLabel);
            Controls.Add(_arrivalDateBox);
            Controls.Add(_cageLabel);
            Controls.Add(_cageBox);
            Controls.Add(_breedLabel);
            Controls.Add(_breedBox);
            Controls.Add(_typeLabel);
            Controls.Add(_typeBox);
            Controls.Add(_nameLabel);
            Controls.Add(_nameBox);
            Controls.Add(_setImageButton);
            Controls.Add(_imageBox);
            Name = "AnimalForm";
            Text = "AnimalForm";
            ((System.ComponentModel.ISupportInitialize)_imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox _imageBox;
        private Button _setImageButton;
        private TextBox _nameBox;
        private Label _nameLabel;
        private Label _typeLabel;
        private ComboBox _typeBox;
        private Label _breedLabel;
        private TextBox _breedBox;
        private Label _cageLabel;
        private ComboBox _cageBox;
        private Label _arrivalDateLabel;
        private TextBox _arrivalDateBox;
        private Label _adoptionDateLabel;
        private TextBox _adoptionDateBox;
        private Button _actionButton;
        private Button _backButton;
    }
}