using AdventOfCode2023.Helpers;

namespace AdventOfCode2023.Test.Day5;

public class Tests
{
    AdventOfCode2023.Day5.Day5 _day5;

    [SetUp]
    public void SetUp()
    {
        var input = Constants.BasePath + "day5_example.txt";
        _day5 = new AdventOfCode2023.Day5.Day5(input);
    }

    #region Part1

    [Test]
    public void ShouldAddSeedNumbersToList()
    {
        _day5.SeedIds = new ();
        _day5.AddSeedIds(" 1 5 12");
        Assert.That(_day5.SeedIds[0], Is.EqualTo(1));
        Assert.That(_day5.SeedIds[1], Is.EqualTo(5));
        Assert.That(_day5.SeedIds[2], Is.EqualTo(12));
    }

    [Test]
    public void ShouldGetLowestLocation()
    {

    }

    [Test]
    public void ShouldDoPart1ForPuzzleInput()
    {
        var input = Constants.BasePath + "day5_actual.txt";
        _day5 = new AdventOfCode2023.Day5.Day5(input);


    }

    #endregion

    #region Part2

    [Test]
    public void ShouldDoPart2()
    {

    }

    [Test]
    public void ShouldDoPart2ForPuzzleInput()
    {
        var input = Constants.BasePath + "day5_actual.txt";
        _day5 = new AdventOfCode2023.Day5.Day5(input);


    }

    #endregion
}