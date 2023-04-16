using System.Diagnostics.Metrics;
using System.Drawing;
using WebApplicationHW.Interfaces;
using WebApplicationHW.Model;

namespace WebApplicationHW.Services
{
    public class ManagementCars : IManagementCars
    {
        Car Car { get; set; }
        public string GetCarAge() => (DateTime.Now.Year - Car.Year).ToString();
        public string GetCarEngine() => Car.Engine; //" GetCarEngine()";//Car.Engine;
        public string GetCarName() => Car.Maker + " " + Car.Model;
        public ManagementCars()
        {
            Car = new Car { VIN = "VBNM234RP76", Year = 2011, Maker = " BMW", Model = "328i", Color = "White", Price = 20123.20D, Engine = "Petrol" };
        }
    }
}
