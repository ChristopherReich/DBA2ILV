using ormExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class MainForm : Form
    {
        private DataContext context;
        public MainForm()
        {
            InitializeComponent();
            InitializeContext();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnSubmit.Enabled = false;
        }


        private void InitializeContext()
        {
            context = new();
            bindingSourceStudents.DataSource = this.context.Students;
            bindingSourceDepartments.DataSource = this.context.Departments;
            ShowStudentsInDataGrid();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializeContext();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            context.SubmitChanges();
            btnSubmit.Enabled = false;
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsInDataGrid();
            btnDelete.Enabled = true;
            btnNew.Enabled = true;

        }


        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = from it in context.Departments
                        select it;

            dataGridView1.DataSource = query;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            NewStudentForm newItemForm = new NewStudentForm(context);
            newItemForm.BtnSaveStudent -= NewForm_BtnSaveStudent;
            newItemForm.BtnSaveStudent += NewForm_BtnSaveStudent;
            newItemForm.ShowDialog();
        }

        private void NewForm_BtnSaveStudent(object? sender, List<string> e)
        {
            Student newStudent = new Student();
            newStudent.PreName = e[0];
            newStudent.SurName = e[1];
            newStudent.MatNo = e[2];

            var selectedDepartments = from dep in context.Departments
                                      where dep.Name == e[3]
                                      select dep;

            if (selectedDepartments.Count() == 1)
                newStudent.Department = selectedDepartments.First();

            context.Students.InsertOnSubmit(newStudent);
            context.SubmitChanges();
            ShowStudentsInDataGrid();
        }

        private void ShowStudentsInDataGrid()
        {
            var query = from s in context.Students
                        join d in context.Departments on s.DepID equals d.DepID
                        select new
                        {
                            Prename = s.PreName,
                            Surname = s.SurName,
                            MatNr = s.MatNo,
                            Department = s.Department.Name
                        };

            dataGridView1.DataSource = query;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var selectedStudents = from s in context.Students
                                           where s.PreName == row.Cells[0].Value && s.SurName == row.Cells[1].Value && s.MatNo == row.Cells[2].Value
                                           select s;

                    context.Students.DeleteAllOnSubmit(selectedStudents);
                }
            }
            context.SubmitChanges();
            ShowStudentsInDataGrid();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }
    }
}
