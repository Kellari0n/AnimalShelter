namespace AnimalShelter.Forms.Animals {
    partial class AddAnimalTypeForm {
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
            _typeBox = new TextBox();
            _titleLabel = new Label();
            _typeLabel = new Label();
            _addButton = new Button();
            _cancelButton = new Button();
            SuspendLayout();
            // 
            // _typeBox
            // 
            _typeBox.Location = new Point(79, 50);
            _typeBox.Name = "_typeBox";
            _typeBox.Size = new Size(143, 23);
            _typeBox.TabIndex = 0;
            // 
            // _titleLabel
            // 
            _titleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _titleLabel.Location = new Point(12, 9);
            _titleLabel.Name = "_titleLabel";
            _titleLabel.Size = new Size(210, 25);
            _titleLabel.TabIndex = 1;
            _titleLabel.Text = "Add new type?";
            _titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _typeLabel
            // 
            _typeLabel.Location = new Point(12, 50);
            _typeLabel.Name = "_typeLabel";
            _typeLabel.Size = new Size(61, 23);
            _typeLabel.TabIndex = 2;
            _typeLabel.Text = "Type";
            _typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(12, 93);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(75, 25);
            _addButton.TabIndex = 3;
            _addButton.Text = "Add";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += AddButtonClick;
            // 
            // _cancelButton
            // 
            _cancelButton.Location = new Point(141, 93);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(75, 25);
            _cancelButton.TabIndex = 4;
            _cancelButton.Text = "Cancel";
            _cancelButton.UseVisualStyleBackColor = true;
            _cancelButton.Click += CancelButtonClick;
            // 
            // AddAnimalTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 130);
            Controls.Add(_cancelButton);
            Controls.Add(_addButton);
            Controls.Add(_typeLabel);
            Controls.Add(_titleLabel);
            Controls.Add(_typeBox);
            Name = "AddAnimalTypeForm";
            Text = "AddAnimalTypeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _typeBox;
        private Label _titleLabel;
        private Label _typeLabel;
        private Button _addButton;
        private Button _cancelButton;
    }
}