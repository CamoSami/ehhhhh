using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebAppBruh.Models;

namespace WebAppBruh.Controllers
{
    public class MyController : Controller
    {
        private const string MY_VIEW = "MyView";

        public IActionResult Index(string message = "empty", int page = 0, int id = 0) {
            this.ViewBag.id = id;
            this.ViewBag.Message = message;
            this.ViewBag.Date = DateTime.Now;
            this.ViewBag.Page = page;

            Message bruh = new Message(message, page);

            return this.View(bruh);
        }

        public IActionResult Add() {
            return this.View(new Message());
        }

        [HttpPost]
        public IActionResult Add(Message message, int page = 0) {
            this.ViewBag.Message = message.msg;
            this.ViewBag.Date = DateTime.Now;
            this.ViewBag.Page = message.pgnum;

            return this.View(MY_VIEW);
        }
    }
}
