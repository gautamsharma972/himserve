using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks; 
using Himserve.Models;
using Himserve.Services;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Himserve.Controllers
{
    public class HomeController : ControllerBase
    { 
        private static IEmailSender _emailSender;

        public HomeController(IEmailSender emailsender)
        { 
            _emailSender = emailsender;
        }

        [Route("~/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("~/Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string subject, string message)
        {
            try
            {
                message += $"<br/><hr/>This message was sent by {name}, ({email}) on {DateTime.Now.ToString("dd/MM/yyyy")} from the official website of HIMserve at <a href='himserve.org'>himserve.org</a>";
                var mailMessage = new Message(email, new string[] { "gautamsharma972@gmail.com" }, subject, message);
                _emailSender.SendMail(mailMessage);
                return Json(new { message = "Your message have been successfully sent. We will get in touch shortly.", success = true });
            }
            catch (Exception ex)
            {
                return Json(new { message = "some error occurred. Please try again later", success = false });
            }
            
        }
  
        [Route("~/Donate")]
        public IActionResult Donate()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
