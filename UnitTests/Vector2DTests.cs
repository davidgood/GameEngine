using FluentAssertions;
using GameEngine.GameEngine;

namespace UnitTests;

public class Vector2DTests {
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(10, 5)]
    [InlineData(5, 10)]
    [InlineData(-5, 10)]
    [InlineData(-5, -3)]
    public void Vector2D_Operator_Plus_Should_Return_New_Vector2D_And_Succeed(int x, int y) {
        // Arrange
        var vec1 = new Vector2D(x, y);
        var vec2 = new Vector2D(y, x);

        // Act
        var vec3 = vec1 + vec2;

        // Assert        
        vec3.Should().NotBeNull();
        vec3.X.Should().Be(x + y);
        vec3.Y.Should().Be(y + x);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(10, 5)]
    [InlineData(5, 10)]
    [InlineData(-5, 10)]
    [InlineData(-5, -3)]
    public void Vector2D_Operator_Minus_Should_Return_New_Vector2D_And_Succeed(int x, int y) {
        // Arrange
        var vec1 = new Vector2D(x, y);
        var vec2 = new Vector2D(y, x);

        // Act
        var vec3 = vec1 - vec2;

        // Assert        
        vec3.Should().NotBeNull();
        vec3.X.Should().Be(x - y);
        vec3.Y.Should().Be(y - x);
    }

    [Theory]
    [InlineData(0, 0, 1)]
    [InlineData(5, 5, 2)]
    [InlineData(10, 5, 2)]
    [InlineData(5, 10, -2)]
    [InlineData(-5, 10, 3)]
    [InlineData(-5, -3, 0)]
    public void Vector2D_Operator_Multiply_Should_Return_New_Vector2D_And_Succeed(int x, int y, int z) {
        // Arrange
        var vec1 = new Vector2D(x, y);
        // Act
        var vec3 = vec1 * z;

        // Assert        
        vec3.Should().NotBeNull();
        vec3.X.Should().Be(x * z);
        vec3.Y.Should().Be(y * z);
    }
}