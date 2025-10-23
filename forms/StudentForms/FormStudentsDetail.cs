using System;
using System.Linq;
using System.Windows.Forms;

namespace Library.Forms.StudentDetails
{
    public partial class FormStudentsDetail : Form
    {
        public Student Student { get; set; } = new Student();

        public FormStudentsDetail()
        {
            InitializeComponent();
        }

        private void FormStudentsDetail_Load(object sender, EventArgs e)
        {
            TranslateUI();
            LoadClassOptions();

            if (!string.IsNullOrEmpty(Student.Name))
            {
                tb_ID.Text = Student.StudentID;
                tb_Name.Text = Student.Name;
                tb_Surname.Text = Student.Surname;
                cb_Class.Text = Student.Class;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!IsValidId())
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_INVALID_INPUT_ID);
                return;
            }

            if (!IsValidName(tb_Name.Text))
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_STUDENT_DETAIL_INVALID_INPUT_NAME);
                return;
            }

            if (!IsValidName(tb_Surname.Text))
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_STUDENT_DETAIL_INVALID_INPUT_SURNAME);
                return;
            }

            if (!IsValidClass())
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_STUDENT_DETAIL_INVALID_INPUT_CLASS);
                return;
            }

            Student.StudentID = tb_ID.Text.Trim();
            Student.Name = tb_Name.Text.Trim();
            Student.Surname = tb_Surname.Text.Trim();
            Student.Class = cb_Class.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void TranslateUI()
        {
            label_ID.Text = CONFIG_FORM.FORM_STUDENT_DETAILS_ID;
            label_Name.Text = CONFIG_FORM.FORM_STUDENT_DETAILS_NAME;
            label_Surname.Text = CONFIG_FORM.FORM_STUDENT_DETAILS_SURNAME;
            label_Class.Text = CONFIG_FORM.FORM_STUDENT_DETAILS_CLASS;
            btn_Ok.Text = CONFIG_FORM.FORM_STUDENT_DETAILS_BTN_OK;
            btn_Cancel.Text = CONFIG_FORM.FORM_STUDENT_DETAILS_BTN_CANCEL;
        }

        private void LoadClassOptions()
        {
            for (int i = CONFIG.FORM_STUDENT_DETAILS_CLASS_MIN; i <= CONFIG.FORM_STUDENT_DETAILS_CLASS_MAX; i++)
            {
                cb_Class.Items.Add(i);
            }
        }

        private bool IsValidId()
        {
            if (string.IsNullOrWhiteSpace(tb_ID.Text)) return false;
            return int.TryParse(tb_ID.Text, out _);
        }

        private bool IsValidName(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return !input.Any(char.IsDigit);
        }

        private bool IsValidClass()
        {
            if (!int.TryParse(cb_Class.Text, out int value)) return false;
            return value >= CONFIG.FORM_STUDENT_DETAILS_CLASS_MIN && value <= CONFIG.FORM_STUDENT_DETAILS_CLASS_MAX;
        }
    }
}
