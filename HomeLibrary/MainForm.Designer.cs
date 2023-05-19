namespace HomeLibrary
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            publicationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Author = new System.Windows.Forms.DataGridViewComboBoxColumn();
            authorBindingSource = new System.Windows.Forms.BindingSource(components);
            Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            genreBindingSource = new System.Windows.Forms.BindingSource(components);
            Publisher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            publisherBindingSource = new System.Windows.Forms.BindingSource(components);
            bookBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSubmit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            personsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            insertDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loanedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btLoan = new System.Windows.Forms.Button();
            peopleBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)publisherBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)peopleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iSBNDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, publicationYearDataGridViewTextBoxColumn, pagesDataGridViewTextBoxColumn, Author, Genre, Publisher });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new System.Drawing.Point(20, 53);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new System.Drawing.Size(2307, 1278);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.MinimumWidth = 10;
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.Width = 200;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // publicationYearDataGridViewTextBoxColumn
            // 
            publicationYearDataGridViewTextBoxColumn.DataPropertyName = "PublicationYear";
            publicationYearDataGridViewTextBoxColumn.HeaderText = "PublicationYear";
            publicationYearDataGridViewTextBoxColumn.MinimumWidth = 10;
            publicationYearDataGridViewTextBoxColumn.Name = "publicationYearDataGridViewTextBoxColumn";
            publicationYearDataGridViewTextBoxColumn.Width = 200;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            pagesDataGridViewTextBoxColumn.MinimumWidth = 10;
            pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            pagesDataGridViewTextBoxColumn.Width = 200;
            // 
            // Author
            // 
            Author.DataPropertyName = "AuthorID";
            Author.DataSource = authorBindingSource;
            Author.DisplayMember = "Name";
            Author.HeaderText = "Author";
            Author.MinimumWidth = 10;
            Author.Name = "Author";
            Author.ValueMember = "AuthorID";
            Author.Width = 200;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Author);
            // 
            // Genre
            // 
            Genre.DataPropertyName = "GenreID";
            Genre.DataSource = genreBindingSource;
            Genre.DisplayMember = "Name";
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 10;
            Genre.Name = "Genre";
            Genre.ValueMember = "GenreID";
            Genre.Width = 200;
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Genre);
            // 
            // Publisher
            // 
            Publisher.DataPropertyName = "PublisherID";
            Publisher.DataSource = publisherBindingSource;
            Publisher.DisplayMember = "Name";
            Publisher.HeaderText = "Publisher";
            Publisher.MinimumWidth = 10;
            Publisher.Name = "Publisher";
            Publisher.ValueMember = "PublisherID";
            Publisher.Width = 200;
            // 
            // publisherBindingSource
            // 
            publisherBindingSource.DataSource = typeof(Publisher);
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(180, 1342);
            btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(240, 49);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit Changes";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(20, 1342);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(150, 47);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { departmentToolStripMenuItem, editToolStripMenuItem, loanedToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(2347, 46);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            departmentToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { authorsToolStripMenuItem, genresToolStripMenuItem, publishersToolStripMenuItem, personsToolStripMenuItem, insertDatasetToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            editToolStripMenuItem.Text = "Edit";
            // 
            // authorsToolStripMenuItem
            // 
            authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            authorsToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            authorsToolStripMenuItem.Text = "Authors";
            authorsToolStripMenuItem.Click += authorsToolStripMenuItem_Click;
            // 
            // genresToolStripMenuItem
            // 
            genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            genresToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            genresToolStripMenuItem.Text = "Genres";
            genresToolStripMenuItem.Click += genresToolStripMenuItem_Click;
            // 
            // publishersToolStripMenuItem
            // 
            publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            publishersToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            publishersToolStripMenuItem.Text = "Publishers";
            publishersToolStripMenuItem.Click += publishersToolStripMenuItem_Click;
            // 
            // personsToolStripMenuItem
            // 
            personsToolStripMenuItem.Name = "personsToolStripMenuItem";
            personsToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            personsToolStripMenuItem.Text = "Persons";
            personsToolStripMenuItem.Click += personsToolStripMenuItem_Click;
            // 
            // insertDatasetToolStripMenuItem
            // 
            insertDatasetToolStripMenuItem.Name = "insertDatasetToolStripMenuItem";
            insertDatasetToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            insertDatasetToolStripMenuItem.Text = "Insert Dataset";
            insertDatasetToolStripMenuItem.Click += insertDatasetToolStripMenuItem_Click;
            // 
            // loanedToolStripMenuItem
            // 
            loanedToolStripMenuItem.Name = "loanedToolStripMenuItem";
            loanedToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
            loanedToolStripMenuItem.Text = "Loaned";
            loanedToolStripMenuItem.Click += loanedToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // btLoan
            // 
            btLoan.Location = new System.Drawing.Point(2177, 1344);
            btLoan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btLoan.Name = "btLoan";
            btLoan.Size = new System.Drawing.Size(150, 47);
            btLoan.TabIndex = 13;
            btLoan.Text = "Loan Book";
            btLoan.UseVisualStyleBackColor = true;
            btLoan.Click += btLoan_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2347, 1410);
            Controls.Add(btLoan);
            Controls.Add(menuStrip1);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)publisherBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)peopleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Author;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Publisher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btLoan;
        private System.Windows.Forms.ToolStripMenuItem personsToolStripMenuItem;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.ToolStripMenuItem insertDatasetToolStripMenuItem;
    }
}
