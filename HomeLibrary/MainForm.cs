using Devart.Data.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Devart.Common.NativeMethods;
using static System.Windows.Forms.AxHost;


namespace HomeLibrary
{
    public partial class MainForm : Form
    {
        private DataContextHomeLibrary context;
        public MainForm()
        {
            InitializeComponent();
            InitializeContext();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            btnSubmit.Enabled = false;
        }



        private void InitializeContext()
        {
            context = new();
            bookBindingSource.DataSource = this.context.Books;
            authorBindingSource.DataSource = this.context.Authors;
            genreBindingSource.DataSource = this.context.Genres;
            publisherBindingSource.DataSource = this.context.Publishers;
            peopleBindingSource.DataSource = this.context.People;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                context.SubmitChanges();
                btnSubmit.Enabled = false;
                InitializeContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dataGridView1.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var selectedItems = from s in context.Books
                                            where s.ISBN == row.Cells[0].Value && s.Title == row.Cells[1].Value
                                            select s;
                        MessageBox.Show($"{selectedItems.Count()} entries will be deleted.");
                        context.Books.DeleteOnSubmit(selectedItems.First());
                    }
                }
                context.SubmitChanges();
                InitializeContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm(authorBindingSource, context, ETables.Author);
            EditForm.StartPosition = FormStartPosition.CenterParent;
            EditForm.Text = "Authors";
            EditForm.ShowDialog();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm(genreBindingSource, context, ETables.Genre);
            EditForm.StartPosition = FormStartPosition.CenterParent;
            EditForm.Text = "Genres";
            EditForm.ShowDialog();
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm(publisherBindingSource, context, ETables.Publisher);
            EditForm.StartPosition = FormStartPosition.CenterParent;
            EditForm.Text = "Publishers";
            EditForm.ShowDialog();
        }

        private void personsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm(publisherBindingSource, context, ETables.People);
            EditForm.StartPosition = FormStartPosition.CenterParent;
            EditForm.Text = "People";
            EditForm.ShowDialog();
        }

        private void loanedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanedBooksForm EditForm = new LoanedBooksForm(context);
            EditForm.StartPosition = FormStartPosition.CenterParent;
            EditForm.ShowDialog();
        }

        private void btLoan_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var selectedItems = from s in context.Books
                                        where s.ISBN == row.Cells[0].Value && s.Title == row.Cells[1].Value
                                        select s;

                    LoanForm LoanForm = new LoanForm(context, selectedItems.First());
                    LoanForm.StartPosition = FormStartPosition.CenterParent;
                    LoanForm.ShowDialog();
                }
            }
        }

        private void insertDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (context.People.Count() == 0)
            {
                List<string> people = new List<string> { "Christopher Reich", "Simon Schachinger", "Andreas Parzer", "Johannes Reinwein" };
                foreach (string name in people)
                {
                    Person p = new Person(); p.Name = name;
                    context.People.InsertOnSubmit(p);
                    context.SubmitChanges();
                }
            }

            if (context.Authors.Count() == 0)
            {
                List<string> authors = new List<string> { "Christopher Paulini", "J. K. Rowling", "J. R. R. Tolkien", "Joyo Mojes" };
                foreach (string name in authors)
                {
                    Author p = new Author(); p.Name = name;
                    context.Authors.InsertOnSubmit(p);
                    context.SubmitChanges();
                }
            }

            if (context.Genres.Count() == 0)
            {
                List<string> genres = new List<string> { "Roman", "Krimi", "Fantasy", "Thriller" };
                foreach (string name in genres)
                {
                    Genre p = new Genre(); p.Name = name;
                    context.Genres.InsertOnSubmit(p);
                    context.SubmitChanges();
                }
            }

            if (context.Publishers.Count() == 0)
            {
                List<string> publishers = new List<string> { "Piper Verlag", "blanvalet", "Goldman", "Hobbit Press" };
                foreach (string name in publishers)
                {
                    Publisher p = new Publisher(); p.Name = name;
                    context.Publishers.InsertOnSubmit(p);
                    context.SubmitChanges();
                }
            }

            //if (context.Books.Count() == 0)
            //{
            //    Book p1 = new Book(); p1.ISBN = "123-456-789"; p1.Title = "Eragon 1"; p1.Pages = 500;
            //    Book p2 = new Book(); p2.ISBN = "321-456-789"; p2.Title = "Eragon 2"; p2.Pages = 600;
            //    context.Books.InsertOnSubmit(p1);
            //    context.Books.InsertOnSubmit(p2);
            //    context.SubmitChanges();
            //}

            InitializeContext();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ReadMe.txt");
                string text = "";

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        text += line;
                        text += "\n";
                        //Read
                    }

                }

                MessageBox.Show(text);
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
