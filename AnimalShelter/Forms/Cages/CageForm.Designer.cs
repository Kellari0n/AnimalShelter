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
            SuspendLayout();
            // 
            // _typeBox
            // 
            _typeBox.FormattingEnabled = true;
            _typeBox.Location = new Point(184, 94);
            _typeBox.Name = "_typeBox";
            _typeBox.Size = new Size(121, 23);
            _typeBox.TabIndex = 0;
            // 
            // CageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_typeBox);
            Name = "CageForm";
            Text = "CageForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox _typeBox;
    }
}