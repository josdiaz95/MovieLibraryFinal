namespace MovieUI
{
    partial class CreateMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMovie));
            movieTitle = new Label();
            addDate = new Label();
            createMovieUIHeader = new Label();
            addedMovieLabel = new Label();
            listBox1 = new ListBox();
            addMovieButton = new Button();
            titleTextBox = new TextBox();
            releaseDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // movieTitle
            // 
            movieTitle.AutoSize = true;
            movieTitle.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            movieTitle.Location = new Point(41, 162);
            movieTitle.Name = "movieTitle";
            movieTitle.Size = new Size(257, 37);
            movieTitle.TabIndex = 0;
            movieTitle.Text = "Movie Title:";
            // 
            // addDate
            // 
            addDate.AutoSize = true;
            addDate.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            addDate.Location = new Point(41, 288);
            addDate.Name = "addDate";
            addDate.Size = new Size(397, 37);
            addDate.TabIndex = 2;
            addDate.Text = "Movie Release Date:";
            // 
            // createMovieUIHeader
            // 
            createMovieUIHeader.AutoSize = true;
            createMovieUIHeader.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            createMovieUIHeader.ForeColor = Color.DarkSalmon;
            createMovieUIHeader.Location = new Point(1060, 21);
            createMovieUIHeader.Margin = new Padding(4, 0, 4, 0);
            createMovieUIHeader.Name = "createMovieUIHeader";
            createMovieUIHeader.Size = new Size(576, 117);
            createMovieUIHeader.TabIndex = 0;
            createMovieUIHeader.Text = "Create Movie";
            // 
            // addedMovieLabel
            // 
            addedMovieLabel.AutoSize = true;
            addedMovieLabel.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addedMovieLabel.Location = new Point(41, 493);
            addedMovieLabel.Name = "addedMovieLabel";
            addedMovieLabel.Size = new Size(320, 48);
            addedMovieLabel.TabIndex = 4;
            addedMovieLabel.Text = "Added Movie:";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Linen;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(41, 553);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1388, 448);
            listBox1.TabIndex = 5;
            // 
            // addMovieButton
            // 
            addMovieButton.BackColor = Color.DarkSalmon;
            addMovieButton.FlatAppearance.BorderColor = Color.Snow;
            addMovieButton.FlatAppearance.BorderSize = 5;
            addMovieButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            addMovieButton.FlatAppearance.MouseOverBackColor = Color.Black;
            addMovieButton.FlatStyle = FlatStyle.Flat;
            addMovieButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMovieButton.ForeColor = Color.Snow;
            addMovieButton.Location = new Point(714, 333);
            addMovieButton.Name = "addMovieButton";
            addMovieButton.Size = new Size(145, 61);
            addMovieButton.TabIndex = 10;
            addMovieButton.Text = "Add";
            addMovieButton.UseVisualStyleBackColor = false;
            addMovieButton.Click += addMovieButton_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.Linen;
            titleTextBox.Location = new Point(41, 215);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(623, 50);
            titleTextBox.TabIndex = 11;
            titleTextBox.Click += titleTextBox_TextChanged;
            // 
            // releaseDatePicker
            // 
            releaseDatePicker.CalendarMonthBackground = Color.Linen;
            releaseDatePicker.Location = new Point(41, 344);
            releaseDatePicker.Name = "releaseDatePicker";
            releaseDatePicker.Size = new Size(623, 50);
            releaseDatePicker.TabIndex = 13;
            // 
            // CreateMovie
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1681, 1037);
            Controls.Add(releaseDatePicker);
            Controls.Add(titleTextBox);
            Controls.Add(addMovieButton);
            Controls.Add(listBox1);
            Controls.Add(addedMovieLabel);
            Controls.Add(createMovieUIHeader);
            Controls.Add(addDate);
            Controls.Add(movieTitle);
            Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CreateMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateMovie";
            Load += CreateMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label movieTitle;
        private Label addDate;
        private Label createMovieUIHeader;
        private Label addedMovieLabel;
        private ListBox listBox1;
        private Button addMovieButton;
        private TextBox titleTextBox;
        private DateTimePicker releaseDatePicker;
    }
}