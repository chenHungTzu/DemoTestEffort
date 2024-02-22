using Microsoft.AspNetCore.Mvc;

namespace DemoTestEffort.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        /// <summary>
        /// 給予一個數字,並根據條件寫入對應的資料表
        /// 規則 :
        ///     -可以被2整除,將數字寫入Table0
        ///     -若無法被2整除,將數字寫入Table1
        /// 需求變更 :
        ///     -可以被3整除,將數字寫入Table0
        ///     -若無法被3整除,餘數為1,將數字寫入Table1
        ///     -若無法被3整除,餘數為2,將數字寫入Table2
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IActionResult DivisionToWrite(int number)
        {
            try
            {
                // 這裡是一個假的Repository,你會如何定義signature?
                var repository = new DemoRepository();
                repository.WriteToDatabase();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}