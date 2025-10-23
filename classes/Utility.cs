using System;
using System.Linq;
using System.Windows.Forms;

public static class Utility
{
    /// <summary>
    /// Prevents library to take any input because an error has occured.
    /// </summary>
    /// <param name="msg"></param>
    public static void Alert_Error_Stop_App(string msg)
    {
        if (!Base.EncounteredError)
        {
            MessageBox.Show(msg);
            Base.EncounteredError = true;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "Library")
                {
                    form.Close();
                }
            }
        }

    }

    /// <summary>
    /// Converts string containing database information to student class.
    /// </summary>
    /// <param name="input">Line from database</param>
    /// <param name="delimiter">Symbol that seperates data</param>
    /// <returns></returns>
    public static Student StringToStudent(string input, char delimiter)
    {
        if (string.IsNullOrEmpty(input))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        string[] splitString = input.Split(delimiter);

        if (splitString.Length != 4 || splitString.Any(s => string.IsNullOrEmpty(s)))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        string StudentID = splitString[0];
        string StudentName = splitString[1];
        string StudentSurname = splitString[2];
        string StudentClass = splitString[3];

        Student result = StudentFactory.Create(StudentID, StudentName, StudentSurname, StudentClass);
        return result;
    }

    /// <summary>
    /// Converts string containing databse information to book class.
    /// </summary>
    /// <param name="input">Line from database</param>
    /// <param name="delimiter">Symbol that seperates data</param>
    /// <returns></returns>
    public static Book StringToBook(string input, char delimiter)
    {
        if (string.IsNullOrEmpty(input))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        string[] splitString = input.Split(delimiter);

        if (splitString.Length != 5 || splitString.Any(s => string.IsNullOrEmpty(s)))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        string bookId = splitString[0];
        string Name = splitString[1];
        string Author = splitString[2];
        int ReleaseYear, CopiesNum;

        if (!int.TryParse(splitString[3], out ReleaseYear))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        if (!int.TryParse(splitString[4], out CopiesNum))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        Book result = BookFactory.Create(bookId, Name, Author, ReleaseYear, CopiesNum);
        return result;
    }

    /// <summary>
    /// Converts string containing databse information to borrow class.
    /// </summary>
    /// <param name="input">Line from database</param>
    /// <param name="delimiter">Symbol that seperates data</param>
    /// <returns></returns>
    public static Borrow StringToBorrow(string input, char delimiter)
    {
        if (string.IsNullOrEmpty(input))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        string[] splitString = input.Split(delimiter);

        if (splitString.Length != 5 || splitString.Any(s => string.IsNullOrEmpty(s)))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        string BorrowID = splitString[0];
        string StudentID = splitString[1];
        string BookID = splitString[2];
        DateTime DateBorrowed, DateReturn;

        if (!DateTime.TryParse(splitString[3], out DateBorrowed))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        if (!DateTime.TryParse(splitString[4], out DateReturn))
        {
            Alert_Error_Stop_App(CONFIG_NOTIFIERS.NOTIFIER_DATABASE_ERROR_OCCURED);
        }

        Student FoundStudent = null;
        foreach (Student s in Base.Students)
        {
            if (s.StudentID == StudentID)
            {
                FoundStudent = s;
                break;
            }
        }

        Book FoundBook = null;
        foreach (Book b in Base.Books)
        {
            if (b.BookID == BookID)
            {
                FoundBook = b;
                break;
            }
        }

        Borrow result = BorrowFactory.Create(BorrowID, FoundStudent, FoundBook, DateBorrowed, DateReturn);
        return result;
    }
}