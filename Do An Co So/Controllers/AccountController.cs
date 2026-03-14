using Microsoft.AspNetCore.Mvc;
using Do_An_Co_So.Repositories;
using Do_An_Co_So.Models;

public class AccountController : Controller
{
    private UserRepository repo = new UserRepository();

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        var user = repo.GetUser(username, password);

        if (user != null)
        {
            HttpContext.Session.SetString("username", user.Username);

            if (user.Role == "Admin")
                return RedirectToAction("Bookings", "Admin");

            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Sai tài khoản hoặc mật khẩu";
        return View();
    }

    // TRANG ĐĂNG KÝ
    public IActionResult Register()
    {
        return View();
    }

    // XỬ LÝ ĐĂNG KÝ
    [HttpPost]
    public IActionResult Register(string username, string password)
    {
        User user = new User()
        {
            Username = username,
            Password = password,
            Role = "User"
        };

        repo.Register(user);

        return RedirectToAction("Login");
    }
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}