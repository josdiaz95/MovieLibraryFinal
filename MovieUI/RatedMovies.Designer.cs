namespace MovieUI
{
    partial class RatedMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatedMovies));
            occComboBox = new ComboBox();
            listBox1 = new ListBox();
            searchMovieButton = new Button();
            label1 = new Label();
            movieDeleteLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // occComboBox
            // 
            occComboBox.BackColor = Color.Linen;
            occComboBox.FormattingEnabled = true;
            occComboBox.Location = new Point(108, 305);
            occComboBox.Name = "occComboBox";
            occComboBox.Size = new Size(621, 45);
            occComboBox.TabIndex = 0;
            occComboBox.Text = "Most like by:";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Linen;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(108, 528);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1314, 411);
            listBox1.TabIndex = 1;
            // 
            // searchMovieButton
            // 
            searchMovieButton.BackColor = Color.LightSalmon;
            searchMovieButton.FlatAppearance.BorderColor = Color.Snow;
            searchMovieButton.FlatAppearance.BorderSize = 5;
            searchMovieButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            searchMovieButton.FlatAppearance.MouseOverBackColor = Color.Black;
            searchMovieButton.FlatStyle = FlatStyle.Flat;
            searchMovieButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchMovieButton.ForeColor = Color.Snow;
            searchMovieButton.Location = new Point(788, 287);
            searchMovieButton.Margin = new Padding(2);
            searchMovieButton.Name = "searchMovieButton";
            searchMovieButton.Size = new Size(161, 63);
            searchMovieButton.TabIndex = 15;
            searchMovieButton.Text = "Submit";
            searchMovieButton.UseVisualStyleBackColor = false;
            searchMovieButton.Click += searchMovieButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 457);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(520, 48);
            label1.TabIndex = 22;
            label1.Text = "Highest rated Movie:";
            // 
            // movieDeleteLabel
            // 
            movieDeleteLabel.AutoSize = true;
            movieDeleteLabel.BackColor = Color.Transparent;
            movieDeleteLabel.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            movieDeleteLabel.ForeColor = Color.DarkSalmon;
            movieDeleteLabel.Location = new Point(1147, 35);
            movieDeleteLabel.Name = "movieDeleteLabel";
            movieDeleteLabel.Size = new Size(487, 117);
            movieDeleteLabel.TabIndex = 23;
            movieDeleteLabel.Text = "Most Rated";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(108, 246);
            label2.Name = "label2";
            label2.Size = new Size(457, 37);
            label2.TabIndex = 24;
            label2.Text = "Search by Occupaction:";
            // 
            // RatedMovies
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1681, 1037);
            Controls.Add(label2);
            Controls.Add(movieDeleteLabel);
            Controls.Add(label1);
            Controls.Add(searchMovieButton);
            Controls.Add(listBox1);
            Controls.Add(occComboBox);
            DoubleBuffered = true;
            Font = new Font("SimSun-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "RatedMovies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RatedMovies";
            Load += RatedMovies_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox occComboBox;
        private ListBox listBox1;
        private Button searchMovieButton;
        private Label label1;
        private Label movieDeleteLabel;
        private Label label2;
    }
}