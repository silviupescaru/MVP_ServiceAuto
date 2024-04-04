using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAutoMVP.Model.Repository;
using ServiceAutoMVP.Model;

namespace ServiceAutoMVP_Test
{
    [TestFixture]
    public class CarRepositoryTest
    {
        [Test]
        public void AddCarTest()
        {
            CarRepository carRepository = new CarRepository();
            Car car = new Car(20, "Silviu", "Nissan", "Gray", "Diesel");

            bool result1 = carRepository.AddCar(car);
            bool result2 = carRepository.AddCar(car);

            Repository repository = new Repository();
            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        [Test]
        public void UpdateCarTest()
        {
            CarRepository carRepository = new CarRepository();
            Car car = new Car(20, "Silviu", "Nissan", "Gray", "Diesel");

            bool result1 = carRepository.UpdateCar(car);
            bool result2 = carRepository.UpdateCar(car);

            Repository repository = new Repository();
            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
        }

        [Test]
        public void DeleteCarTest()
        {
            CarRepository carRepository = new CarRepository();
            Car car = new Car(1014, "Silviu", "Nissan", "Gray", "Diesel");

            bool result = carRepository.DeleteCar(car.CarID);

            Repository repository = new Repository();
            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsFalse(result);  
        }

        [Test]
        public void CarListTest()
        {
            CarRepository carRepository = new CarRepository();
            Car car1 = new Car(1014, "Silviu", "Nissan", "Gray", "Diesel");
            Car car2 = new Car(1015, "Ella", "Honda", "Black", "Gasoline");

            carRepository.AddCar(car1);
            carRepository.AddCar(car2);

            List<Car> result = carRepository.CarList();

            Repository repository = new Repository();
            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsNotNull(result);
        }

        [Test]
        public void SearchCarTest()
        {
            CarRepository carRepository = new CarRepository();

            Car car1 = new Car(1014, "Silviu", "Nissan", "Gray", "Diesel");
            Car car2 = new Car(1015, "Ella", "Honda", "Black", "Gasoline");

            carRepository.AddCar(car1);
            carRepository.AddCar(car2);

            List<Car> result1 = carRepository.SearchCarByOwner("Silviu");
            Car result2 = carRepository.SearchCarByID("1014");
            Car result3 = carRepository.SearchCarByID("6");

            Repository repository = new Repository();
            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsNotNull(result1);
            Assert.IsNull(result2);
            Assert.IsNotNull(result3);
        }
    }
}
