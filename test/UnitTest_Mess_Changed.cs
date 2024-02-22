using DemoTestEffort.api;
using DemoTestEffort.api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace test;

public class UnitTest_Mess_Changed
{

    /// <summary>
    /// 邏輯驗證，是否除數為零
    /// </summary> 
    [Fact]
    public void Test_Mess_Controller_Changes_When_Number_Negative()
    {

        // arrange
        var controller = new Demo_Mess_Controller();

        // act
        var actionResult = controller.DivisionToWrite_Changed(-1);
        var badrequest = actionResult as BadRequestObjectResult;
        var expect = "Number cannot be negative";
        var actual = badrequest.Value as string;

        // assert
        expect.Should().Be(actual);

    }

    /// <summary>
    /// 邏輯驗證，是否餘不為0
    /// </summary>
    [Fact]
    public void Test_Mess_Controller_Changes_When_Has_Remaning()
    {

        // arrange
        var controller = new Demo_Mess_Controller();

        // act
        var actionResult = controller.DivisionToWrite_Changed(2);

        // assert


    }
    
    /// <summary>
    /// 邏輯驗證，是否餘為0
    /// </summary>
    [Fact]
    public void Test_Mess_Controller_Changes_When_Zreo()
    {

        // arrange
        var controller = new Demo_Mess_Controller();

        // act
        var actionResult = controller.DivisionToWrite_Changed(3);

        // assert

    }

    /// <summary>
    /// 驗證為0的情境，是否有正確寫入Table
    /// 這邊用強行別來寫，營造一個不靈活的情境
    /// </summary>
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
    /// 驗證為1的情境，是否有正確寫入Table
    /// 這邊用強行別來寫，營造一個不靈活的情境
    /// </summary> 
    [Fact]
    public void Test_Mess_Repository_When_One()
    {

        // arrange
        var repository = new Demo_Mess_Repository();

        // act
        repository.WriteToDatabase_Changed(1);

        // assert

    }

    /// <summary>
    /// 驗證為2的情境，是否有正確寫入Table
    /// 這邊用強行別來寫，營造一個不靈活的情境
    /// </summary> 
    [Fact]
    public void Test_Mess_Repository_When_Two()
    {

        // arrange
        var repository = new Demo_Mess_Repository();

        // act
        repository.WriteToDatabase_Changed(2);

        // assert

    }

    /// <summary>
    /// 這邊要營造一個輸入4,-1，但是沒有Table背對應到的狀況
    /// 這邊要表達的是，在考慮寫測試時，對於還需考慮邏輯層，與資料存取層的資源是否存在，
    /// 增加了測試的複雜度
    /// </summary> 
    [Theory]
    [InlineData(4)]
    [InlineData(-1)]
    public void Test_Mess_Repository_When_Not_Match(int number)
    {

        // arrange
        var repository = new Demo_Mess_Repository();

        // act
        repository.WriteToDatabase_Changed(number);

        // assert

    }

}