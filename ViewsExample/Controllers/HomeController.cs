using Microsoft.AspNetCore.Mvc;
using ViewBagViewsCoreMVC6.Models;

namespace ViewBagViewsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("home")]
    [Route("/")]
    public IActionResult Index()
    {
      ViewData["appTitle"] = "Asp.Net Core Demo App";

      List<Person> people = new List<Person>()
      {
          new Person() { Name = "BlackCoder1", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
          new Person() { Name = "BlackCoder2", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
          new Person() { Name = "BlackCoder3", DateOfBirth = null, PersonGender = Gender.Other}
      };
      //ViewData["people"] = people;
      ViewBag.people = people;

      return View(); //Views/Home/Index.cshtml
    }
  }
}
