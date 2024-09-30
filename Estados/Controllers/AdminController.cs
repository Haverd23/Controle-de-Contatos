using Estados.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


public class AdminController : Controller
{
    [PaginaRestritaSomenteAdmin]
    public IActionResult Index()
    {
        return View();
    }


}
