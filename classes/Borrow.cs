using System;
using System.Runtime.Serialization;

public static class BorrowFactory
{
    public static Borrow Create(string param_borrowId, Student param_Student_Borrow, Book param_Book_Borrowed, DateTime param_Date_Borrowed, DateTime param_Date_Return)
    {
        return new Borrow(param_borrowId, param_Student_Borrow, param_Book_Borrowed, param_Date_Borrowed, param_Date_Return);
    }
}
public sealed class Borrow
{
    public string BorrowID;
    public Student StudentBorrow { get; set; }
    public Book BookBorrowed { get; set; }

    public DateTime DateBorrowed { get; set; }
    public DateTime DateReturn { get; set; }

    public int DaysLeft;

    private static readonly ObjectIDGenerator idGenerator = new ObjectIDGenerator();

    public Borrow() 
    {
        this.BorrowID = GenerateUniqueId();

        this.DateBorrowed = DateTime.Today;
        this.DateReturn = DateTime.Now.AddDays(CONFIG.BORROW_DURATION);
        this.DaysLeft = (DateReturn - DateTime.Today).Days >= 0 ? (DateReturn - DateTime.Today).Days : 0;

    }

    public Borrow(string param_borrowId, Student param_Student_Borrow, Book param_Book_Borrowed, DateTime param_Date_Borrowed, DateTime param_Date_Return)
    {
        this.BorrowID = param_borrowId;
        this.StudentBorrow = param_Student_Borrow;
        this.BookBorrowed = param_Book_Borrowed;
        this.DateBorrowed = param_Date_Borrowed;
        this.DateReturn = param_Date_Return;
        this.DaysLeft = (DateReturn - DateTime.Today).Days >= 0 ? (DateReturn - DateTime.Today).Days : 0;
    }

    private string GenerateUniqueId()
    {
        var objId = idGenerator.GetId(this, out bool _);
        return objId.ToString();
    }

    public override string ToString()
    {
        return CONFIG_FORM.FORM_BORROW_INFORMATION(
            this.BorrowID, 
            this.StudentBorrow.Name, 
            this.StudentBorrow.Surname, 
            this.DateBorrowed, 
            this.DateReturn, 
            this.DaysLeft);
    }
}