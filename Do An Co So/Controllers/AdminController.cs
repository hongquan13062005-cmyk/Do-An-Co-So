using Do_An_Co_So.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Do_An_Co_So.Controllers
{
    public class AdminController : Controller
    {
        // Kiểm tra quyền Admin
        private bool CheckAdmin()
        {
            return HttpContext.Session.GetString("role") == "Admin";
        }

        // Trang Dashboard Admin
        public IActionResult Index()
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        // Danh sách tour
        public IActionResult Tours()
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        // Trang thêm tour
        public IActionResult CreateTour()
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        [HttpPost]
        public IActionResult CreateTour(string name, string price, string description)
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = "Thêm tour thành công!";
            return View();
        }

        // Trang sửa tour
        public IActionResult EditTour(int id)
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult EditTour(int id, string name, string price)
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = "Cập nhật tour thành công!";
            return View();
        }

        // Xóa tour
        public IActionResult DeleteTour(int id)
        {
            if (!CheckAdmin())
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = "Đã xóa tour!";
            return RedirectToAction("Tours");
        }

        public IActionResult Bookings()
        {
            var list = BookingRepository.Bookings;
            return View(list);
        }
    }
}
