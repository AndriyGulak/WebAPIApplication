using WebApplicationHW.Interfaces;

namespace WebApplicationHW.Model
{
    //public enum Engine { Petrol, Disel, Hibrid, Electro };
    public class Car
    {
        public string VIN { get; set; } = "";
        public int Year { get; set; }
        public string Maker { get; set; } = "";
        public string Model { get; set; } = "";
        public string Color { get; set; } = "";
        public double Price { get; set; }
        //public Engine Engine { get; set; }
        public string Engine { get; set; } = "";

    }


}
