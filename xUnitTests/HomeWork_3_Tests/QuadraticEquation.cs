using Proglib_Patterns_Course.HomeWork_3;

namespace xUnitTests.HomeWork_3_Tests;

public class QuadraticEquation
{
    [Theory]
    [InlineData(1, 0, 1)]  // 3. x^2 + 1 =0
    public void WhenCorrectData_ReturnEmptyArray(double a, double b, double c)
    {
        // Act
        var result = Equation.Solve(a, b, c);

        // Assert
        Assert.Equal(0, result.Length);
    }

    [Theory]
    [InlineData(1, 0, -1)]  // 5. x^2 - 1 =0
    public void WhenCorrectData_ReturnTwoRoots(double a, double b, double c)
    {
        // Act
        var result = Equation.Solve(a, b, c);

        // Assert
        Assert.Equal(result, new[] { -1.0, 1.0 });
    }

    [Theory]
    [InlineData(1, 2, 1)] // 7. x^2+2x+1 = 0
    public void WhenCorrectData_ReturnTwoRoots2(double a, double b, double c)
    {
        // Arrange 
        var expectedAnswer1 = -1;
        var expectedAnswer2 = -1;
        var expectedResult = new double[] { expectedAnswer1, expectedAnswer2 };

        // Act
        var result = Equation.Solve(a, b, c);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(0.0)]   // 9. a != 0
    [InlineData(1e-12)]
    [InlineData(-1e-12)]
    public void WhenZeroParameterA_ReturnException(double a)
    {
        // Arrange 
        double b = 2;
        double c = 1;

        // Act + Assert
        var ex = Assert.Throws<ArgumentException>(() => Equation.Solve(a, b, c));
        Assert.Equal("a", ex.ParamName);
    }

    [Fact] // 11 D!=0 and D < eps
    public void WhenDiscriminantIsNearZero_ReturnsDoubleRoot()
    {
        var a = 1.0;
        var b = 2.0;
        var c = 1.0 - 2.5e-13;

        var result = Equation.Solve(a, b, c);

        Assert.Equal(result, new[] { -1.0, -1.0 });
    }

    [Theory]
    [InlineData(1, 4, 3)]
    public void WhenCorrectData_ReturnCorrectAnswer(double a, double b, double c)
    {
        // Arrange 
        var expectedAnswer1 = -3;
        var expectedAnswer2 = -1;
        var expectedResult = new double[] { expectedAnswer1, expectedAnswer2 };

        // Act
        var result = Equation.Solve(a, b, c);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> NotFiniteCoefficients()
    {
        var notFiniteCoef = new double[] { double.NaN, double.PositiveInfinity, double.NegativeInfinity };

        foreach (var x in notFiniteCoef)
        {
            yield return new object[] { x, 1, 1 };
            yield return new object[] { 1, x, 1 };
            yield return new object[] { 1, 1, x };
        }
    }

    [Theory]
    [MemberData(nameof(NotFiniteCoefficients))]
    public void WhenCoefficinetIsNotFinite_ReturnArgumentException(double a, double b, double c)
    {
        // Act + Assert
        Assert.Throws<ArgumentException>(() => Equation.Solve(a, b, c));
    }
}
