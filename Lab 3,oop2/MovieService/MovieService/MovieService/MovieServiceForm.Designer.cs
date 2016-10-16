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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showAllMoviesBtn = new System.Windows.Forms.Button();
            this.showAllCategories = new System.Windows.Forms.Button();
            this.showMoviesFromCategory = new System.Windows.Forms.Button();
            this.categories_comboBox = new System.Windows.Forms.ComboBox();
            this.categoriesRetrieveGroupBox = new System.Windows.Forms.GroupBox();
            this.yearRetrieveGroup = new System.Windows.Forms.GroupBox();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.showMoviesFromYear = new System.Windows.Forms.Button();
            this.categoriesRetrieveGroupBox.SuspendLayout();
            this.yearRetrieveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(754, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // showAllMoviesBtn
            // 
            this.showAllMoviesBtn.Location = new System.Drawing.Point(785, 32);
            this.showAllMoviesBtn.Name = "showAllMoviesBtn";
            this.showAllMoviesBtn.Size = new System.Drawing.Size(201, 53);
            this.showAllMoviesBtn.TabIndex = 1;
            this.showAllMoviesBtn.Text = "Show all movies";
            this.showAllMoviesBtn.UseVisualStyleBackColor = true;
            this.showAllMoviesBtn.Click += new System.EventHandler(this.showAllMoviesBtn_Click);
            // 
            // showAllCategories
            // 
            this.showAllCategories.Location = new System.Drawing.Point(785, 91);
            this.showAllCategories.Name = "showAllCategories";
            this.showAllCategories.Size = new System.Drawing.Size(201, 59);
            this.showAllCategories.TabIndex = 2;
            this.showAllCategories.Text = "Show all categories";
            this.showAllCategories.UseVisualStyleBackColor = true;
            this.showAllCategories.Click += new System.EventHandler(this.showAllCategories_Click);
            // 
            // showMoviesFromCategory
            // 
            this.showMoviesFromCategory.Location = new System.Drawing.Point(6, 51);
            this.showMoviesFromCategory.Name = "showMoviesFromCategory";
            this.showMoviesFromCategory.Size = new System.Drawing.Size(166, 41);
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
            this.categories_comboBox.Size = new System.Drawing.Size(166, 24);
            this.categories_comboBox.TabIndex = 4;
            this.categories_comboBox.SelectedIndexChanged += new System.EventHandler(this.categories_comboBox_SelectedIndexChanged);
            // 
            // categoriesRetrieveGroupBox
            // 
            this.categoriesRetrieveGroupBox.Controls.Add(this.categories_comboBox);
            this.categoriesRetrieveGroupBox.Controls.Add(this.showMoviesFromCategory);
            this.categoriesRetrieveGroupBox.Location = new System.Drawing.Point(785, 156);
            this.categoriesRetrieveGroupBox.Name = "categoriesRetrieveGroupBox";
            this.categoriesRetrieveGroupBox.Size = new System.Drawing.Size(201, 103);
            this.categoriesRetrieveGroupBox.TabIndex = 5;
            this.categoriesRetrieveGroupBox.TabStop = false;
            this.categoriesRetrieveGroupBox.Text = "Retrieve movies in category";
            // 
            // yearRetrieveGroup
            // 
            this.yearRetrieveGroup.Controls.Add(this.showMoviesFromYear);
            this.yearRetrieveGroup.Controls.Add(this.year_comboBox);
            this.yearRetrieveGroup.Location = new System.Drawing.Point(791, 266);
            this.yearRetrieveGroup.Name = "yearRetrieveGroup";
            this.yearRetrieveGroup.Size = new System.Drawing.Size(195, 100);
            this.yearRetrieveGroup.TabIndex = 6;
            this.yearRetrieveGroup.TabStop = false;
            this.yearRetrieveGroup.Text = "Retrieve movies from year";
            // 
            // year_comboBox
            // 
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(0, 21);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(166, 24);
            this.year_comboBox.TabIndex = 0;
            this.year_comboBox.SelectedIndexChanged += new System.EventHandler(this.year_comboBox_SelectedIndexChanged);
            // 
            // showMoviesFromYear
            // 
            this.showMoviesFromYear.Location = new System.Drawing.Point(0, 52);
            this.showMoviesFromYear.Name = "showMoviesFromYear";
            this.showMoviesFromYear.Size = new System.Drawing.Size(166, 42);
            this.showMoviesFromYear.TabIndex = 1;
            this.showMoviesFromYear.Text = "Filter movies";
            this.showMoviesFromYear.UseVisualStyleBackColor = true;
            this.showMoviesFromYear.Click += new System.EventHandler(this.showMoviesFromYear_Click);
            // 
            // MovieServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 505);
            this.Controls.Add(this.yearRetrieveGroup);
            this.Controls.Add(this.categoriesRetrieveGroupBox);
            this.Controls.Add(this.showAllCategories);
            this.Controls.Add(this.showAllMoviesBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "MovieServiceForm";
            this.Text = "Form1";
            this.categoriesRetrieveGroupBox.ResumeLayout(false);
            this.yearRetrieveGroup.ResumeLayout(false);
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
    }
}

