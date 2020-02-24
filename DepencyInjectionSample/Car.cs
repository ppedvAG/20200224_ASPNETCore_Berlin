using System;
using System.Collections.Generic;
using System.Linq;

namespace DepencyInjectionSample
{
    public interface ICar
    {
        string Marke { get; set; }
        string Model { get; set; }
        int Baujahr { get; set; }
    }
    public class Car : ICar
    {
        public string Marke 
        { 
            get; set; 
        }

        public string Model 
        { 
            get; set; 
        }
        public int Baujahr 
        { 
            get; set ; 
        }
    }

    public interface ICarService
    {
        IList<ICar> Cars { get; set; }

        ICar GetCarById(int Id);
    }

    public class CarService : ICarService
    {
        public IList<ICar> Cars { get; set; }

        public ICar GetCarById(int Id)
        {
            ICar currentCar = Cars.Single(n => n.Baujahr > 2000);

            //return currentCar; 
            return new Car { Marke = "VW", Model = "Passat", Baujahr = 2001 };
        }
    }
}
