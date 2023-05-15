namespace MovieUI
{
    partial class RateMovie
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateMovie));
            foundMoviesLabel = new Label();
            movieSearchLabel = new Label();
            label2 = new Label();
            userIDComboBox = new ComboBox();
            moviesComboBox = new ComboBox();
            ratingsComboBox = new ComboBox();
            ratingLabel = new Label();
            rateButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ratedMovieListView = new ListView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // foundMoviesLabel
            // 
            foundMoviesLabel.AutoSize = true;
            foundMoviesLabel.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            foundMoviesLabel.Location = new Point(-478, -29);
            foundMoviesLabel.Name = "foundMoviesLabel";
            foundMoviesLabel.Size = new Size(320, 48);
            foundMoviesLabel.TabIndex = 10;
            foundMoviesLabel.Text = "Found Movies";
            // 
            // movieSearchLabel
            // 
            movieSearchLabel.AutoSize = true;
            movieSearchLabel.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            movieSearchLabel.ForeColor = Color.Black;
            movieSearchLabel.Location = new Point(783, -219);
            movieSearchLabel.Margin = new Padding(4, 0, 4, 0);
            movieSearchLabel.Name = "movieSearchLabel";
            movieSearchLabel.Size = new Size(580, 117);
            movieSearchLabel.TabIndex = 9;
            movieSearchLabel.Text = "Movie Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSalmon;
            label2.Location = new Point(1968, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(480, 117);
            label2.TabIndex = 11;
            label2.Text = "Rate Movie";
            // 
            // userIDComboBox
            // 
            userIDComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            userIDComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            userIDComboBox.BackColor = Color.Linen;
            userIDComboBox.FlatStyle = FlatStyle.Popup;
            userIDComboBox.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point);
            userIDComboBox.FormattingEnabled = true;
            userIDComboBox.Location = new Point(156, 214);
            userIDComboBox.Name = "userIDComboBox";
            userIDComboBox.Size = new Size(537, 45);
            userIDComboBox.TabIndex = 14;
            userIDComboBox.Text = "User ID";
            // 
            // moviesComboBox
            // 
            moviesComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            moviesComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            moviesComboBox.BackColor = Color.Linen;
            moviesComboBox.FlatStyle = FlatStyle.Popup;
            moviesComboBox.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point);
            moviesComboBox.FormattingEnabled = true;
            moviesComboBox.Location = new Point(746, 214);
            moviesComboBox.Name = "moviesComboBox";
            moviesComboBox.Size = new Size(879, 45);
            moviesComboBox.TabIndex = 15;
            moviesComboBox.Text = "Movies";
            moviesComboBox.SelectedIndexChanged += moviesComboBox_SelectedIndexChanged;
            // 
            // ratingsComboBox
            // 
            ratingsComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ratingsComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            ratingsComboBox.BackColor = Color.Linen;
            ratingsComboBox.FlatStyle = FlatStyle.Popup;
            ratingsComboBox.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ratingsComboBox.FormattingEnabled = true;
            ratingsComboBox.Location = new Point(1688, 214);
            ratingsComboBox.Name = "ratingsComboBox";
            ratingsComboBox.Size = new Size(294, 45);
            ratingsComboBox.TabIndex = 16;
            ratingsComboBox.Text = "Rate";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ratingLabel.Location = new Point(38, 329);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(220, 48);
            ratingLabel.TabIndex = 19;
            ratingLabel.Text = "Ratings:";
            // 
            // rateButton
            // 
            rateButton.BackColor = Color.DarkSalmon;
            rateButton.FlatAppearance.BorderColor = Color.Snow;
            rateButton.FlatAppearance.BorderSize = 5;
            rateButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            rateButton.FlatAppearance.MouseOverBackColor = Color.Snow;
            rateButton.FlatStyle = FlatStyle.Flat;
            rateButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rateButton.ForeColor = Color.Snow;
            rateButton.Location = new Point(2026, 201);
            rateButton.Name = "rateButton";
            rateButton.Size = new Size(150, 58);
            rateButton.TabIndex = 20;
            rateButton.Text = "Submit";
            rateButton.UseVisualStyleBackColor = false;
            rateButton.Click += rateButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ratedMovieListView
            // 
            ratedMovieListView.BackColor = Color.Linen;
            ratedMovieListView.Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ratedMovieListView.ForeColor = Color.Black;
            ratedMovieListView.FullRowSelect = true;
            ratedMovieListView.Location = new Point(38, 406);
            ratedMovieListView.Name = "ratedMovieListView";
            ratedMovieListView.Size = new Size(2410, 796);
            ratedMovieListView.TabIndex = 17;
            ratedMovieListView.UseCompatibleStateImageBehavior = false;
            ratedMovieListView.View = View.Details;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // RateMovie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(2562, 1327);
            Controls.Add(rateButton);
            Controls.Add(ratingLabel);
            Controls.Add(ratedMovieListView);
            Controls.Add(ratingsComboBox);
            Controls.Add(moviesComboBox);
            Controls.Add(userIDComboBox);
            Controls.Add(label2);
            Controls.Add(foundMoviesLabel);
            Controls.Add(movieSearchLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RateMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RateMovie";
            Load += RateMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label foundMoviesLabel;
        private Label movieSearchLabel;
        private Label label2;
        private ComboBox userIDComboBox;
        private ComboBox moviesComboBox;
        private ComboBox ratingsComboBox;
        private Label ratingLabel;
        private Button rateButton;
        private ContextMenuStrip contextMenuStrip1;
        private ListView ratedMovieListView;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}