using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;

namespace Buoi02.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LayMot()
        {
            //Doc csdl/file
            var hh = new HangHoa
            {
                MaHangHoa = 1,
                TenHangHoa = "TOSHIBA",
                DonGia = 179000
            };
            //do sang View hien thi
            return View(hh);
        }

        public IActionResult DanhSach()
        {
            List<HangHoa> danhsach = new
                List<HangHoa>();
            HangHoa tmp;
            var rd = new Random();
            // sinh so phan tu ngau nhien tu 3 -> 10
            var soPhanTu = rd.Next(3, 11);

            for(int i=0; i<soPhanTu; i++)
            {
                tmp = new HangHoa
                {
                    MaHangHoa = i + 100,
                    TenHangHoa = $"Samsung {rd.Next()}",
                    DonGia = rd.NextDouble() * 1000000,
                    GiamGia = rd.NextDouble(),
                };
                danhsach.Add(tmp);//Them vao mang
            }
            return View(danhsach);
        }
        public IActionResult DemoHinhHoc()
        {
            return View();
        }
    }
}