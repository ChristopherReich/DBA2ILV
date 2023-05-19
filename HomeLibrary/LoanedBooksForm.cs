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
    public partial class LoanedBooksForm : Form
    {
        private DataContextHomeLibrary context;

        public LoanedBooksForm(DataContextHomeLibrary _context)
        {
            this.context = _context;
            InitializeComponent();
            InitializeContext();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            btnSubmit.Enabled = false;
        }

        private void InitializeContext()
        {
            context = new();
            checkoutBindingSource.DataSource = this.context.Checkouts;
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

        private void btnReturned_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var selectedItems = from s in context.Checkouts
                                        where s.CheckoutID == (int)row.Cells[0].Value && s.PersonID == (int)row.Cells[1].Value && s.Book == row.Cells[3].Value
                                        select s;
                    MessageBox.Show($"{selectedItems.Count()} entries will be deleted.");
                    context.Checkouts.DeleteAllOnSubmit(selectedItems);
                }
            }
            context.SubmitChanges();
            InitializeContext();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }
    }
}
