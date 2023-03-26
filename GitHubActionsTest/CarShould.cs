using FluentAssertions;

namespace GitHubActionsTest;

public class CarShould
{
    [Fact]
    public void BeBlackByDefault()
    {
        Car car = new Car();
        car.Color.Should().Be("Black");
    }

    [Fact]
    public void BeFail()
    {
        Car car = new Car();
        car.Color.Should().Be("azUGHJKAjhkjSN");
    }
}