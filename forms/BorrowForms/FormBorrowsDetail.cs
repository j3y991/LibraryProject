using System;
using System.Windows.Forms;

namespace Library.Forms.BorrowDetails
{
    public partial class BorrowDetails : Form
    {
        private bool isNewBorrow = true;
        public Borrow Borrow { get; set; } = new Borrow();

        public BorrowDetails()
        {
            InitializeComponent();
        }

        private void BorrowDetails_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadBooks();
            TranslateUIElements();

            if (Borrow.StudentBorrow != null && Borrow.BookBorrowed != null)
            {
                isNewBorrow = false;

                lb_Students.SelectedItem = Borrow.StudentBorrow;
                lb_Books.SelectedItem = Borrow.BookBorrowed;

                label_ID_value.Text = $"({Borrow.BookBorrowed.BookID})";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateSelections(out Student selectedStudent, out Book selectedBook))
                return;

            if (isNewBorrow && selectedBook.CopiesNum <= 0)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_NOT_ENOUGH_COPIES);
                return;
            }

            ApplyBorrowChanges(selectedStudent, selectedBook);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadStudents()
        {
            lb_Students.Items.Clear();
            foreach (var student in Base.Students)
            {
                lb_Students.Items.Add(student);
            }
        }

        private void LoadBooks()
        {
            lb_Books.Items.Clear();
            foreach (var book in Base.Books)
            {
                lb_Books.Items.Add(book);
            }
        }

        private void TranslateUIElements()
        {
            label_ID.Text = CONFIG_FORM.FORM_BORROW_DETAILS_ID;
            label_ID_value.Text = CONFIG_FORM.FORM_BORROW_DETAILS_ID_AUTOMATICALLY_GENERATED;
            label_Student.Text = CONFIG_FORM.FORM_BORROW_DETAILS_STUDENT;
            label_Book.Text = CONFIG_FORM.FORM_BORROW_DETAILS_BOOK;
            btn_Ok.Text = CONFIG_FORM.FORM_BORROW_DETAILS_OK_BTN;
            btn_Cancel.Text = CONFIG_FORM.FORM_BORROW_DETAILS_CANCEL_BTN;
        }

        private bool ValidateSelections(out Student student, out Book book)
        {
            student = null;
            book = null;
            if (lb_Students.SelectedItem == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_STUDENT);
                return false;
            }

            if (lb_Books.SelectedItem == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_BOOK);
                return false;
            }

            student = lb_Students.SelectedItem as Student;
            book = lb_Books.SelectedItem as Book;
            return true;
        }

        private void ApplyBorrowChanges(Student student, Book book)
        {
            Borrow.StudentBorrow = student;
            Borrow.BookBorrowed = book;

            if (isNewBorrow)
                book.CopiesNum--;
        }
    }
}
