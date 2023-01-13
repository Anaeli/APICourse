namespace Exercise.Test2;

public class ExerciseTest2
{
    [Theory]
    [InlineData(42, true)]
    [InlineData(41, false)]
    [InlineData(43, true)]
    public void NumGreaterOrEqualTo42(int num, bool expected)
    {
        Assert.Equal(expected, num >= 42);
    }

    [Theory]
    [InlineData(42, true)]
    [InlineData(50, false)]
    [InlineData(49, true)]
    public void NumLessThan50(int num, bool expected)
    {
        Assert.Equal(expected, num < 50);
    }

    [Theory]
    [InlineData(40, true)]
    [InlineData(50, true)]
    [InlineData(39, false)]
    [InlineData(51, false)]
    public void NumBetween40And50(int num, bool expected)
    {
        Assert.Equal(expected, num >= 40 && num <= 50);
    }

    [Theory]
    [InlineData(2020, 2, 20, 2020, 2, 25, true)]
    [InlineData(2020, 2, 20, 2020, 2, 20, false)]
    [InlineData(2021, 2, 20, 2020, 2, 25, true)]
    public void D1NotEqualD2(int year1, int month1, int day1, int year2, int month2, int day2, bool expected)
    {
        DateTime d1 = new DateTime(year1, month1, day1);
        DateTime d2 = new DateTime(year2, month2, day2);

        Assert.Equal(expected, d1 != d2);
    }

    [Theory]
    [InlineData(2020, 2, 20, 2020, 2, 25, true)]
    [InlineData(2020, 2, 20, 2020, 2, 28, true)]
    [InlineData(2021, 2, 20, 2020, 2, 25, false)]
    public void D1EqualD2With8DaysRange(int year1, int month1, int day1, int year2, int month2, int day2, bool expected)
    {
        DateTime d1 = new DateTime(year1, month1, day1);
        DateTime d2 = new DateTime(year2, month2, day2);
        var tolerance = TimeSpan.FromDays(8);

        Assert.Equal(expected, (d2 - d1).Duration() <= tolerance);
    }

}
