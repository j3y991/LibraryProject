using Library.Forms.BookDetails;
using System;
using System.Windows.Forms;

namespace Library.Forms.Books
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void TranslateUIElements()
        {
            form_title.Text = CONFIG_FORM.FORM_BOOK_TITLE;
            btn_Add.Text = CONFIG_FORM.FORM_BOOK_ADD;
            btn_Edit.Text = CONFIG_FORM.FORM_BOOK_EDIT;
            btn_Remove.Text = CONFIG_FORM.FORM_BOOK_REMOVE;
        }

        private void UpdateBookList()
        {
            lb_Books.Items.Clear();
            foreach (var book in Base.Books)
            {
                lb_Books.Items.Add(book);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var bookDetailForm = new FormBooksDetail();
            var dialogResult = bookDetailForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var newBook = bookDetailForm.Book;
                if (IsBookExists(newBook))
                {
                    MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_BOOK_ALREADY_EXISTS);
                }
                else
                {
                    Base.Books.Add(newBook);
                    UpdateBookList();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var selectedBook = lb_Books.SelectedItem as Book;

            if (selectedBook == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_BOOK);
                return;
            }

            var bookDetailForm = new FormBooksDetail
            {
                Book = selectedBook
            };

            var dialogResult = bookDetailForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                UpdateBookDetails(selectedBook, bookDetailForm.Book);
                UpdateBookList();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var selectedBook = lb_Books.SelectedItem as Book;

            if (selectedBook == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_BOOK);
                return;
            }

            Base.Books.Remove(selectedBook);
            UpdateBookList();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            TranslateUIElements();
            UpdateBookList();
        }

        private bool IsBookExists(Book book)
        {
            foreach (var existingBook in Base.Books)
            {
                if (existingBook.BookID == book.BookID)
                {
                    return true;
                }
            }
            return false;
        }

        private void UpdateBookDetails(Book selectedBook, Book updatedBook)
        {
            selectedBook.Title = updatedBook.Title;
            selectedBook.Author = updatedBook.Author;
            selectedBook.CopiesNum = updatedBook.CopiesNum;
            selectedBook.ReleaseYear = updatedBook.ReleaseYear;
        }
    }
}
