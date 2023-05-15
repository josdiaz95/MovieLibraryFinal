namespace MovieUI
{
    partial class SearchMoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMoviesForm));
            movieSearchLabel = new Label();
            foundMoviesLabel = new Label();
            foundMovieListView = new ListView();
            SuspendLayout();
            // 
            // movieSearchLabel
            // 
            movieSearchLabel.AutoSize = true;
            movieSearchLabel.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            movieSearchLabel.ForeColor = Color.DarkSalmon;
            movieSearchLabel.Location = new Point(1255, 50);
            movieSearchLabel.Margin = new Padding(4, 0, 4, 0);
            movieSearchLabel.Name = "movieSearchLabel";
            movieSearchLabel.Size = new Size(580, 117);
            movieSearchLabel.TabIndex = 1;
            movieSearchLabel.Text = "Movie Search";
            // 
            // foundMoviesLabel
            // 
            foundMoviesLabel.AutoSize = true;
            foundMoviesLabel.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            foundMoviesLabel.Location = new Point(25, 238);
            foundMoviesLabel.Margin = new Padding(2, 0, 2, 0);
            foundMoviesLabel.Name = "foundMoviesLabel";
            foundMoviesLabel.Size = new Size(345, 48);
            foundMoviesLabel.TabIndex = 7;
            foundMoviesLabel.Text = "Found Movies:";
            // 
            // foundMovieListView
            // 
            foundMovieListView.BackColor = Color.Linen;
            foundMovieListView.Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            foundMovieListView.ForeColor = Color.Black;
            foundMovieListView.FullRowSelect = true;
            foundMovieListView.Location = new Point(25, 304);
            foundMovieListView.Name = "foundMovieListView";
            foundMovieListView.Size = new Size(1810, 713);
            foundMovieListView.TabIndex = 8;
            foundMovieListView.UseCompatibleStateImageBehavior = false;
            foundMovieListView.View = View.Details;
            // 
            // SearchMoviesForm
            // 
            AutoScaleDimensions = new SizeF(18F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1880, 1039);
            Controls.Add(foundMovieListView);
            Controls.Add(foundMoviesLabel);
            Controls.Add(movieSearchLabel);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SearchMoviesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Movies:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label movieSearchLabel;
        private Label foundMoviesLabel;
        private ListView foundMovieListView;
    }
}