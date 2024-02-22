
using DemoTestEffort.api;
using DemoTestEffort.api.Controllers;
using FluentAssertions;


namespace test;

public class UnitTest_Normal
{

    /// <summary>
    /// 驗證例外是否正確攔截
    /// </summary>
    /// <returns></returns>
    [Fact]
    public void Test_Mess_Controller_Should_be_True()
    {

        // arrange
        var controller = new Demo_Normal_Controller();

        // TODO:這邊專注驗證讓內部拋出例外，能夠有效攔截即可。
    }

    /// <summary>
    /// 主要驗證邏輯，當被除數為負數時，應該要拋出例外
    /// </summary>
    [Fact]
    public void Test_Divider_When_Number_Negative()
    {
        var ex = Assert.Throws<ArgumentException>(() => new Divider(-1, 3));
        var expect = "Number cannot be negative";
        ex.Message.Should().Be(expect);

    }

    /// <summary>
    /// 主要驗證邏輯，當除數為0或負數時，應該要拋出例外
    /// </summary>
    /// <param name="divisor"></param>
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Test_Divider_When_Divisor_Zero(int divisor)
    {
        var ex = Assert.Throws<ArgumentException>(() => new Divider(1, divisor));
        var expect = "Divisor cannot be zero or negative";
        ex.Message.Should().Be(expect);
    }

    /// <summary>
    /// 這邊專注驗證對應的被除數，能不能正確的指向到對應的TABLE
    /// </summary>
    /// <param name="number">被除數</param>
    /// <param name="target">目標TABLE</param>
    [Theory]
    [InlineData(0, "Table0")]
    [InlineData(1, "Table1")]
    [InlineData(2, "Table2")]
    [InlineData(3, "Table0")]
    public void Test_Divider_Should_be_True(int number, string target)
    {
        var divider = new Divider(number, 3);

        divider.TableName.Should().Be(target);
    }

   

    /// <summary>
    /// 專注驗證正常的Repository是否將值正確的寫入資料庫
    /// 這邊用Dapper來寫，簡化程式內容
    /// </summary>
    [Fact]
    [InlineData(0, "Table0")]
    [InlineData(1, "Table1")]
    [InlineData(2, "Table2")]
    [InlineData(3, "Table0")]
    public void Test_Normal_repository_Should_be_True()
    {
        // arrange
        var repository = new Demo_Normal_Repository();

        //TODO: 這邊專注驗證資料是否正確寫入到資料庫即可。

    }

    /// <summary>
    /// 當然，也要測試例外情境 (資料庫不存在)
    /// </summary>
    [Fact]
    [InlineData(9, "Table9")]
    public void Test_Normal_repository_Should_be_Throw()
    {
        // arrange
        var repository = new Demo_Normal_Repository();

        //TODO: 這邊專注驗證資料是否正確寫入到資料庫即可。

    }



}