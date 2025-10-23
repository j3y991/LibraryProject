using Library.Forms.StudentDetails;
using System;
using System.Windows.Forms;

namespace Library.Forms.Students
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            TranslateUIElements();
            RefreshStudentList();
        }

        private void RefreshStudentList()
        {
            lb_Students.Items.Clear();
            foreach (var student in Base.Students)
            {
                lb_Students.Items.Add(student);
            }
        }

        private void TranslateUIElements()
        {
            btn_Add.Text = CONFIG_FORM.FORM_STUDENT_ADD;
            btn_Edit.Text = CONFIG_FORM.FORM_STUDENT_EDIT;
            btn_Remove.Text = CONFIG_FORM.FORM_STUDENT_REMOVE;
            form_title.Text = CONFIG_FORM.FORM_STUDENT_TITLE;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var studentForm = new FormStudentsDetail();
            var result = studentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (var student in Base.Students)
                {
                    if (student.StudentID == studentForm.Student.StudentID)
                    {
                        MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_STUDENT_WITH_DESIRED_ID_NOT_EXIST);
                        return;
                    }
                }

                Base.Students.Add(studentForm.Student);
                RefreshStudentList();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lb_Students.SelectedItem == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_STUDENT);
                return;
            }

            var studentForm = new FormStudentsDetail
            {
                Student = lb_Students.SelectedItem as Student
            };

            var result = studentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (var student in Base.Students)
                {
                    if (student.StudentID != studentForm.Student.StudentID) continue;

                    var updated = studentForm.Student;
                    student.Name = updated.Name;
                    student.Surname = updated.Surname;
                    student.Class = updated.Class;
                    RefreshStudentList();
                    break;
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lb_Students.SelectedItem == null)
            {
                MessageBox.Show(CONFIG_NOTIFIERS.NOTIFIER_SELECT_A_STUDENT);
                return;
            }

            Base.Borrows.RemoveAll(b => b.StudentBorrow.StudentID == (lb_Students.SelectedItem as Student).StudentID);
            Base.Students.Remove(lb_Students.SelectedItem as Student);
            RefreshStudentList();
        }
    }
}
