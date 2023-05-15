namespace MovieUI
{
    partial class Adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adduser));
            listBox1 = new ListBox();
            addedMovieLabel = new Label();
            addUserUIHeader = new Label();
            ageTextBox = new TextBox();
            genderTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            addUserButton = new Button();
            occupationComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(775, 260);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(866, 633);
            listBox1.TabIndex = 7;
            // 
            // addedMovieLabel
            // 
            addedMovieLabel.AutoSize = true;
            addedMovieLabel.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addedMovieLabel.Location = new Point(775, 192);
            addedMovieLabel.Name = "addedMovieLabel";
            addedMovieLabel.Size = new Size(295, 48);
            addedMovieLabel.TabIndex = 6;
            addedMovieLabel.Text = "Added User:";
            // 
            // addUserUIHeader
            // 
            addUserUIHeader.AutoSize = true;
            addUserUIHeader.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            addUserUIHeader.ForeColor = Color.DarkSalmon;
            addUserUIHeader.Location = new Point(1236, 43);
            addUserUIHeader.Margin = new Padding(4, 0, 4, 0);
            addUserUIHeader.Name = "addUserUIHeader";
            addUserUIHeader.Size = new Size(405, 117);
            addUserUIHeader.TabIndex = 8;
            addUserUIHeader.Text = "Add User";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(33, 300);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(405, 50);
            ageTextBox.TabIndex = 9;
            ageTextBox.Click += ageTextBox_TextChanged;
            // 
            // genderTextBox
            // 
            genderTextBox.Location = new Point(30, 436);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(405, 50);
            genderTextBox.TabIndex = 10;
            genderTextBox.Click += genderTextBox_TextChanged;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(30, 559);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(405, 50);
            zipCodeTextBox.TabIndex = 11;
            zipCodeTextBox.Click += zipCodeTextBox_TextChanged;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.DarkSalmon;
            addUserButton.FlatAppearance.BorderColor = Color.Snow;
            addUserButton.FlatAppearance.BorderSize = 5;
            addUserButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            addUserButton.FlatAppearance.MouseOverBackColor = Color.Black;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addUserButton.ForeColor = Color.Snow;
            addUserButton.Location = new Point(30, 781);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(134, 68);
            addUserButton.TabIndex = 12;
            addUserButton.Text = "Add";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addMovieButton_Click;
            // 
            // occupationComboBox
            // 
            occupationComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            occupationComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            occupationComboBox.FlatStyle = FlatStyle.Popup;
            occupationComboBox.FormattingEnabled = true;
            occupationComboBox.Location = new Point(30, 692);
            occupationComboBox.Name = "occupationComboBox";
            occupationComboBox.Size = new Size(405, 45);
            occupationComboBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 260);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 14;
            label1.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 384);
            label2.Name = "label2";
            label2.Size = new Size(157, 37);
            label2.TabIndex = 15;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 507);
            label3.Name = "label3";
            label3.Size = new Size(177, 37);
            label3.TabIndex = 16;
            label3.Text = "Zipcode:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 636);
            label4.Name = "label4";
            label4.Size = new Size(237, 37);
            label4.TabIndex = 17;
            label4.Text = "Occupation:";
            // 
            // Adduser
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1681, 1037);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(occupationComboBox);
            Controls.Add(addUserButton);
            Controls.Add(zipCodeTextBox);
            Controls.Add(genderTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(addUserUIHeader);
            Controls.Add(listBox1);
            Controls.Add(addedMovieLabel);
            Font = new Font("SimSun", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Adduser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adduser";
            Load += Adduser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label addedMovieLabel;
        private Label addUserUIHeader;
        private TextBox ageTextBox;
        private TextBox genderTextBox;
        private TextBox zipCodeTextBox;
        private Button addUserButton;
        private ComboBox occupationComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}