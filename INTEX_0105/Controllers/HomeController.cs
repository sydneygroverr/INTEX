using Microsoft.AspNetCore.Mvc;
using INTEX_0105.Models;
using INTEX_0105.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace INTEX_0105.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repo;
        public HomeController(IProductRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {

                return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Product(int pageNum)
        {
            int pageSize = 10;

            var blah = new ProductListViewModel
            {
                Products = _repo.Products
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    currentPage = pageNum,
                    itemsPerPage = pageSize,
                    totalItems = _repo.Products.Count()

                }
            };

            return View(blah);
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
