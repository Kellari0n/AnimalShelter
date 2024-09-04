namespace AnimalShelter {
    partial class Menu {
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
            _animalsButton = new Button();
            _cagesButton = new Button();
            _reportsButton = new Button();
            SuspendLayout();
            // 
            // _animalsButton
            // 
            _animalsButton.Location = new Point(23, 70);
            _animalsButton.Name = "_animalsButton";
            _animalsButton.Size = new Size(220, 30);
            _animalsButton.TabIndex = 0;
            _animalsButton.Text = "Animals";
            _animalsButton.UseVisualStyleBackColor = true;
            _animalsButton.Click += AnimalButtonClick;
            // 
            // _cagesButton
            // 
            _cagesButton.Location = new Point(23, 140);
            _cagesButton.Name = "_cagesButton";
            _cagesButton.Size = new Size(220, 30);
            _cagesButton.TabIndex = 1;
            _cagesButton.Text = "Cages";
            _cagesButton.UseVisualStyleBackColor = true;
            _cagesButton.Click += CagesButtonClick;
            // 
            // _reportsButton
            // 
            _reportsButton.Location = new Point(23, 210);
            _reportsButton.Name = "_reportsButton";
            _reportsButton.Size = new Size(220, 30);
            _reportsButton.TabIndex = 2;
            _reportsButton.Text = "Reports";
            _reportsButton.UseVisualStyleBackColor = true;
            _reportsButton.Click += ReportsButtonClick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 281);
            Controls.Add(_reportsButton);
            Controls.Add(_cagesButton);
            Controls.Add(_animalsButton);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button _animalsButton;
        private Button _cagesButton;
        private Button _reportsButton;
    }
}