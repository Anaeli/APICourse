namespace MyProjectTests;

using Xunit;
using System.Collections.Generic;
using System.Linq;
using Student;

public class StudentListTest
{
Student student1 = new Student(){Name = "Ana", LastName = "Martinez"};
Student student2 = new Student();
Student student3 = new Student(){Name = "Juan", LastName = "Perez", Age = 25};
Student student4 = new Student(){Name = "Maria", LastName = "Pepita"};

List<Student> studentList = new List<Student>();
List<Student> studentList1 = new List<Student>();
List<Student> studentList2 = new List<Student>();
List<Student> studentList3 = new List<Student>();

void CreateLists()
{
    student2 = student1;
    studentList.Add(student1);
    studentList.Add(student2);
    studentList1 = studentList;
    studentList2.Add(student1);
    studentList3.Add(student1);
    studentList3.Add(student3);
    studentList3.Add(student4);
}

[Fact]
public void FirstListAndSecondListShouldBeEquals()
{
    CreateLists();
    Assert.Equal(studentList, studentList1);
}

[Fact]
public void List1andList2ShouldNotBeEquals()
{
    CreateLists();
    Assert.NotEqual(studentList1, studentList2);
}

[Fact]
public void FirstListShouldHaveTwoElements()
{
    CreateLists();
    Assert.Equal(2, studentList.Count());
}

[Fact]
public void ItShouldHaveUniqueElements()
{
    CreateLists();
    Assert.Equal(3, studentList3.Distinct().Count());
}

[Fact]
public void ItShouldContainJuanPerez()
{
    CreateLists();
    Assert.Contains(studentList3, s => s.Name == "Juan" && s.LastName == "Perez");
}

[Fact]
public void ItShouldContainAStudentWithAge25()
{
    CreateLists();
    Assert.Contains(studentList3, s => s.Age == 25);
}

}
