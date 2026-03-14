using Microsoft.AspNetCore.Mvc;
using Do_An_Co_So.Models;
using Do_An_Co_So.Repositories;
public class TourController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detail(int id)
    {
        ViewBag.Id = id;
        return View();
    }

    // HIỂN THỊ FORM
    public IActionResult Booking()
    {
        return View();
    }

    // XỬ LÝ ĐẶT TOUR
    [HttpPost]
    public IActionResult Booking(string name, string phone, string startDate, string endDate, int people)
    {
        Booking booking = new Booking()
        {
            Name = name,
            Phone = phone,
            StartDate = startDate,
            EndDate = endDate,
            People = people
        };

        BookingRepository.Bookings.Add(booking);

        ViewBag.Name = name;
        ViewBag.Phone = phone;
        ViewBag.StartDate = startDate;
        ViewBag.EndDate = endDate;
        ViewBag.People = people;

        return View("Confirm");
    }
    public IActionResult Places(int id)
    {
        ViewBag.Id = id;

        if (id == 2)
        {
            ViewBag.TourName = "Đà Lạt";
            ViewBag.Places = new List<dynamic>()
        {
            new { Name="Quảng trường Lâm Viên", Img="https://th.bing.com/th/id/OIP.EFv-hTeiubQmD1RPDFYjYAHaEK?w=324&h=182&c=7&r=0&o=7&dpr=1.3&pid=1.7&rm=3" },
            new { Name="Hồ Xuân Hương", Img="https://images2.thanhnien.vn/Uploaded/binhht/2022_09_14/dalat-2-7589.jpg" },
            new { Name="Thung Lũng Tình Yêu", Img="https://th.bing.com/th/id/R.07fe6e6b120ad1ff5ef080d213fc63fd?rik=7fLDMCjQ5tTDHQ&pid=ImgRaw&r=0" }
        };
        }

        else if (id == 1)
        {
            ViewBag.TourName = "Đà Nẵng";
            ViewBag.Places = new List<dynamic>()
        {
            new { Name="Bà Nà Hills", Img="https://danangtravelcar.com.vn/wp-content/uploads/2022/07/kinh-nghiem-di-ba-na-hill-8.jpeg" },
            new { Name="Cầu Vàng", Img="https://image.vietgoing.com/destination/large/vietgoing_xnu2212294983.webp" },
            new { Name="Biển Mỹ Khê", Img="https://static.toiimg.com/photo/msid-92522576,width-96,height-65.cms" }
        };
        }

        else if (id == 3)
        {
            ViewBag.TourName = "Phú Quốc";
            ViewBag.Places = new List<dynamic>()
        {
            new { Name="VinWonders", Img="https://tse4.mm.bing.net/th/id/OIP.JMfloI_MIAqBFgbYuKQSGwHaD4?rs=1&pid=ImgDetMain&o=7&rm=3" },
            new { Name="Bãi Sao", Img="https://ngocanhtravel.vn/wp-content/uploads/2021/05/Bai-Sao-Phu-Quoc-1200x900.jpg" },
            new { Name="Chợ đêm Phú Quốc", Img="https://tiki.vn/blog/wp-content/uploads/2023/02/cho-dem-phu-quoc.jpg" }
        };
        }

        else if (id == 4)
        {
            ViewBag.TourName = "Nha Trang";
            ViewBag.Places = new List<dynamic>()
        {
            new { Name="VinWonders Nha Trang", Img="https://vinpearlvoucher.net/wp-content/uploads/2026/03/tro-choi-vu-tru-xoay-than-vinwonders-nha-trang.webp" },
            new { Name="Tháp Bà Ponagar", Img="https://tse3.mm.bing.net/th/id/OIP.h2lgxCcRAUEb4MEW9iW_8AHaE6?rs=1&pid=ImgDetMain&o=7&rm=3" },
            new { Name="Biển Nha Trang", Img="https://cdn.vntrip.vn/cam-nang/wp-content/uploads/2017/11/nha-trag-10.jpg" }
        };
        }

        else if (id == 5)
        {
            ViewBag.TourName = "Sa Pa";
            ViewBag.Places = new List<dynamic>()
        {
            new { Name="Fansipan", Img="https://jackfruitadventure.com/wp-content/uploads/2024/05/fansipan-Mountain-.webp" },
            new { Name="Bản Cát Cát", Img="https://asialegend.travel/wp-content/uploads/2024/03/Cat-Cat-Village-offers-cultural-immersion-with-ethnic-Hmong-houses-and-stunning-natural-scenery.jpg" },
            new { Name="Nhà thờ đá Sa Pa", Img="https://www.vietfuntravel.com.vn/image/data/sa-pa/nha-tho-co-sapa/nha-tho-da-co-sapa-7.jpg" }
        };
        }

        else if (id == 6)
        {
            ViewBag.TourName = "Hạ Long";
            ViewBag.Places = new List<dynamic>()
        {
            new { Name="Vịnh Hạ Long", Img="https://cdn-media.sforum.vn/storage/app/media/anh-vinh-ha-long-45.jpg" },
            new { Name="Đảo Ti Tốp", Img="https://media.mia.vn/uploads/blog-du-lich/dao-ti-top-ngam-nhin-hon-dao-binh-yen-giua-long-vinh-ha-long-1641626797.jpeg" },
            new { Name="Hang Sửng Sốt", Img="https://th.bing.com/th/id/R.5d47baa3d9a4a4dd916edebae65edc5b?rik=Zi1fDVBOFM25gw&pid=ImgRaw&r=0" }
        };
        }

        return View();

    }
}