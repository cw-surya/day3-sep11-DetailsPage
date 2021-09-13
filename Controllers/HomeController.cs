using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DetailsPage.Models;

namespace DetailsPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string carImageUrl = "https://imgd.aeplcdn.com/1024x768/cw/ucp/stockApiImg/5VRRXKK_2175689_1_19970219.jpg?q=85";
            string ownerComment = "Tata Hexa , very well maintained car . 7 seater car , original paint . New shape car in blue color . The car has run only 24000 kms . showroom condition and less runned";
           
            Car newCar = new Car(){
                Price = 9.25f,Name="Tata Hexa",Version="XE 4x2 7 STR",Year= new DateTime(2017,11,1),Kilometer=24211,TransmissionType = Transmission.Manual,PresentLocation="G.P.O, Raipur",RegisteredLocation="raipur",Color="blue",Fuel=FuelType.Diesel,CarImageUrl = carImageUrl,OwnerComment = ownerComment,
            };
            return View(newCar);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
