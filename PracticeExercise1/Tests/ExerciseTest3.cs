namespace Exercise.Test3;

public class ExerciseTest3
{
    private readonly static Student student1 = new Student() { Name ="Ana", LastName = "Martinez" };
    private readonly static Student student2 = student1;
    private readonly static Student student3 = new Student() { Name = "Juan", LastName = "Perez", Age = 25};
    private readonly static Student student4 = new Student() { Name = "Maria", LastName = "Pepita" };
    private readonly static List<Student> studentList = new() { student1, student2 };         
    private readonly static List<Student> studentList1 = studentList;
    private readonly static List<Student> studentList2 = new() { student1 };
    private readonly static List<Student> studentList3 = new() { student1, student3, student4 };

    [Fact]
    public void StudentListEqualStudentList1()
    {
        Assert.Equal(studentList, studentList1);
    }

    [Fact]
    public void StudentListNotEqualStudentList2()
    {
        Assert.NotEqual(studentList, studentList2);
    }

    [Fact]
    public void StudentListHasTwoElements()
    {
        Assert.Equal(2, studentList.Count);
    }

    [Fact]
    public void StudentList3HasUniqueElements()
    {
        Assert.Equal(studentList3.Count, studentList3.Distinct().Count());
    }

    [Fact]
    public void StudentList3ContainsJuanPerez()
    {
        Assert.Contains(studentList3, student => student.FullName == "Juan Perez");
    }

    [Fact]
    public void StudentList3Contains25YearsOld()
    {
        Assert.Contains(studentList3, student => student.Age == 25);
    }

}
