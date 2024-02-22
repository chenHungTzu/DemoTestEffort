using Microsoft.AspNetCore.Mvc;

namespace DemoTestEffort.api.Controllers
{
    [Route("api/[controller]/Mess")]
    [ApiController]
    public class Demo_Mess_Controller : ControllerBase
    {
        [HttpGet("DivisionToWrite/{number}")]
        public IActionResult DivisionToWrite(int number)
        {
            try
            {
                // 先宣告Repository
                var repository = new Demo_Mess_Repository();

                if (number < 0)
                {
                    return BadRequest("Number cannot be negative");
                }

                var remainder = number % 2;

                // 寫入資料庫,把餘數傳入,讓Repository決定要寫入哪個Table
                repository.WriteToDatabase(remainder);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 經過時間的更迭,新需求加入後,你發現開始有壞味道了...
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IActionResult DivisionToWrite_Changed(int number)
        {
            try
            {
                // 先宣告Repository
                var repository = new Demo_Mess_Repository();

                if (number < 0)
                {
                    return BadRequest("Number cannot be negative");
                }

                if (number % 3 != 0)
                {
                    repository.WriteToDatabase_Changed(number % 3);
                }
                else // 迷之聲 : 上線後的需求我不敢改阿...
                {
                    var remainder = number % 3;

                    // 寫入資料庫,把餘數傳入,讓Repository決定要寫入哪個Table
                    repository.WriteToDatabase(remainder);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}