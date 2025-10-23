using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

public static class FileHandler
{
    private static int shiftAmount = 3;

    /// <summary>
    /// Encrypts the string line to save to database.
    /// </summary>
    /// <param name="input">Line that will be encrypted to database.</param>
    /// <returns>string</returns>
    private static string Encrypt(string input)
    {
        StringBuilder encrypted = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char shifted = (char)(c + shiftAmount);
                if (char.IsUpper(c))
                {
                    if (shifted > 'Z')
                        shifted = (char)(shifted - 26);
                    else if (shifted < 'A')
                        shifted = (char)(shifted + 26);
                }
                else if (char.IsLower(c))
                {
                    if (shifted > 'z')
                        shifted = (char)(shifted - 26);
                    else if (shifted < 'a')
                        shifted = (char)(shifted + 26);
                }
                encrypted.Append(shifted);
            }
            else
            {
                encrypted.Append(c);
            }
        }

        return encrypted.ToString();
    }

    /// <summary>
    /// Decrypts the line string from the database.
    /// </summary>
    /// <param name="input">A line that will be decrypted from database.</param>
    /// <returns>string</returns>
    private static string Decrypt(string input)
    {
        StringBuilder decrypted = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char shifted = (char)(c - shiftAmount);
                if (char.IsUpper(c))
                {
                    if (shifted < 'A')
                        shifted = (char)(shifted + 26);
                    else if (shifted > 'Z')
                        shifted = (char)(shifted - 26);
                }
                else if (char.IsLower(c))
                {
                    if (shifted < 'a')
                        shifted = (char)(shifted + 26);
                    else if (shifted > 'z')
                        shifted = (char)(shifted - 26);
                }
                decrypted.Append(shifted);
            }
            else
            {
                decrypted.Append(c);
            }
        }

        return decrypted.ToString();
    }
    /// <summary>
    /// Reads everything from desired file.
    /// </summary>
    /// <param name="path"></param>
    /// <returns>List<string></returns>
    public static List<string> Read(string path)
    {
        List<string> result = new List<string>();
        string line = "";

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    result.Add(Decrypt(line));
                }
            }
        }
        catch (FileNotFoundException fnfEx)
        {
            MessageBox.Show($"File doesn't exist: {fnfEx.Message}");
            throw;
        }
        catch (IOException ioEx)
        {
            MessageBox.Show($"Failed to read/write to file: {ioEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unknown error occurred: {ex.Message}");
            throw;
        }

        return result;
    }

    /// <summary>
    /// Reads everything from database.
    /// </summary>
    /// <returns>void</returns>
    public static void ReadAll()
    {
        List<string> books_string = FileHandler.Read(CONFIG.BOOKS_TXT_FILE);
        foreach (string b in books_string)
        {
            Book book = Utility.StringToBook(b, '|');
            Base.Books.Add(book);
        }

        List<string> students_string = FileHandler.Read(CONFIG.STUDENT_TXT_FILE);

        foreach (string s in students_string)
        {
            Student student = Utility.StringToStudent(s, '|');
            Base.Students.Add(student);
        }

        List<string> borrows_string = FileHandler.Read(CONFIG.BORROWS_TXT_FILE);
        foreach (string brw in borrows_string)
        {
            Borrow borrow = Utility.StringToBorrow(brw, '|');
            Base.Borrows.Add(borrow);
        }
    }

    /// <summary>
    /// Encrypts and writes a text to a file.
    /// </summary>
    /// <param name="text">A line that will be saved to database</param>
    /// <param name="path"></param>
    /// <param name="append"></param>
    public static void Write(string text, string path, bool append = true)
    {
        try
        {
            string encryptedText = Encrypt(text); // Encrypt the text before writing
            using (StreamWriter sw = new StreamWriter(path, append))
            {
                sw.WriteLine(encryptedText);
            }
        }
        catch (UnauthorizedAccessException uaEx)
        {
            Console.WriteLine($"Unauthorized access: {uaEx.Message}");
            throw;
        }
        catch (IOException ioEx)
        {
            Console.WriteLine($"Failed to read/write to file: {ioEx.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unknown error occurred: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Clears everything from desired file.
    /// </summary>
    /// <param name="path"></param>
    /// <returns>void</returns>
    public static void Clear(string path)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
            }
        }
        catch (UnauthorizedAccessException uaEx)
        {
            MessageBox.Show($"Unauthorized access: {uaEx.Message}");
            throw; 
        }
        catch (IOException ioEx)
        {
            MessageBox.Show($"Failed to read/write to file: {ioEx.Message}");
            throw; 
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An unknown error occured: {ex.Message}");
            throw; 
        }
    }

    /// <summary>
    /// Saves everything to the database.
    /// </summary>
    /// <returns>void</returns>
    public static void Save_DB()
    {
        FileHandler.Clear(CONFIG.STUDENT_TXT_FILE);
        FileHandler.Clear(CONFIG.BOOKS_TXT_FILE);
        FileHandler.Clear(CONFIG.BORROWS_TXT_FILE);

        if (!Base.ResetDB)
        {
            foreach (Student s in Base.Students)
            {
                FileHandler.Write(s.StudentID + "|" + s.Name + "|" + s.Surname + "|" + s.Class, CONFIG.STUDENT_TXT_FILE, true);
            }
            foreach (Book book in Base.Books)
            {
                FileHandler.Write(book.BookID + "|" + book.Title + "|" + book.Author + "|" + book.ReleaseYear + "|" + book.CopiesNum, CONFIG.BOOKS_TXT_FILE, true);
            }
            foreach (Borrow posudba in Base.Borrows)
            {
                FileHandler.Write(posudba.BorrowID + "|" + posudba.StudentBorrow.StudentID + "|" + posudba.BookBorrowed.BookID + "|" + posudba.DateBorrowed + "|" + posudba.DateReturn, CONFIG.BORROWS_TXT_FILE, true);
            }
        }
    }

    /// <summary>
    /// Checks if files exists and creates them automatically if not.
    /// </summary>
    /// <returns>void</returns>
    public static void Check_Files_Create_Files()
    {
        if (!File.Exists(CONFIG.STUDENT_TXT_FILE))
        {
            var myFile = File.Create(CONFIG.STUDENT_TXT_FILE);
            myFile.Close();
        }

        if (!File.Exists(CONFIG.BOOKS_TXT_FILE))
        {
            var myFile = File.Create(CONFIG.BOOKS_TXT_FILE);
            myFile.Close();
        }

        if (!File.Exists(CONFIG.BORROWS_TXT_FILE))
        {
            var myFile = File.Create(CONFIG.BORROWS_TXT_FILE);
            myFile.Close();
        }
    }
}