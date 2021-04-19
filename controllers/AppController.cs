using DutchTreat.models;
using DutchTreat.services;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailservice;

        public AppController(IMailService mailservice)
        {
            _mailservice = mailservice;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return Ok(new { contact = "contact us" });
        }

        [HttpPost("contact")]
        public IActionResult Contact([FromBody] ContactModel model)
        {
            if (ModelState.IsValid)
            {
                //Send the email
                _mailservice.SendMessage("lol", "Hola", "Venga");
                ModelState.Clear();
                return Ok(new { email = model.Email, status = "sent" });
            }
            else
            {
                return StatusCode(500, ModelState.Values);
            }
        }

        public IActionResult About()
        {
            return Ok();
        }

    }
}