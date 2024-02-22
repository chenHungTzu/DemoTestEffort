using System.Diagnostics.Metrics;
using DemoTestEffort.api;
using DemoTestEffort.api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace test;

public class UnitTest_Mess
{

    /// <summary>
    /// 邏輯驗證，是否除數為零
    /// </summary>
    [Fact]
    public void Test_Mess_Controller_When_Number_Negative()
    {

        // arrange
        var controller = new Demo_Mess_Controller();

        // act
        var actionResult = controller.DivisionToWrite(-1);
        var badrequest = actionResult as BadRequestObjectResult;
        var expect = "Number cannot be negative";
        var actual = badrequest.Value as string;

        // assert
        expect.Should().Be(actual);

    }

    /// <summary>
    /// 驗證餘數為0，結果是否正確
    /// </summary>
    /// <returns></returns>
    [Fact]
    public void Test_Mess_Repository_When_Zero()
    {

        // arrange
        var repository = new Demo_Mess_Repository();

        // act
        repository.WriteToDatabase(0);

        // assert


    }

    /// <summary>
    /// 驗證餘數為1，結果是否正確
    /// 這邊要營造一個輸入4 ，但他應該被2 整除，但是我們要讓他寫入Table1的錯誤情境
    /// </summary>
    [Theory]
    [InlineData(1)]
    [InlineData(4)]
    public void Test_Mess_Repository_When_One(int number)
    {

        // arrange
        var repository = new Demo_Mess_Repository();

        // act
        repository.WriteToDatabase(number);

        // assert

    }
}