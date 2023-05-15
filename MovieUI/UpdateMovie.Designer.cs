namespace MovieUI
{
    partial class UpdateMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMovie));
            movieSearchLabel = new Label();
            searchMovieButton = new Button();
            movieSearchBoxLabel = new Label();
            movieSearchTextBox = new TextBox();
            movieUpgradeListBox = new ListBox();
            newTitleBox = new Label();
            newDateBox = new Label();
            saveUpdateButton = new Button();
            updateTitleTextBox = new TextBox();
            label1 = new Label();
            updateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // movieSearchLabel
            // 
            movieSearchLabel.AutoSize = true;
            movieSearchLabel.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            movieSearchLabel.ForeColor = Color.DarkSalmon;
            movieSearchLabel.Location = new Point(1031, 23);
            movieSearchLabel.Margin = new Padding(4, 0, 4, 0);
            movieSearchLabel.Name = "movieSearchLabel";
            movieSearchLabel.Size = new Size(593, 117);
            movieSearchLabel.TabIndex = 2;
            movieSearchLabel.Text = "Update Movie";
            // 
            // searchMovieButton
            // 
            searchMovieButton.BackColor = Color.DarkSalmon;
            searchMovieButton.FlatAppearance.BorderColor = Color.Snow;
            searchMovieButton.FlatAppearance.BorderSize = 5;
            searchMovieButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            searchMovieButton.FlatAppearance.MouseOverBackColor = Color.Black;
            searchMovieButton.FlatStyle = FlatStyle.Flat;
            searchMovieButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchMovieButton.ForeColor = Color.Snow;
            searchMovieButton.Location = new Point(56, 382);
            searchMovieButton.Name = "searchMovieButton";
            searchMovieButton.Size = new Size(176, 59);
            searchMovieButton.TabIndex = 9;
            searchMovieButton.Text = "Submit";
            searchMovieButton.UseVisualStyleBackColor = false;
            searchMovieButton.Click += searchMovieButton_Click_1;
            // 
            // movieSearchBoxLabel
            // 
            movieSearchBoxLabel.AutoSize = true;
            movieSearchBoxLabel.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            movieSearchBoxLabel.Location = new Point(56, 246);
            movieSearchBoxLabel.Name = "movieSearchBoxLabel";
            movieSearchBoxLabel.Size = new Size(277, 37);
            movieSearchBoxLabel.TabIndex = 8;
            movieSearchBoxLabel.Text = "Search Movies";
            // 
            // movieSearchTextBox
            // 
            movieSearchTextBox.BackColor = Color.Linen;
            movieSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            movieSearchTextBox.Location = new Point(56, 305);
            movieSearchTextBox.Multiline = true;
            movieSearchTextBox.Name = "movieSearchTextBox";
            movieSearchTextBox.Size = new Size(469, 54);
            movieSearchTextBox.TabIndex = 7;
            // 
            // movieUpgradeListBox
            // 
            movieUpgradeListBox.BackColor = Color.Linen;
            movieUpgradeListBox.FormattingEnabled = true;
            movieUpgradeListBox.ItemHeight = 37;
            movieUpgradeListBox.Location = new Point(690, 246);
            movieUpgradeListBox.Name = "movieUpgradeListBox";
            movieUpgradeListBox.Size = new Size(806, 374);
            movieUpgradeListBox.TabIndex = 6;
            // 
            // newTitleBox
            // 
            newTitleBox.AutoSize = true;
            newTitleBox.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            newTitleBox.Location = new Point(690, 687);
            newTitleBox.Name = "newTitleBox";
            newTitleBox.Size = new Size(337, 37);
            newTitleBox.TabIndex = 12;
            newTitleBox.Text = "Enter new title:";
            // 
            // newDateBox
            // 
            newDateBox.AutoSize = true;
            newDateBox.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            newDateBox.Location = new Point(690, 794);
            newDateBox.Name = "newDateBox";
            newDateBox.Size = new Size(317, 37);
            newDateBox.TabIndex = 13;
            newDateBox.Text = "Enter new date:";
            // 
            // saveUpdateButton
            // 
            saveUpdateButton.BackColor = Color.DarkSalmon;
            saveUpdateButton.FlatAppearance.BorderColor = Color.Snow;
            saveUpdateButton.FlatAppearance.BorderSize = 5;
            saveUpdateButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            saveUpdateButton.FlatAppearance.MouseOverBackColor = Color.Black;
            saveUpdateButton.FlatStyle = FlatStyle.Flat;
            saveUpdateButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveUpdateButton.ForeColor = Color.Snow;
            saveUpdateButton.Location = new Point(690, 905);
            saveUpdateButton.Name = "saveUpdateButton";
            saveUpdateButton.Size = new Size(173, 64);
            saveUpdateButton.TabIndex = 15;
            saveUpdateButton.Text = "Update";
            saveUpdateButton.UseVisualStyleBackColor = false;
            saveUpdateButton.Click += saveUpdateButton_Click;
            // 
            // updateTitleTextBox
            // 
            updateTitleTextBox.BackColor = Color.Linen;
            updateTitleTextBox.Location = new Point(690, 735);
            updateTitleTextBox.Name = "updateTitleTextBox";
            updateTitleTextBox.Size = new Size(629, 50);
            updateTitleTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(690, 174);
            label1.Name = "label1";
            label1.Size = new Size(295, 48);
            label1.TabIndex = 20;
            label1.Text = "Movie List:";
            // 
            // updateTimePicker
            // 
            updateTimePicker.CalendarForeColor = Color.Linen;
            updateTimePicker.CalendarMonthBackground = Color.Linen;
            updateTimePicker.CalendarTitleBackColor = Color.IndianRed;
            updateTimePicker.CalendarTrailingForeColor = Color.Linen;
            updateTimePicker.Location = new Point(690, 841);
            updateTimePicker.Name = "updateTimePicker";
            updateTimePicker.Size = new Size(629, 50);
            updateTimePicker.TabIndex = 21;
            // 
            // UpdateMovie
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1681, 1037);
            Controls.Add(updateTimePicker);
            Controls.Add(label1);
            Controls.Add(updateTitleTextBox);
            Controls.Add(saveUpdateButton);
            Controls.Add(newDateBox);
            Controls.Add(newTitleBox);
            Controls.Add(searchMovieButton);
            Controls.Add(movieSearchBoxLabel);
            Controls.Add(movieSearchTextBox);
            Controls.Add(movieUpgradeListBox);
            Controls.Add(movieSearchLabel);
            Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpgradeMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label movieSearchLabel;
        private Button searchMovieButton;
        private Label movieSearchBoxLabel;
        private TextBox movieSearchTextBox;
        private ListBox movieUpgradeListBox;
        private Label newTitleBox;
        private Label newDateBox;
        private Button saveUpdateButton;
        private TextBox updateTitleTextBox;
        private Label label1;
        private DateTimePicker updateTimePicker;
    }
}