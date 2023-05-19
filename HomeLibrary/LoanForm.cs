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
    public partial class LoanForm : Form
    {
        private DataContextHomeLibrary context;
        private Book book;
        public LoanForm(DataContextHomeLibrary _context, Book _book)
        {
            InitializeComponent();
            this.context = _context;
            this.book = _book;
            personBindingSource.DataSource = context.People;
            lbBook.Text = $"Name: {book.Title}";
            lbISBN.Text = $"Name: {book.ISBN}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Checkout newCheckout = new Checkout();
            newCheckout.Book = book;
            var selectedPerson = from per in context.People
                                 where per.Name == cbLoaner.Text
                                 select per;

            if (selectedPerson.Count() == 1)
                newCheckout.Person = selectedPerson.First();

            var selectedBook = from per in context.People
                               where per.Name == cbLoaner.Text
                               select per;

            context.Checkouts.InsertOnSubmit(newCheckout);
            context.SubmitChanges();
            this.Close();
        }
    }
}
