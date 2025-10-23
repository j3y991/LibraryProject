using System.Collections.Generic;

public static class Base
{
    public static bool EncounteredError = false;
    public static bool ResetDB = false;

    public static List<Student> Students;

    public static List<Book> Books;

    public static List<Borrow> Borrows;
    public static void Initialize()
    {
        Students = new List<Student>();
        Books = new List<Book>();
        Borrows = new List<Borrow>();

        FileHandler.Check_Files_Create_Files();
        FileHandler.ReadAll();

    }
}