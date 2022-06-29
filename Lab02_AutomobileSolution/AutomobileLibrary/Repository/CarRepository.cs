using AutomobileLibrary.BussinessObject;
using System.Collections.Generic;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);

        public void DeleteCar(int carID) => CarDBContext.Instance.Remove(carID);

        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);

    }
}