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
    public partial class StudentForm : Form
    {
        private DataContext context;
        public StudentForm()
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
            departmentBindingSource.DataSource = this.context.Departments;
            studentBindingSource.DataSource = this.context.Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var selectedItems = from s in context.Students
                                        where s.SurName == row.Cells[0].Value && s.PreName == row.Cells[1].Value && s.MatNo == row.Cells[2].Value
                                        select s;
                    MessageBox.Show($"{selectedItems.Count()} student will be deleted.");
                    context.Students.DeleteAllOnSubmit(selectedItems);
                }
            }
            context.SubmitChanges();
            InitializeContext();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            context.SubmitChanges();
            btnSubmit.Enabled = false;
            InitializeContext();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm Department = new DepartmentForm(context);
            Department.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            newStudent.PreName = "Max";
            newStudent.SurName = "Mustermann";
            newStudent.MatNo = "1234";
            newStudent.Department = context.Departments.First();

            context.Students.InsertOnSubmit(newStudent);
            context.SubmitChanges();
            InitializeContext();

        }
    }
}
