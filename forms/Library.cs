using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            Base.Initialize();
            TranslateUI();
        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileHandler.Save_DB();
        }

        private void TranslateUI()
        {
            btn_Books.Text = CONFIG_FORM.FORM_LIBRARY_BOOKS_BTN;
            btn_Borrows.Text = CONFIG_FORM.FORM_LIBRARY_BORROWS_BTN;
            btn_Students.Text = CONFIG_FORM.FORM_LIBRARY_STUDENTS_BTN;
            btn_Database.Text = CONFIG_FORM.FORM_LIBRARY_RESET_DB_BTN;
            form_title.Text = CONFIG_FORM.FORM_LIBRARY_TITLE;
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            if (Base.EncounteredError)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
                return;
            }
            var studentForm = new Forms.Students.FormStudents();
            studentForm.ShowDialog();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            if (Base.EncounteredError)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
                return;
            }
            var bookForm = new Forms.Books.FormBooks();
            bookForm.ShowDialog();
        }

        private void BtnBorrows_Click(object sender, EventArgs e)
        {
            if (Base.EncounteredError)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
                return;
            }
            var borrowsForm = new Forms.Borrows.FormBorrows();
            borrowsForm.ShowDialog();
        }

        private void BtnResetDatabase_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                CONFIG_NOTIFIERS.NOTIFIER_RESET_DB_DESCRIPTION,
                CONFIG_NOTIFIERS.NOTIFIER_RESET_DB_TITLE,
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Base.ResetDB = true;
                Close();
            }
        }
    }
}
