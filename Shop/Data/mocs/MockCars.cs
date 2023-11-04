using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocs
{
    public class MockCars : IAllToarccs
    {
        private readonly ICarsCotegory _carsCotegory = new MockCategory();

        public IEnumerable<Car> cars
        {
            get
            {
                return new List<Car>
            {
                   new Car
                {
                    cotegoryName = "Tesla Model S",
                    ShortDisc = "Электромобиль", // Заполните короткое описание
                    LongDisc = "Tesla Model S - электрический седан премиум-класса, сочетающий высокую производительность и дальность хода, современный интерьер и передовые технологии.", // Заполните длинное описание
                    img = "/img/tesla.jpg", // Путь к изображению
                    price = 7500,
                    isFovarite = true,
                    aleLable = true,
                    category = _carsCotegory.AllCotegorys.First()
                },

                    new Car
            {
                cotegoryName = "Nissan Leaf",
                ShortDisc = "Электромобиль",
                LongDisc = "Nissan Leaf - компактный электромобиль с нулевыми выбросами, подходит для городской езды и имеет хорошую дальность хода.",
                img = "/img/Nissan_Leaf.jpg",
                price = 3500,
                isFovarite = true,
                aleLable = false,
                category = _carsCotegory.AllCotegorys.First()
            },
                    new Car
            {
                cotegoryName = "Porsche 911",
                ShortDisc = "Спортивные автомобили Porsche 911",
                LongDisc = "Porsche 911 - легендарный спортивный автомобиль, известный своим дизайном и высокой производительностью.",
                img = "/img/Porsche911.jpg",
                price = 15000,
                isFovarite = true,
                aleLable = true,
                category = _carsCotegory.AllCotegorys.Skip((_carsCotegory.AllCotegorys.Count() - 1) / 2).First()
            },


            };
            }

            
        }

        public IEnumerable<Car> getFoverCars { get; set; }

        public Car getObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
