using Microsoft.AspNetCore.Mvc;
using NGUYENVANNGOC.Models.DANHSACH;

namespace NGUYENVANNGOC.Controllers
{
    public class DANHSACHController : Controller
    {
        public static List<ModelDanhSach> products = new List<ModelDanhSach>();
       
        public IActionResult DANHSACH(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }

        [HttpPost]
        public IActionResult DANHSACH(string tensanpham, int soluong, int dongia,int giamgia)
        {
            var homeProduct = new ModelDanhSach(tensanpham, soluong, dongia, giamgia);
            products.Add(homeProduct);
            return View(products);
        }

        public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Index", "Home");
        }
    }
}
