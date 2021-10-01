using Microsoft.AspNetCore.Mvc;
namespace TIME.Controllers
{
    public class TIMEController : Controller
    {
        [HttpGet("")]
        public ViewResult Time()
        {
            return View("Index");
        }
    }
}