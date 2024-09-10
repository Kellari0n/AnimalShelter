using AnimalShelter.Entities;

namespace AnimalShelter.Forms {
    partial class AnimalsListForm : BaseListForm<Animal> {
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

            _adoptionButton = new Button();
            // 
            // _adoptionButton
            // 
            _adoptionButton.Location = new Point(213, 416);
            _adoptionButton.Name = "_adoptionButton";
            _adoptionButton.Size = new Size(75, 23);
            _adoptionButton.TabIndex = 11;
            _adoptionButton.Text = "Adopt";
            _adoptionButton.UseVisualStyleBackColor = true;
            _adoptionButton.Visible = false;
            _adoptionButton.Click += AdoptionButtonClick;

            Controls.Add(_adoptionButton);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AnimalsListForm";
        }

        #endregion

        private Button _adoptionButton;
    }
}