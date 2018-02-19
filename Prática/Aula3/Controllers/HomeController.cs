using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var aEquipment = new CharacterSheetApp.Models.Equipment();
      aEquipment.Name = "Shield";
      
      return View(aEquipment);
    }
  }
}
