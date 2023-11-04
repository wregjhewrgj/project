using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.mocs;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Models;
using Shop.ViewsMoels;

namespace Shop.controles
{
    public class CarController : Controller
    {
        private readonly IAllToarccs _allToarccs;
        private readonly ICarsCotegory _allCotegory;

        public CarController(IAllToarccs iAllToarCCS, ICarsCotegory iCarsCotegory) 
        {
            _allToarccs = iAllToarCCS;
            _allCotegory = iCarsCotegory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с Автомобилями";
            CarViewModels carViewModels = new CarViewModels();
            carViewModels.getAllCars = _allToarccs.cars;
            carViewModels.carcotegory = "Автомобили";
            return View(carViewModels);
        }

    }
}
