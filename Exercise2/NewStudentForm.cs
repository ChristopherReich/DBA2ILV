using ormExample;
using System;
using System.Collections;
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
    public partial class NewStudentForm : Form
    {
        DataContext context;
        public event EventHandler<List<string>> BtnSaveStudent;

        public NewStudentForm(DataContext _context)
        {
            InitializeComponent();
            var query = from it in _context.Departments
                        select it.Name;
            combobox1.DataSource = query;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(textbox1.Text);
            list.Add(textbox2.Text);
            list.Add(textbox3.Text);
            list.Add(combobox1.Text);
            BtnSaveStudent?.Invoke(this, list);
            this.Close();
        }
    }
}
