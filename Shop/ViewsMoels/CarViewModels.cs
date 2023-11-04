using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Models;
using System.Threading.Tasks;

namespace Shop.ViewsMoels
{
    public class CarViewModels
    {
     public   IEnumerable<Car> getAllCars { get; set; }

        public string carcotegory { get; set; }
    }
}
