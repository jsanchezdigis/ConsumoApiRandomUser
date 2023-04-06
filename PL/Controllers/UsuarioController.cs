using Microsoft.AspNetCore.Mvc;
using PL.Models;
using System.Text.Json.Nodes;

namespace PL.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult GetAll()
        {
                return View();
        }
    }
}
