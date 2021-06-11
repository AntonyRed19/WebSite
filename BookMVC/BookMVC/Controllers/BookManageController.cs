using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMVC.Models;
using BookMVC.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class BookManageController : Controller
    {
        private readonly IBookManageService _bookManageService;
        public BookManageController(IBookManageService bookManageService)
        {
            _bookManageService = bookManageService;
        }

        public IActionResult Index()
        {
         _bookManageService.CreateAsync("Some Title", "Hello there ");
         return View();
        }
    }
}
