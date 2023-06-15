﻿using Microsoft.AspNetCore.Mvc;

namespace InventoryManagmentWithMVC.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("NotFound");
            }
            return View();
        }
    }
}
