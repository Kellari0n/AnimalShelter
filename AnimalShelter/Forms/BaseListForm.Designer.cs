namespace AnimalShelter.Forms {
    partial class BaseListForm<EntityT> {
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "BaseListForm";

            _addButton.Click += AddButtonClick;
            _deleteButton.Click += DeleteButtonClick;
            _updateButton.Click += UpdateButtonClick;
            _detailsButton.Click += DetailsButtonClick;
            _refreshButton.Click += RefreshButtonClick;
            _backButton.Click += BackButtonClick;
        }

        #endregion
    }
}