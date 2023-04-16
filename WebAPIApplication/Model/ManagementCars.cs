using WebAPIApplication.Collect;

namespace WebAPIApplication.Model
{
    public class ManagementCars : IManagementCars
    {
        public List<Cars> Cars { get; set; }

        public int GetY()
        { 
            foreach (var car in Cars)
            {
                Console.WriteLine(car.Year);
            }

            return 0;
        }
        public List<int> GetCarsAge()
        {
            var years = new List<int>();
            foreach (var car in Cars) { years.Add(car.Year); }
            return years;
        }

        public int GetCarAgeById(string VIN)
        {
            
            //foreach (var y in year) {year. }
            //return DateTime.Now.Year - year.;

            throw new NotImplementedException();
        }

        public List<string> GetCarsEngine()
        {
            throw new NotImplementedException();
        }

        public string GetCarEngineById(string VIN)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCarsName()
        {
            throw new NotImplementedException();
        }

        public string GetCarNameById(string VIN)
        {
            throw new NotImplementedException();
        }

    }

}
