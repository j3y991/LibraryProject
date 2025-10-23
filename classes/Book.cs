using System.Runtime.Serialization;

public static class BookFactory 
{
    public static Book Create(string bookId, string title, string author, int year, int copies)
    {
        return new Book(bookId, title, author, year, copies);
    }
}

public sealed class Book
{
    public string BookID;
    public string Title { get; set; }
    public string Author { get; set; }
    public int ReleaseYear { get; set; }
    public int CopiesNum { get; set; }

    private static readonly ObjectIDGenerator idGenerator = new ObjectIDGenerator();

    public Book() {
        this.BookID = GenerateUniqueId();
    }
    public Book(string param_bookId, string param_Title, string param_Author, int param_Release_Year, int param_Copies_Num)
    {
        this.BookID = param_bookId;
        this.Title = param_Title;
        this.Author = param_Author;
        this.ReleaseYear = param_Release_Year;
        this.CopiesNum = param_Copies_Num;
    }

    private string GenerateUniqueId()
    {
        var objId = idGenerator.GetId(this, out bool _);
        return objId.ToString();
    }

    public override string ToString()
    {
        return CONFIG_FORM.FORM_BOOK_INFORMATION(
            this.BookID, 
            this.Title, 
            this.Author, 
            this.ReleaseYear, 
            this.CopiesNum);
    }

}