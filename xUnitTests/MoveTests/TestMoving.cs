using Moq;
using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.Actions;
using Proglib_Patterns_Course.Models;

namespace xUnitTests.MoveTests;

public class TestMoving
{
    [Fact]
    public void ValidMoveTests()
    {
        // Arrange
        var mockMoveable = new Mock<IMoveable>();
        mockMoveable.SetupGet(m => m.Position).Returns(new Vector(12, 5));
        mockMoveable.SetupGet(m => m.Velocity).Returns(new Vector(-7, 3));

        // Act
        var move = new Move(mockMoveable.Object);
        move.Execute();

        // Assert
        mockMoveable.VerifySet(m => m.Position = new Vector(5, 8), Times.Once);
    }

    [Fact]
    public void UnreadblePositionTest()
    {
        // Arrange
        var mockMoveable = new Mock<IMoveable>();
        mockMoveable.SetupGet(m => m.Position).Throws<Exception>();

        // Act
        var move = new Move(mockMoveable.Object);

        // Assert
        Assert.Throws<Exception>(() => move.Execute());
    }

    [Fact]
    public void UnreadbleVelocityTest()
    {
        // Arrange
        var mockMoveable = new Mock<IMoveable>();
        mockMoveable.SetupGet(m => m.Velocity).Throws<Exception>();

        // Act
        var move = new Move(mockMoveable.Object);

        // Assert
        Assert.Throws<Exception>(() => move.Execute());
    }

    [Fact]
    public void ErrorWhenChangePositionTest()
    {
        // Arrange
        var mockMoveable = new Mock<IMoveable>();
        mockMoveable.SetupGet(m => m.Position).Returns(new Vector(12, 5));
        mockMoveable.SetupGet(m => m.Velocity).Returns(new Vector(-7, 3));
        mockMoveable.SetupSet(m => m.Position = It.IsAny<Vector>()).Throws<Exception>();

        // Act
        var move = new Move(mockMoveable.Object);
        //move.Execute();

        // Assert
        Assert.Throws<Exception>(() => move.Execute());
    }
}
