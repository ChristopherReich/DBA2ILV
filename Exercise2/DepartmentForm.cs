using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ormExample;

namespace Exercise2
{
    public partial class DepartmentForm : Form
    {
        private DataContext context;
        public DepartmentForm(DataContext _context)
        {
            context = _context;
            InitializeComponent();
            InitializeContext();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            btnSubmit.Enabled = false;
        }

        private void InitializeContext()
        {
            context = new();
            departmentBindingSource.DataSource = this.context.Departments;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var selectedItems = from s in context.Departments
                                        where s.Name == row.Cells[0].Value && s.Abbreviation == row.Cells[1].Value
                                        select s;
                    MessageBox.Show($"{selectedItems.Count()} departments will be deleted.");
                    context.Departments.DeleteAllOnSubmit(selectedItems);
                }
            }
            context.SubmitChanges();
            InitializeContext();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            context.SubmitChanges();
            btnSubmit.Enabled = false;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }
    }
}
