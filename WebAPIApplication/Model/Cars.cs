using WebAPIApplication.Collect;

namespace WebAPIApplication.Model
{
    public enum Engine { Petrol, Disel, Hibrid, Electro };
    public class Cars// : IManagementCars
    {
        public string VIN { get; set; } = "";
        public int Year { get; set; }
        public string Maker { get; set; } = "";
        public string Model { get; set; } = "";
        public string Color { get; set; } = "";
        public double Price { get; set; }

        public Engine Engine { get; set; }

        //public static List<Cars> GenCars()
        //{
        //    var cars = new List<Cars>();
        //    cars.Add(new Cars { VIN = "VBNM234RP76", Year = 2011, Maker = "BMW", Model = "328i", Color = "White", Price = 20123.20D, Engine = Engine.Petrol });
        //    cars.Add(new Cars { VIN = "UYU7589HHF001", Year = 2019, Maker = "Kia", Model = "Soul", Color = "Green", Price = 16563.00D, Engine = Engine.Disel });
        //    cars.Add(new Cars { VIN = "LKMNTRF1569745", Year = 2022, Maker = "Ford", Model = "Mustang", Color = "Yellow", Price = 40569.02D, Engine = Engine.Hibrid });
        //    cars.Add(new Cars { VIN = "WDJGU846SHFY002", Year = 2017, Maker = "Mazda", Model = "CX-5", Color = "Gray", Price = 28550.47D, Engine = Engine.Electro });
        //    return cars;
        //}

    }
}
