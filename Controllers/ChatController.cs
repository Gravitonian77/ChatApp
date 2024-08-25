using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

public class ChatController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

[Authorize]  // Ensure the user is authenticated
public IActionResult Chat()
{
    return View();
}

}
