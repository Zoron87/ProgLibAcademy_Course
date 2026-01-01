using Moq;
using Proglib_Patterns_HomeWork.Abstractions;
using Proglib_Patterns_HomeWork.Actions;

namespace xUnitTests.RotateTests;

public class TestRotate
{
    [Fact]
    public void RotateMoveTests()
    {
        // Arrange
        var rotateable = new Mock<IRotatable>();
        rotateable.Setup(m => m.Direction).Returns(45);
        rotateable.Setup(m => m.AngularVelocity).Returns(90);

        // Act
        var rotate = new Rotate(rotateable.Object);
        rotate.Execute();

        // Asset
        rotateable.VerifySet(m => m.Direction = 135, Times.Once());
    }
}
