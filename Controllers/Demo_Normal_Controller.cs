using Microsoft.AspNetCore.Mvc;

namespace DemoTestEffort.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Demo_Normal_Controller : ControllerBase
    {
        public IActionResult DivisionToWrite(int number)
        {
            try
            {
                // 先宣告Repository
                var repository = new Demo_Normal_Repository();

                // you can use 2 or 3 as the second parameter
                repository.WriteToDatabase(new Counter(number, 3));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}