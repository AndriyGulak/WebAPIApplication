using WebApplicationHW.Model;

namespace WebApplicationHW.Interfaces
{
    public interface IManagementCars
    {
        public string GetCarName();
        public string GetCarEngine();
        public string GetCarAge();

        public List<Car> GetCars();
    }
}
