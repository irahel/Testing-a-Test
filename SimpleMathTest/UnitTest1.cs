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
        int sum = SimpleMathClass.Add(10, 10);
        sum.Should().Be(20);                
    }
    
    [Theory(DisplayName = "Testing multiple subtractions")]
    [Trait("Category","Sub")]
    [InlineData(10,10,20)]
    [InlineData(15,15,30)]
    [InlineData(20,20,40)]
    public static void TestSubtract(int n1, int n2, int expected)
    {
        int sub = SimpleMathClass.Subtract(n1, n2);        
        sub.Should().Be(expected); 
    }
}