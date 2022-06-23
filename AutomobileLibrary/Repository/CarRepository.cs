using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarById(int carId) => CarDBContext.Instance.GetCarByID(carId);
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarLists();
        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);
        public void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
