using Xunit;
using SimpleMathTest;
using FluentAssertions;
using System;

namespace TestTheTest;

public class TestTheTest
{
    [Fact]
    public void TestTestAddSucess()
    {        
        Action act = () => SimpleMathClassTest.TestAdd();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
    }

    [Theory]
    [InlineData(555,161,394)]
    [InlineData(-985,100,-1085)]
    [InlineData(-33,-34,1)]
    public void TestTestSubtractSucess(int testNumber1, int testNumber2, int testEspective)
    {        
        Action act = () => SimpleMathClassTest.TestSubtract(testNumber1, testNumber2, testEspective);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
    }

    [Theory]
    [InlineData(100, 10, -90)]
    [InlineData(-985, 100, 1085)]
    [InlineData(-33, 34, 1085)]
    public void TestTestSubtractFail(int testNumber1, int testNumber2, int testEspective)
    {        
        Action act = () => SimpleMathClassTest.TestSubtract(testNumber1, testNumber2, testEspective);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}