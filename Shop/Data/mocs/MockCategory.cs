using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;


namespace Shop.Data.mocs
{
    public class MockCategory : ICarsCotegory
    {
        public IEnumerable<Category> AllCotegorys
        {
            get
            {
                return new List<Category>
            {
                new Category { CotegoryName = "Электромобили", Dis = "Современный вид транспорта" },
                new Category { CotegoryName = "Спортивные автомобили", Dis = "Автомобили с высокой производительностью" },
                new Category { CotegoryName = "Классические автомобили", Dis = "Исторические автомобили" }
            };
            }
        }
    }
}
