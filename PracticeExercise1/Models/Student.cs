namespace Exercise;

public class Student
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? NickName { get; set; }
    public bool Married { get; set; }
    public int Age { get; set; }
    public int ID { get; set; }



    public string GetNickName()
    {
        string nickName;

        if (NickName is null)
        {
            throw new ArgumentNullException();
        }
        else
        {
            nickName = NickName;
        }
        
    return nickName;
    }



    public string FullName => $"{Name} {LastName}";

}
