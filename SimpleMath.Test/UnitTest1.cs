using Xunit;
using FluentAssertions;
using SimpleMath;
using System;

namespace SimpleMathTest;

public class SimpleMathClassTest
{
    [Fact(DisplayName = "testing a single addition")]
    [Trait("Category","Sum")]
    public static void TestAdd()
    {
        int sum = SimpleMathClass.Add(10, 5);
        sum.Should().Be(15);
    }

    [Fact(DisplayName = "testing a single addition2")]
    [Trait("Category","Sum")]
    public static void TestAdd2()
    {
        int sum = SimpleMathClass.Add(5, 40);
        sum.Should().Be(45);
    }

    [Theory(DisplayName = "Testing multiple subtractions")]
    [Trait("Category","Sub")]
    [InlineData(10,10,0)]
    [InlineData(15,10,5)]
    [InlineData(20,10,10)]
    public static void TestSubtract(int n1, int n2, int expected)
    {
        int sub = SimpleMathClass.Subtract(n1, n2);
        sub.Should().Be(expected);
    }
}