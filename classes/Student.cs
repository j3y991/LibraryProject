public static class StudentFactory
{
    public static Student Create(string param_StudentId, string param_Name, string param_Surname, string param_Class)
    {
        return new Student(param_StudentId, param_Name, param_Surname, param_Class);
    }
}

public sealed class Student
{
    public string StudentID;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Class { get; set; }

    public Student() { }

    public Student(string param_StudentId, string param_Name, string param_Surname, string param_Class)
    {
        this.StudentID = param_StudentId;
        this.Name = param_Name;
        this.Surname = param_Surname;
        this.Class = param_Class;
    }

    public override string ToString()
    {
        return CONFIG_FORM.FORM_STUDENT_INFORMATION(
            this.Name, 
            this.Surname, 
            this.Class, 
            this.StudentID);
    }
}