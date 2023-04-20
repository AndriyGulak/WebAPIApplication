using System.Diagnostics.Metrics;
using System.Drawing;
using WebApplicationHW.Interfaces;
using WebApplicationHW.Model;

namespace WebApplicationHW.Services
{
    public class ManagementCars : IManagementCars
    {
        Car Car { get; set; }

        List<Car> Cars { get; set; }
        public string GetCarAge() => (DateTime.Now.Year - Car.Year).ToString();
        public string GetCarEngine() => Car.Engine; //" GetCarEngine()";//Car.Engine;
        public string GetCarName() => Car.Maker + " " + Car.Model;
        public List<Car> GetCars() => Cars;
        public ManagementCars()
        {
            Car = new Car { VIN = "VBNM234RP76", Year = 2011, Maker = " BMW", Model = "328i", Color = "White", Price = 20123.20D, Engine = "Petrol" };

            Cars = new List<Car>();
            Cars.Add(new Car { VIN = "VBNM234RP76", Year = 2011, Maker = "BMW", Model = "328i", Color = "White", Price = 20123.20D, Engine = "Petrol" });
            Cars.Add(new Car { VIN = "UYU7589HHF001", Year = 2019, Maker = "Kia", Model = "Soul", Color = "Green", Price = 16563.00D, Engine = "Disel" });
            Cars.Add(new Car { VIN = "LKMNTRF1569745", Year = 2022, Maker = "Ford", Model = "Mustang", Color = "Yellow", Price = 40569.02D, Engine = "Hibrid" });
            Cars.Add(new Car { VIN = "WDJGU846SHFY002", Year = 2017, Maker = "Mazda", Model = "CX-5", Color = "Gray", Price = 28550.47D, Engine = "Electro"});

            }
    }
}
