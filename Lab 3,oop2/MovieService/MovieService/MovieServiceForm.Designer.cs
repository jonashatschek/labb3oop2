namespace MovieService
{
    partial class MovieServiceForm
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showAllMoviesBtn = new System.Windows.Forms.Button();
            this.showAllCategories = new System.Windows.Forms.Button();
            this.showMoviesFromCategory = new System.Windows.Forms.Button();
            this.categories_comboBox = new System.Windows.Forms.ComboBox();
            this.categoriesRetrieveGroupBox = new System.Windows.Forms.GroupBox();
            this.yearRetrieveGroup = new System.Windows.Forms.GroupBox();
            this.showMoviesFromYear = new System.Windows.Forms.Button();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.Information_groupbox = new System.Windows.Forms.GroupBox();
            this.amountInList_textBox = new System.Windows.Forms.TextBox();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.yearOfPublication_textBox = new System.Windows.Forms.TextBox();
            this.rating_textBox = new System.Windows.Forms.TextBox();
            this.numberOfVotes_textbox = new System.Windows.Forms.TextBox();
            this.category_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mostPopularMovie_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amountInFilteredList_textBox = new System.Windows.Forms.TextBox();
            this.descendingOrder_radioBtn = new System.Windows.Forms.RadioButton();
            this.ascendingOrder_radioBtn = new System.Windows.Forms.RadioButton();
            this.amountOfFilmsInRatingList_trackBar = new System.Windows.Forms.TrackBar();
            this.sortMoviesAfterRating_button = new System.Windows.Forms.Button();
            this.categoriesRetrieveGroupBox.SuspendLayout();
            this.yearRetrieveGroup.SuspendLayout();
            this.Information_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfFilmsInRatingList_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(37, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // showAllMoviesBtn
            // 
            this.showAllMoviesBtn.Location = new System.Drawing.Point(18, 21);
            this.showAllMoviesBtn.Name = "showAllMoviesBtn";
            this.showAllMoviesBtn.Size = new System.Drawing.Size(201, 71);
            this.showAllMoviesBtn.TabIndex = 1;
            this.showAllMoviesBtn.Text = "Show all movies";
            this.showAllMoviesBtn.UseVisualStyleBackColor = true;
            this.showAllMoviesBtn.Click += new System.EventHandler(this.showAllMoviesBtn_Click);
            // 
            // showAllCategories
            // 
            this.showAllCategories.Location = new System.Drawing.Point(299, 21);
            this.showAllCategories.Name = "showAllCategories";
            this.showAllCategories.Size = new System.Drawing.Size(201, 71);
            this.showAllCategories.TabIndex = 2;
            this.showAllCategories.Text = "Show all categories";
            this.showAllCategories.UseVisualStyleBackColor = true;
            this.showAllCategories.Click += new System.EventHandler(this.showAllCategories_Click);
            // 
            // showMoviesFromCategory
            // 
            this.showMoviesFromCategory.Location = new System.Drawing.Point(6, 51);
            this.showMoviesFromCategory.Name = "showMoviesFromCategory";
            this.showMoviesFromCategory.Size = new System.Drawing.Size(109, 41);
            this.showMoviesFromCategory.TabIndex = 3;
            this.showMoviesFromCategory.Text = "Filter movies";
            this.showMoviesFromCategory.UseVisualStyleBackColor = true;
            this.showMoviesFromCategory.Click += new System.EventHandler(this.showMoviesFromCategory_Click);
            // 
            // categories_comboBox
            // 
            this.categories_comboBox.FormattingEnabled = true;
            this.categories_comboBox.Location = new System.Drawing.Point(6, 21);
            this.categories_comboBox.Name = "categories_comboBox";
            this.categories_comboBox.Size = new System.Drawing.Size(109, 24);
            this.categories_comboBox.TabIndex = 4;
            this.categories_comboBox.SelectedIndexChanged += new System.EventHandler(this.categories_comboBox_SelectedIndexChanged);
            // 
            // categoriesRetrieveGroupBox
            // 
            this.categoriesRetrieveGroupBox.Controls.Add(this.categories_comboBox);
            this.categoriesRetrieveGroupBox.Controls.Add(this.showMoviesFromCategory);
            this.categoriesRetrieveGroupBox.Location = new System.Drawing.Point(299, 198);
            this.categoriesRetrieveGroupBox.Name = "categoriesRetrieveGroupBox";
            this.categoriesRetrieveGroupBox.Size = new System.Drawing.Size(201, 100);
            this.categoriesRetrieveGroupBox.TabIndex = 5;
            this.categoriesRetrieveGroupBox.TabStop = false;
            this.categoriesRetrieveGroupBox.Text = "Retrieve movies in category";
            // 
            // yearRetrieveGroup
            // 
            this.yearRetrieveGroup.Controls.Add(this.showMoviesFromYear);
            this.yearRetrieveGroup.Controls.Add(this.year_comboBox);
            this.yearRetrieveGroup.Location = new System.Drawing.Point(12, 198);
            this.yearRetrieveGroup.Name = "yearRetrieveGroup";
            this.yearRetrieveGroup.Size = new System.Drawing.Size(195, 100);
            this.yearRetrieveGroup.TabIndex = 6;
            this.yearRetrieveGroup.TabStop = false;
            this.yearRetrieveGroup.Text = "Retrieve movies from year";
            // 
            // showMoviesFromYear
            // 
            this.showMoviesFromYear.Location = new System.Drawing.Point(0, 52);
            this.showMoviesFromYear.Name = "showMoviesFromYear";
            this.showMoviesFromYear.Size = new System.Drawing.Size(109, 42);
            this.showMoviesFromYear.TabIndex = 1;
            this.showMoviesFromYear.Text = "Filter movies";
            this.showMoviesFromYear.UseVisualStyleBackColor = true;
            this.showMoviesFromYear.Click += new System.EventHandler(this.showMoviesFromYear_Click);
            // 
            // year_comboBox
            // 
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(0, 21);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(109, 24);
            this.year_comboBox.TabIndex = 0;
            this.year_comboBox.SelectedIndexChanged += new System.EventHandler(this.year_comboBox_SelectedIndexChanged);
            // 
            // Information_groupbox
            // 
            this.Information_groupbox.Controls.Add(this.amountInList_textBox);
            this.Information_groupbox.Controls.Add(this.title_textBox);
            this.Information_groupbox.Controls.Add(this.yearOfPublication_textBox);
            this.Information_groupbox.Controls.Add(this.rating_textBox);
            this.Information_groupbox.Controls.Add(this.numberOfVotes_textbox);
            this.Information_groupbox.Controls.Add(this.category_textBox);
            this.Information_groupbox.Location = new System.Drawing.Point(25, 443);
            this.Information_groupbox.Name = "Information_groupbox";
            this.Information_groupbox.Size = new System.Drawing.Size(777, 92);
            this.Information_groupbox.TabIndex = 7;
            this.Information_groupbox.TabStop = false;
            this.Information_groupbox.Text = "Information";
            this.Information_groupbox.Enter += new System.EventHandler(this.Information_groupbox_Enter);
            // 
            // amountInList_textBox
            // 
            this.amountInList_textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.amountInList_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountInList_textBox.Location = new System.Drawing.Point(12, 21);
            this.amountInList_textBox.Name = "amountInList_textBox";
            this.amountInList_textBox.ReadOnly = true;
            this.amountInList_textBox.Size = new System.Drawing.Size(67, 15);
            this.amountInList_textBox.TabIndex = 10;
            this.amountInList_textBox.TextChanged += new System.EventHandler(this.amountInList_textBox_TextChanged);
            // 
            // title_textBox
            // 
            this.title_textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.title_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_textBox.Location = new System.Drawing.Point(85, 21);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(320, 15);
            this.title_textBox.TabIndex = 9;
            // 
            // yearOfPublication_textBox
            // 
            this.yearOfPublication_textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yearOfPublication_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearOfPublication_textBox.Location = new System.Drawing.Point(85, 42);
            this.yearOfPublication_textBox.Name = "yearOfPublication_textBox";
            this.yearOfPublication_textBox.Size = new System.Drawing.Size(138, 15);
            this.yearOfPublication_textBox.TabIndex = 8;
            // 
            // rating_textBox
            // 
            this.rating_textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rating_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rating_textBox.Location = new System.Drawing.Point(229, 42);
            this.rating_textBox.Name = "rating_textBox";
            this.rating_textBox.Size = new System.Drawing.Size(77, 15);
            this.rating_textBox.TabIndex = 7;
            // 
            // numberOfVotes_textbox
            // 
            this.numberOfVotes_textbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numberOfVotes_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberOfVotes_textbox.Location = new System.Drawing.Point(312, 42);
            this.numberOfVotes_textbox.Name = "numberOfVotes_textbox";
            this.numberOfVotes_textbox.Size = new System.Drawing.Size(137, 15);
            this.numberOfVotes_textbox.TabIndex = 6;
            // 
            // category_textBox
            // 
            this.category_textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.category_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_textBox.Location = new System.Drawing.Point(411, 21);
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(277, 15);
            this.category_textBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mostPopularMovie_button);
            this.groupBox1.Controls.Add(this.showAllMoviesBtn);
            this.groupBox1.Controls.Add(this.showAllCategories);
            this.groupBox1.Controls.Add(this.categoriesRetrieveGroupBox);
            this.groupBox1.Controls.Add(this.yearRetrieveGroup);
            this.groupBox1.Location = new System.Drawing.Point(377, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 425);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // mostPopularMovie_button
            // 
            this.mostPopularMovie_button.Location = new System.Drawing.Point(59, 98);
            this.mostPopularMovie_button.Name = "mostPopularMovie_button";
            this.mostPopularMovie_button.Size = new System.Drawing.Size(409, 84);
            this.mostPopularMovie_button.TabIndex = 7;
            this.mostPopularMovie_button.Text = "Show 100 most popular movies";
            this.mostPopularMovie_button.UseVisualStyleBackColor = true;
            this.mostPopularMovie_button.Click += new System.EventHandler(this.mostPopularMovie_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amountInFilteredList_textBox);
            this.groupBox2.Controls.Add(this.descendingOrder_radioBtn);
            this.groupBox2.Controls.Add(this.ascendingOrder_radioBtn);
            this.groupBox2.Controls.Add(this.amountOfFilmsInRatingList_trackBar);
            this.groupBox2.Controls.Add(this.sortMoviesAfterRating_button);
            this.groupBox2.Location = new System.Drawing.Point(383, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 106);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort movies after rating";
            // 
            // amountInFilteredList_textBox
            // 
            this.amountInFilteredList_textBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.amountInFilteredList_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountInFilteredList_textBox.Location = new System.Drawing.Point(12, 79);
            this.amountInFilteredList_textBox.Name = "amountInFilteredList_textBox";
            this.amountInFilteredList_textBox.Size = new System.Drawing.Size(67, 22);
            this.amountInFilteredList_textBox.TabIndex = 11;
            this.amountInFilteredList_textBox.TextChanged += new System.EventHandler(this.amountInFilteredList_textBox_TextChanged);
            // 
            // descendingOrder_radioBtn
            // 
            this.descendingOrder_radioBtn.AutoSize = true;
            this.descendingOrder_radioBtn.Location = new System.Drawing.Point(229, 76);
            this.descendingOrder_radioBtn.Name = "descendingOrder_radioBtn";
            this.descendingOrder_radioBtn.Size = new System.Drawing.Size(94, 21);
            this.descendingOrder_radioBtn.TabIndex = 3;
            this.descendingOrder_radioBtn.TabStop = true;
            this.descendingOrder_radioBtn.Text = "Best rated";
            this.descendingOrder_radioBtn.UseVisualStyleBackColor = true;
            // 
            // ascendingOrder_radioBtn
            // 
            this.ascendingOrder_radioBtn.AutoSize = true;
            this.ascendingOrder_radioBtn.Location = new System.Drawing.Point(98, 76);
            this.ascendingOrder_radioBtn.Name = "ascendingOrder_radioBtn";
            this.ascendingOrder_radioBtn.Size = new System.Drawing.Size(103, 21);
            this.ascendingOrder_radioBtn.TabIndex = 2;
            this.ascendingOrder_radioBtn.TabStop = true;
            this.ascendingOrder_radioBtn.Text = "Worst rated";
            this.ascendingOrder_radioBtn.UseVisualStyleBackColor = true;
            // 
            // amountOfFilmsInRatingList_trackBar
            // 
            this.amountOfFilmsInRatingList_trackBar.Location = new System.Drawing.Point(6, 22);
            this.amountOfFilmsInRatingList_trackBar.Name = "amountOfFilmsInRatingList_trackBar";
            this.amountOfFilmsInRatingList_trackBar.Size = new System.Drawing.Size(340, 56);
            this.amountOfFilmsInRatingList_trackBar.TabIndex = 1;
            this.amountOfFilmsInRatingList_trackBar.Scroll += new System.EventHandler(this.amountOfFilmsInRatingList_trackBar_Scroll);
            // 
            // sortMoviesAfterRating_button
            // 
            this.sortMoviesAfterRating_button.Location = new System.Drawing.Point(369, 56);
            this.sortMoviesAfterRating_button.Name = "sortMoviesAfterRating_button";
            this.sortMoviesAfterRating_button.Size = new System.Drawing.Size(125, 41);
            this.sortMoviesAfterRating_button.TabIndex = 0;
            this.sortMoviesAfterRating_button.Text = "Sort";
            this.sortMoviesAfterRating_button.UseVisualStyleBackColor = true;
            this.sortMoviesAfterRating_button.Click += new System.EventHandler(this.sortMoviesAfterRating_button_Click);
            // 
            // MovieServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Information_groupbox);
            this.Controls.Add(this.listBox1);
            this.Name = "MovieServiceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MovieServiceForm_Load);
            this.categoriesRetrieveGroupBox.ResumeLayout(false);
            this.yearRetrieveGroup.ResumeLayout(false);
            this.Information_groupbox.ResumeLayout(false);
            this.Information_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfFilmsInRatingList_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showAllMoviesBtn;
        private System.Windows.Forms.Button showAllCategories;
        private System.Windows.Forms.Button showMoviesFromCategory;
        private System.Windows.Forms.ComboBox categories_comboBox;
        private System.Windows.Forms.GroupBox categoriesRetrieveGroupBox;
        private System.Windows.Forms.GroupBox yearRetrieveGroup;
        private System.Windows.Forms.Button showMoviesFromYear;
        private System.Windows.Forms.ComboBox year_comboBox;
        private System.Windows.Forms.GroupBox Information_groupbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox amountInList_textBox;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.TextBox yearOfPublication_textBox;
        private System.Windows.Forms.TextBox rating_textBox;
        private System.Windows.Forms.TextBox numberOfVotes_textbox;
        private System.Windows.Forms.TextBox category_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sortMoviesAfterRating_button;
        private System.Windows.Forms.TextBox amountInFilteredList_textBox;
        private System.Windows.Forms.RadioButton descendingOrder_radioBtn;
        private System.Windows.Forms.RadioButton ascendingOrder_radioBtn;
        private System.Windows.Forms.TrackBar amountOfFilmsInRatingList_trackBar;
        private System.Windows.Forms.Button mostPopularMovie_button;
    }
}

