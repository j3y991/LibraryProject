using System;
using System.Windows.Forms;

namespace Library.Forms.BookDetails
{
    public partial class FormBooksDetail : Form
    {
        public Book Book = new Book();

        public FormBooksDetail()
        {
            InitializeComponent();
        }

        private void LoadReleaseYearDropdown()
        {
            for (int year = CONFIG.FORM_BOOK_DETAILS_RELEASE_YEAR_MIN; year <= CONFIG.FORM_BOOK_DETAILS_RELEASE_YEAR_MAX; year++)
            {
                cb_Release_Year.Items.Add(year);
            }
        }

        private void LoadCopiesNumDropdown()
        {
            for (int num = 1; num <= 1000; num++)
            {
                cb_CopiesNum.Items.Add(num);
            }
        }

        private void TranslateUIElements()
        {
            label_ID.Text = CONFIG_FORM.FORM_BOOK_DETAILS_ID;
            label_Author.Text = CONFIG_FORM.FORM_BOOK_DETAILS_AUTHOR;
            label_Title.Text = CONFIG_FORM.FORM_BOOK_DETAILS_TITLE;
            label_ReleaseYear.Text = CONFIG_FORM.FORM_BOOK_DETAILS_RELEASE_YEAR;
            label_CopiesNum.Text = CONFIG_FORM.FORM_BOOK_DETAILS_COPIES_NUM;
            btn_Ok.Text = CONFIG_FORM.FORM_BOOK_DETAILS_OK_BTN;
            btn_Cancel.Text = CONFIG_FORM.FORM_BOOK_DETAILS_CANCEL_BTN;
        }

        private void FormBooksDetail_Load(object sender, EventArgs e)
        {
            LoadReleaseYearDropdown();
            LoadCopiesNumDropdown();
            TranslateUIElements();

            if (!string.IsNullOrEmpty(Book.Title))
            {
                tb_bookId.Text = Book.BookID;
                tb_Title.Text = Book.Title;
                tb_Author.Text = Book.Author;
                cb_Release_Year.SelectedItem = Book.ReleaseYear.ToString();
                cb_CopiesNum.SelectedItem = Book.CopiesNum.ToString();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                UpdateBookDetails();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInputs()
        {
            if (!IsValidReleaseYear() || !IsValidCopiesNum())
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_INVALID_INPUT_RELEASE_YEAR_COPIES_NUM);
                return false;
            }

            if (!IsValidBookId())
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_INVALID_INPUT_ID);
                return false;
            }

            return true;
        }

        private bool IsValidReleaseYear()
        {
            return cb_Release_Year.Items.Contains(Int32.Parse(cb_Release_Year.Text));
        }

        private bool IsValidCopiesNum()
        {
            return cb_CopiesNum.Items.Contains(Int32.Parse(cb_CopiesNum.Text));
        }

        private bool IsValidBookId()
        {
            return Int32.TryParse(tb_bookId.Text, out _);
        }

        private void UpdateBookDetails()
        {
            Book.BookID = tb_bookId.Text;
            Book.Title = tb_Title.Text;
            Book.Author = tb_Author.Text;
            Book.ReleaseYear = Int32.Parse(cb_Release_Year.Text);
            Book.CopiesNum = Int32.Parse(cb_CopiesNum.Text);
        }
    }
}
