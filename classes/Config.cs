using System;

public static class CONFIG
{
    public static string STUDENT_TXT_FILE = "Students.txt";
    public static string BOOKS_TXT_FILE = "Books.txt";
    public static string BORROWS_TXT_FILE = "Borrows.txt";


    public static int BORROW_DURATION = 7; // in days.

    public static int FORM_BOOK_DETAILS_RELEASE_YEAR_MIN = 1950;
    public static int FORM_BOOK_DETAILS_RELEASE_YEAR_MAX = 2025;

    public static int FORM_STUDENT_DETAILS_CLASS_MIN = 1;
    public static int FORM_STUDENT_DETAILS_CLASS_MAX = 4;

}

public static class CONFIG_FORM // strings that will be used in forms display.
{
    public static string FORM_LIBRARY_TITLE = "Library";
    public static string FORM_LIBRARY_BOOKS_BTN = "Books";
    public static string FORM_LIBRARY_BORROWS_BTN = "Borrows";
    public static string FORM_LIBRARY_STUDENTS_BTN = "Students";
    public static string FORM_LIBRARY_RESET_DB_BTN = "Reset database";

    public static string FORM_BOOK_INFORMATION(string param_Book_ID, string param_Title, string param_Author, int param_Release_Year, int param_Copies_Num)
    {
        return $"Book ID: {param_Book_ID}, Title: {param_Title}, Author: {param_Author}, Release year: {param_Release_Year}, Number of copies: {param_Copies_Num}";
    }
    public static string FORM_BOOK_TITLE = "Books";
    public static string FORM_BOOK_ADD = "Add book";
    public static string FORM_BOOK_REMOVE = "Remove book";
    public static string FORM_BOOK_EDIT = "Edit book";

    public static string FORM_BOOK_DETAILS_ID = "Book ID:";
    public static string FORM_BOOK_DETAILS_AUTHOR = "Author:";
    public static string FORM_BOOK_DETAILS_TITLE = "Title:";
    public static string FORM_BOOK_DETAILS_RELEASE_YEAR = "Date of release:";
    public static string FORM_BOOK_DETAILS_COPIES_NUM = "Number of copies:";
    public static string FORM_BOOK_DETAILS_OK_BTN = "OK";
    public static string FORM_BOOK_DETAILS_CANCEL_BTN = "Cancel";


    public static string FORM_BORROW_INFORMATION(string param_Borrow_ID, string param_Student_Name, string param_Student_Last_Name, DateTime param_Date_Borrowed, DateTime param_Date_Return, int param_Days_Left)
    {
        return $"Borrow ID: {param_Borrow_ID}, Student NAME: {param_Student_Name}, Student LASTNAME: {param_Student_Last_Name}, Borrow DATE: {param_Date_Borrowed:dd.MM.yyyy}, Borrow DUE TO: {param_Date_Return:dd.MM.yyyy}, Days left: {param_Days_Left}";
    }
    public static string FORM_BORROW_TITLE = "Borrows";
    public static string FORM_BORROW_ADD = "Add borrow";
    public static string FORM_BORROW_REMOVE = "Remove borrow";
    public static string FORM_BORROW_EDIT = "Edit borrow";

    public static string FORM_BORROW_DETAILS_ID = "Borrow ID:";
    public static string FORM_BORROW_DETAILS_ID_AUTOMATICALLY_GENERATED = "Automatically generated";
    public static string FORM_BORROW_DETAILS_STUDENT = "Student:";
    public static string FORM_BORROW_DETAILS_BOOK = "Book:";
    public static string FORM_BORROW_DETAILS_OK_BTN = "OK";
    public static string FORM_BORROW_DETAILS_CANCEL_BTN = "Cancel";
    public static string FORM_STUDENT_INFORMATION(string param_Student_Name, string param_Student_Surname, string param_Class, string param_Student_ID)
    {
        return $"NAME: {param_Student_Name}, SURNAME: {param_Student_Surname}: CLASS: {param_Class}: Student ID: {param_Student_ID}";
    }
    public static string FORM_STUDENT_TITLE = "Students";
    public static string FORM_STUDENT_ADD = "Add student";
    public static string FORM_STUDENT_REMOVE = "Remove student";
    public static string FORM_STUDENT_EDIT = "Edit student";

    public static string FORM_STUDENT_DETAILS_ID = "ID:";
    public static string FORM_STUDENT_DETAILS_NAME = "Name:";
    public static string FORM_STUDENT_DETAILS_SURNAME = "Surname:";
    public static string FORM_STUDENT_DETAILS_CLASS = "Class:";
    public static string FORM_STUDENT_DETAILS_BTN_OK = "OK";
    public static string FORM_STUDENT_DETAILS_BTN_CANCEL = "Cancel";



}
public static class CONFIG_NOTIFIERS // strings that will be used in message boxes when there's errors or warnings.
{
    public static string NOTIFIER_INVALID_INPUT_ID = "Invalid input of ID.";
    public static string NOTIFIER_DATABASE_ERROR_OCCURED = "Database is corrupted. Please fix the database pressing the button on library home.";
    public static string NOTIFIER_BOOK_ALREADY_EXISTS = "Book with this ID already exists!";
    public static string NOTIFIER_SELECT_A_BOOK = "Please select a desired book.";
    public static string NOTIFIER_SELECT_A_STUDENT = "Please select a desired student.";
    public static string NOTIFIER_SELECT_A_BORROW = "Please select a desired borrow.";
    public static string NOTIFIER_INVALID_INPUT_RELEASE_YEAR_COPIES_NUM = "Invalid input of release year / copies number.";
    public static string NOTIFIER_NOT_ENOUGH_COPIES = "Book doesn't have enough copies!";
    public static string NOTIFIER_NOT_ENOUGH_STUDENTS = "You must add atleast 1 student to create a borrow!";
    public static string NOTIFIER_NOT_ENOUGH_BOOKS = "You must add atleast 1 book to create a borrow!";
    public static string NOTIFIER_STUDENT_WITH_DESIRED_ID_NOT_EXIST = "Book with desired ID doesn't exist!";
    public static string NOTIFIER_STUDENT_DETAIL_INVALID_INPUT_NAME = "Invalid input of student name!";
    public static string NOTIFIER_STUDENT_DETAIL_INVALID_INPUT_SURNAME = "Invalid input of student surname!";
    public static string NOTIFIER_STUDENT_DETAIL_INVALID_INPUT_CLASS = "Invalid input of student class!";
    public static string NOTIFIER_RESET_DB_TITLE = "Database reset";
    public static string NOTIFIER_RESET_DB_DESCRIPTION = "Are you sure you want to reset database? WARNING: This will delete all data.";



}


