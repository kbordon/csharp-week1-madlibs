using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/story")]
        public ActionResult Story()
        {
            StoryVariable.AddStoryWord("color", Request.Form["color"]);
            StoryVariable.AddStoryWord("superlative", Request.Form["superlative"]);
            StoryVariable.AddStoryWord("adjective1", Request.Form["adjective1"]);
            StoryVariable.AddStoryWord("body-parts", Request.Form["body-parts"]);
            StoryVariable.AddStoryWord("body-part", Request.Form["body-part"]);
            StoryVariable.AddStoryWord("noun", Request.Form["noun"]);
            StoryVariable.AddStoryWord("animals", Request.Form["animals"]);
            StoryVariable.AddStoryWord("adjective2", Request.Form["adjective2"]);
            StoryVariable.AddStoryWord("adjective3", Request.Form["adjective3"]);
            StoryVariable.AddStoryWord("adjective4", Request.Form["adjective4"]);
            return View(StoryVariable.GetStoryWords());
        }
    }
}
