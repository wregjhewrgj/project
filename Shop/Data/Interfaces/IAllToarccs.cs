using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAllToarccs
    {
        IEnumerable<Car> cars { get;}
        IEnumerable<Car> getFoverCars { get; set; }
        Car getObjCar(int carId);

    }
}
