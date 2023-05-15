namespace MovieUI
{
    partial class DeleteMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMovie));
            movieDeleteLabel = new Label();
            movieUpgradeListBox = new ListBox();
            searchMovieButton = new Button();
            movieSearchTextBox = new TextBox();
            deleteMvieButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // movieDeleteLabel
            // 
            movieDeleteLabel.AutoSize = true;
            movieDeleteLabel.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            movieDeleteLabel.ForeColor = Color.DarkSalmon;
            movieDeleteLabel.Location = new Point(1094, 26);
            movieDeleteLabel.Margin = new Padding(4, 0, 4, 0);
            movieDeleteLabel.Name = "movieDeleteLabel";
            movieDeleteLabel.Size = new Size(557, 117);
            movieDeleteLabel.TabIndex = 2;
            movieDeleteLabel.Text = "Delete Movie";
            // 
            // movieUpgradeListBox
            // 
            movieUpgradeListBox.Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            movieUpgradeListBox.FormattingEnabled = true;
            movieUpgradeListBox.ItemHeight = 37;
            movieUpgradeListBox.Location = new Point(54, 374);
            movieUpgradeListBox.Name = "movieUpgradeListBox";
            movieUpgradeListBox.Size = new Size(1399, 559);
            movieUpgradeListBox.TabIndex = 11;
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
            searchMovieButton.Location = new Point(552, 186);
            searchMovieButton.Name = "searchMovieButton";
            searchMovieButton.Size = new Size(150, 68);
            searchMovieButton.TabIndex = 14;
            searchMovieButton.Text = "Submit";
            searchMovieButton.UseVisualStyleBackColor = false;
            searchMovieButton.Click += searchMovieButton_Click;
            // 
            // movieSearchTextBox
            // 
            movieSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            movieSearchTextBox.Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            movieSearchTextBox.Location = new Point(54, 186);
            movieSearchTextBox.Multiline = true;
            movieSearchTextBox.Name = "movieSearchTextBox";
            movieSearchTextBox.Size = new Size(444, 63);
            movieSearchTextBox.TabIndex = 12;
            movieSearchTextBox.Text = "Enter keyword";
            movieSearchTextBox.Click += movieSearchTextBox_TextChanged;
            // 
            // deleteMvieButton
            // 
            deleteMvieButton.BackColor = Color.DarkSalmon;
            deleteMvieButton.FlatAppearance.BorderColor = Color.Snow;
            deleteMvieButton.FlatAppearance.BorderSize = 5;
            deleteMvieButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            deleteMvieButton.FlatAppearance.MouseOverBackColor = Color.Black;
            deleteMvieButton.FlatStyle = FlatStyle.Flat;
            deleteMvieButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteMvieButton.ForeColor = Color.Snow;
            deleteMvieButton.Location = new Point(54, 948);
            deleteMvieButton.Name = "deleteMvieButton";
            deleteMvieButton.Size = new Size(150, 68);
            deleteMvieButton.TabIndex = 15;
            deleteMvieButton.Text = "Delete";
            deleteMvieButton.UseVisualStyleBackColor = false;
            deleteMvieButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 308);
            label1.Name = "label1";
            label1.Size = new Size(295, 48);
            label1.TabIndex = 21;
            label1.Text = "Movie List:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(297, 38);
            label2.TabIndex = 22;
            label2.Text = "Search Movies:";
            // 
            // DeleteMovie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1681, 1037);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteMvieButton);
            Controls.Add(searchMovieButton);
            Controls.Add(movieSearchTextBox);
            Controls.Add(movieUpgradeListBox);
            Controls.Add(movieDeleteLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label movieDeleteLabel;
        private ListBox movieUpgradeListBox;
        private Button searchMovieButton;
        private TextBox movieSearchTextBox;
        private Button deleteMvieButton;
        private Label label1;
        private Label label2;
    }
}