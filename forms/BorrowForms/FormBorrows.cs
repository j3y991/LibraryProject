using System;
using System.Windows.Forms;
using Library.Forms.BorrowDetails;

namespace Library.Forms.Borrows
{
    public partial class FormBorrows : Form
    {
        public FormBorrows()
        {
            InitializeComponent();
        }

        private void FormBorrows_Load(object sender, EventArgs e)
        {
            TranslateUIElements();
            RefreshBorrowList();
        }

        private void TranslateUIElements()
        {
            form_title.Text = CONFIG_FORM.FORM_BORROW_TITLE;
            btn_Add.Text = CONFIG_FORM.FORM_BORROW_ADD;
            btn_Edit.Text = CONFIG_FORM.FORM_BORROW_EDIT;
            btn_Remove.Text = CONFIG_FORM.FORM_BORROW_REMOVE;
        }

        private void RefreshBorrowList()
        {
            lb_Borrows.Items.Clear();
            foreach (var borrow in Base.Borrows)
            {
                lb_Borrows.Items.Add(borrow);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Base.Books.Count == 0)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_NOT_ENOUGH_BOOKS);
                return;
            }

            if (Base.Students.Count == 0)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_NOT_ENOUGH_STUDENTS);
                return;
            }

            var borrowForm = new BorrowDetails.BorrowDetails();
            var result = borrowForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Base.Borrows.Add(borrowForm.Borrow);
                RefreshBorrowList();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lb_Borrows.SelectedItem == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_BORROW);
                return;
            }

            var borrowForm = new BorrowDetails.BorrowDetails
            {
                Borrow = lb_Borrows.SelectedItem as Borrow
            };

            var result = borrowForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                UpdateBorrow(lb_Borrows.SelectedItem as Borrow, borrowForm.Borrow);
                RefreshBorrowList();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lb_Borrows.SelectedItem == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_BORROW);
                return;
            }

            Base.Borrows.Remove(lb_Borrows.SelectedItem as Borrow);
            RefreshBorrowList();
        }

        private void UpdateBorrow(Borrow original, Borrow updated)
        {
            original.StudentBorrow = updated.StudentBorrow;
            original.BookBorrowed = updated.BookBorrowed;
        }
    }
}
