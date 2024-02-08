using CarRentalSystem.Exceptions;
using CarRentalSystem.Model;
using CarRentalSystem.Repository;
using CarRentalSystem.Exceptions;
using System.Data.SqlTypes;
using CarRentalSystem.Service;
using System.Reflection.Metadata;

namespace CarRentalSystemTest
{

    public class Tests
    {
        CarLeaseRepositoryImpl _carRentalService;

        [SetUp]
        public void Setup()
        {
            _carRentalService = new CarLeaseRepositoryImpl();
        }

        [Test]
        public void IfCarAddSuccessElseFail()
        {
            Vehicle testVehicle = new Vehicle()
            {
                VehicleID = 13,
                Make = "BMW",
                Model = "X1",
                Year = 2022,
                DailyRate = 100,
                Status = "available",
                PassengerCapacity = 7,
                EngineCapacity = 2000

            };
            List<Vehicle>vehicles = _carRentalService.ListAvailableCars();
            int c = vehicles.Count;
            _carRentalService.AddCar(testVehicle);
            List<Vehicle> vehiclesAfterAdding = _carRentalService.ListAvailableCars();
            int AfterAdding = vehicles.Count;
            Assert.Equals(AfterAdding, c + 1);
           

        }
       

        [Test]
        public void FindCarById_ThrowsCustomerNotFoundException()
        {
            int nonExistingCustomerId = 100;
            Assert.Throws<CustomerNotFoundException>(() => _carRentalService.FindCustomerById(nonExistingCustomerId));

        }


        [Test]
        public void FindCarById_ThrowsCarNotFoundException()
        {
            int nonExistingVehicleId = 100;
            Assert.Throws<CarNotFoundException>(() => _carRentalService.FindCarById(nonExistingVehicleId));
        }

    }
}
