namespace WebAPIApplication.Collect
{
    public interface IManagementCars
    {
        List<string> GetCarsName();
        string GetCarNameById(string VIN);
        List<string> GetCarsEngine();
        string GetCarEngineById(string VIN);
        List<int> GetCarsAge();
        int GetCarAgeById(string VIN);
    }
}
