using Student;
namespace Student.List.Test;

public class GroupMock
{
    public Student student1 = new();
    public Student student2 = new();
    public Student student3 = new();
    public Student student4 = new();
    internal List<Student> studentList = new();
    internal List<Student> studentList1 = new();
    internal List<Student> studentList2 = new();
    internal List<Student> studentList3 = new();
    public GroupMock()
    {
        student1.Name = "Ana";
        student1.LastName = "Martinez";

        student2 = student1;

        student3.Name = "Juan";
        student3.LastName = "Perez";
        student3.Age = 25;

        student4.Name = "Maria";
        student4.LastName = "Pepita";

        studentList.Add(student1);
        studentList.Add(student2);

        studentList1 = studentList;

        studentList2.Add(student1);

        studentList3.Add(student1);
        studentList3.Add(student3);
        studentList3.Add(student4);
    }
}

public class StudentListTest
{
    GroupMock group = new();
    [Fact]
    public void StudentListShouldBeEqualToStudentList1()
    {
        Assert.Equal(group.studentList, group.studentList1);
    }
    [Fact]
    public void StudentListShouldNotBeEqualToStudentList2()
    {
        Assert.NotEqual(group.studentList, group.studentList2);
    }
    [Fact]
    public void StudentListShouldHaveOnlyTwoEqualElements()
    {
        bool allEqual = group.studentList.All(student => student == group.studentList[0]);
        Assert.Equal(2, group.studentList.Count);
        Assert.True(allEqual);
    }
    [Fact]
    public void StudentList3ShouldNotHaveRepeatedElements()
    {
        bool AreDistinct = group.studentList3.Distinct().Count() == group.studentList3.Count;
        Assert.True(AreDistinct);
    }
    [Fact]
    public void StudentList3ShouldHaveStudentJuanPerez()
    {
        bool IsJuanPerez = group.studentList3.Any(student => student.FullName == "Juan Perez");
        Assert.True(IsJuanPerez);
    }
    [Fact]
    public void StudentList3ShouldHaveAStudentWith25Years()
    {
        bool Is25Years = group.studentList3.Any(student => student.Age == 25);
        Assert.True(Is25Years);
    }
}
