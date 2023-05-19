using Devart.Data.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLibrary
{
    public enum ETables
    {
        Author,
        Genre,
        Publisher,
        People
    }
    public partial class EditForm : Form
    {
        private BindingSource bindingSource;
        private DataContextHomeLibrary context;
        private ETables eTable;

        public EditForm(BindingSource _bindingSource, DataContextHomeLibrary _context, ETables _eTable)
        {
            bindingSource = _bindingSource;
            context = _context;
            eTable = _eTable;

            InitializeComponent();
            InitializeContext();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Columns[0].Visible = false; ;
            btnSubmit.Enabled = false;
        }

        private void InitializeContext()
        {
            context = new();

            switch (eTable)
            {
                case ETables.Author:
                    dataGridView1.DataSource = context.Authors;
                    bindingSource.DataSource = context.Authors;
                    break;
                case ETables.Genre:
                    dataGridView1.DataSource = context.Genres;
                    bindingSource.DataSource = context.Genres;
                    break;
                case ETables.Publisher:
                    dataGridView1.DataSource = context.Publishers;
                    bindingSource.DataSource = context.Publishers;
                    break;
                case ETables.People:
                    dataGridView1.DataSource = context.People;
                    bindingSource.DataSource = context.People;
                    break;
                default:
                    break;
            }
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

                        switch (eTable)
                        {
                            case ETables.Author:
                                var selectedAuthors = from s in context.Authors where s.Name == row.Cells[1].Value select s;
                                MessageBox.Show($"{selectedAuthors.Count()} entries will be deleted.");
                                context.Authors.DeleteAllOnSubmit(selectedAuthors);
                                break;

                            case ETables.Genre:
                                var selectedGenres = from s in context.Genres where s.Name == row.Cells[1].Value select s;
                                MessageBox.Show($"{selectedGenres.Count()} entries will be deleted.");
                                context.Genres.DeleteAllOnSubmit(selectedGenres);
                                break;
                            case ETables.Publisher:
                                var selectedPublishers = from s in context.Publishers where s.Name == row.Cells[1].Value select s;
                                MessageBox.Show($"{selectedPublishers.Count()} entries will be deleted.");
                                context.Publishers.DeleteAllOnSubmit(selectedPublishers);
                                break;
                            case ETables.People:
                                var selectedPersons = from s in context.People where s.Name == row.Cells[1].Value select s;
                                MessageBox.Show($"{selectedPersons.Count()} entries will be deleted.");
                                context.People.DeleteAllOnSubmit(selectedPersons);
                                break;
                            default:
                                break;
                        }

                    }
                    context.SubmitChanges();
                    InitializeContext();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            context.SubmitChanges();
            InitializeContext();
            this.Close();
        }
    }
}
