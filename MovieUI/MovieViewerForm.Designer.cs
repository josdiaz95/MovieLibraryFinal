namespace MovieUI
{
    partial class MovieViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieViewerForm));
            movieUIHeader = new Label();
            updateMovieRadio = new RadioButton();
            deleteMovieRadio = new RadioButton();
            addUserRadio = new RadioButton();
            rateMovieRadio = new RadioButton();
            ratedMoviesRadio = new RadioButton();
            movieLibraryButton = new Button();
            createMovieRadio = new RadioButton();
            menuGroupBox = new GroupBox();
            keyWordSearchTB = new TextBox();
            popCornPanel = new Panel();
            menuGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // movieUIHeader
            // 
            movieUIHeader.AutoSize = true;
            movieUIHeader.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            movieUIHeader.ForeColor = Color.DarkSalmon;
            movieUIHeader.Location = new Point(103, 35);
            movieUIHeader.Margin = new Padding(4, 0, 4, 0);
            movieUIHeader.Name = "movieUIHeader";
            movieUIHeader.Size = new Size(768, 156);
            movieUIHeader.TabIndex = 0;
            movieUIHeader.Text = "Movie Library";
            // 
            // updateMovieRadio
            // 
            updateMovieRadio.AutoSize = true;
            updateMovieRadio.Location = new Point(21, 279);
            updateMovieRadio.Margin = new Padding(4);
            updateMovieRadio.Name = "updateMovieRadio";
            updateMovieRadio.Size = new Size(314, 47);
            updateMovieRadio.TabIndex = 2;
            updateMovieRadio.Text = "Update Movie";
            updateMovieRadio.UseVisualStyleBackColor = true;
            updateMovieRadio.Click += keyWordSearchTB_TextChanged_1;
            // 
            // deleteMovieRadio
            // 
            deleteMovieRadio.AutoSize = true;
            deleteMovieRadio.Location = new Point(21, 351);
            deleteMovieRadio.Margin = new Padding(4);
            deleteMovieRadio.Name = "deleteMovieRadio";
            deleteMovieRadio.Size = new Size(314, 47);
            deleteMovieRadio.TabIndex = 3;
            deleteMovieRadio.Text = "Delete Movie";
            deleteMovieRadio.UseVisualStyleBackColor = true;
            deleteMovieRadio.Click += keyWordSearchTB_TextChanged_1;
            // 
            // addUserRadio
            // 
            addUserRadio.AutoSize = true;
            addUserRadio.Location = new Point(21, 419);
            addUserRadio.Name = "addUserRadio";
            addUserRadio.Size = new Size(226, 47);
            addUserRadio.TabIndex = 4;
            addUserRadio.Text = "Add User";
            addUserRadio.UseVisualStyleBackColor = true;
            addUserRadio.Click += keyWordSearchTB_TextChanged_1;
            // 
            // rateMovieRadio
            // 
            rateMovieRadio.AutoSize = true;
            rateMovieRadio.Location = new Point(21, 486);
            rateMovieRadio.Name = "rateMovieRadio";
            rateMovieRadio.Size = new Size(292, 47);
            rateMovieRadio.TabIndex = 5;
            rateMovieRadio.Text = "Rate Movies";
            rateMovieRadio.UseVisualStyleBackColor = true;
            rateMovieRadio.Click += keyWordSearchTB_TextChanged_1;
            // 
            // ratedMoviesRadio
            // 
            ratedMoviesRadio.AutoSize = true;
            ratedMoviesRadio.Location = new Point(21, 563);
            ratedMoviesRadio.Name = "ratedMoviesRadio";
            ratedMoviesRadio.Size = new Size(314, 47);
            ratedMoviesRadio.TabIndex = 6;
            ratedMoviesRadio.Text = "Rated Movies";
            ratedMoviesRadio.UseVisualStyleBackColor = true;
            ratedMoviesRadio.Click += keyWordSearchTB_TextChanged_1;
            // 
            // movieLibraryButton
            // 
            movieLibraryButton.BackColor = Color.DarkSalmon;
            movieLibraryButton.FlatAppearance.BorderColor = Color.Snow;
            movieLibraryButton.FlatAppearance.BorderSize = 5;
            movieLibraryButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            movieLibraryButton.FlatAppearance.MouseOverBackColor = Color.Black;
            movieLibraryButton.FlatStyle = FlatStyle.Flat;
            movieLibraryButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            movieLibraryButton.ForeColor = Color.Snow;
            movieLibraryButton.Location = new Point(256, 650);
            movieLibraryButton.Name = "movieLibraryButton";
            movieLibraryButton.Size = new Size(150, 68);
            movieLibraryButton.TabIndex = 7;
            movieLibraryButton.Text = "Submit";
            movieLibraryButton.UseVisualStyleBackColor = false;
            movieLibraryButton.Click += movieLibraryButton_Click_1;
            // 
            // createMovieRadio
            // 
            createMovieRadio.AutoSize = true;
            createMovieRadio.Location = new Point(21, 211);
            createMovieRadio.Name = "createMovieRadio";
            createMovieRadio.Size = new Size(314, 47);
            createMovieRadio.TabIndex = 9;
            createMovieRadio.Text = "Create Movie";
            createMovieRadio.UseVisualStyleBackColor = true;
            createMovieRadio.Click += keyWordSearchTB_TextChanged_1;
            // 
            // menuGroupBox
            // 
            menuGroupBox.Controls.Add(updateMovieRadio);
            menuGroupBox.Controls.Add(movieLibraryButton);
            menuGroupBox.Controls.Add(keyWordSearchTB);
            menuGroupBox.Controls.Add(createMovieRadio);
            menuGroupBox.Controls.Add(deleteMovieRadio);
            menuGroupBox.Controls.Add(addUserRadio);
            menuGroupBox.Controls.Add(rateMovieRadio);
            menuGroupBox.Controls.Add(ratedMoviesRadio);
            menuGroupBox.FlatStyle = FlatStyle.Popup;
            menuGroupBox.Font = new Font("SimSun", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            menuGroupBox.ForeColor = Color.Black;
            menuGroupBox.Location = new Point(36, 208);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Padding = new Padding(8, 3, 3, 3);
            menuGroupBox.Size = new Size(890, 744);
            menuGroupBox.TabIndex = 10;
            menuGroupBox.TabStop = false;
            menuGroupBox.Text = "Menu";
            // 
            // keyWordSearchTB
            // 
            keyWordSearchTB.BackColor = Color.Linen;
            keyWordSearchTB.Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            keyWordSearchTB.Location = new Point(21, 87);
            keyWordSearchTB.Name = "keyWordSearchTB";
            keyWordSearchTB.Size = new Size(837, 50);
            keyWordSearchTB.TabIndex = 11;
            keyWordSearchTB.Click += keyWordSearchTB_TextChanged_1;
            // 
            // popCornPanel
            // 
            popCornPanel.BackColor = Color.Transparent;
            popCornPanel.BackgroundImage = Properties.Resources.popcorn_png_9432;
            popCornPanel.BackgroundImageLayout = ImageLayout.Zoom;
            popCornPanel.Location = new Point(932, 35);
            popCornPanel.Name = "popCornPanel";
            popCornPanel.Size = new Size(616, 990);
            popCornPanel.TabIndex = 12;
            // 
            // MovieViewerForm
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.IndianRed;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1560, 1037);
            Controls.Add(popCornPanel);
            Controls.Add(menuGroupBox);
            Controls.Add(movieUIHeader);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MovieViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Library Menu";
            Load += MovieViewerForm_Load;
            menuGroupBox.ResumeLayout(false);
            menuGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void moviesSearchRadio_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label movieUIHeader;
        private RadioButton updateMovieRadio;
        private RadioButton deleteMovieRadio;
        private RadioButton addUserRadio;
        private RadioButton rateMovieRadio;
        private RadioButton ratedMoviesRadio;
        private Button movieLibraryButton;
        private RadioButton createMovieRadio;
        private GroupBox menuGroupBox;
        private TextBox keyWordSearchTB;
        private Panel popCornPanel;
    }
}