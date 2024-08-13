using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Test
{
    [TestClass]
    public class CarRepositoryTest
    {
        private AppDbContext? _dbContext;
        private ICarRepository? _carRepository;

        [TestInitialize]
        public async Task TestInitialize()
        {
            _dbContext = await GetDbContext();
            _carRepository = new CarRepository(_dbContext);
        }

        private async Task<AppDbContext> GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var dbContext = new AppDbContext(builder);
            await dbContext.Database.EnsureCreatedAsync();
            DbSeeder.DoSeeding(dbContext);
            return dbContext;
        }

        [TestMethod]
        public async Task TestCreateAsync()
        {
            Car car = new Car()
            {
                Model = "2024",
                Color = "#C0C0C0",
                Price = 30000.0m,
                PlateNumber = "12345",
                LastModified = new DateTime(2024, 8, 8),
                IsDeleted = false,
                LastDeleted = new DateTime(2024, 8, 8)
            };

            Car? insertedCar = await _carRepository!.CreateAsync(car);
            Car? existingCar = await _carRepository!.GetByIdAsync(insertedCar!.Id);

            Assert.IsNotNull(insertedCar);
            Assert.IsNotNull(existingCar);
            Assert.IsTrue(insertedCar?.Id == existingCar?.Id);
        }

        [TestMethod]
        public async Task TestUpdateAsync()
        {
            decimal newPrice = 15000.0m;
            Car? car = await _dbContext!.Cars!
                .Where(c => c.Id == 1)
                .FirstOrDefaultAsync();
            car!.Price = newPrice;
            Car? updatedCar = await _carRepository!.UpdateAsync(car!);
            Assert.IsTrue(updatedCar!.Price == newPrice);
        }

        [TestMethod]
        public async Task TestDeleteAsync()
        {
            int carId = 155;
            Car? deletedCar = await _carRepository!.DeleteAsync(carId);
            Car? car = await _carRepository.GetByIdAsync(carId);
            Assert.IsNull(car);
            Assert.IsTrue(deletedCar!.IsDeleted);
        }

        [TestMethod]
        public async Task TestGetAllAsync()
        {
            var carList = await _carRepository!.GetAllAsync();
            Assert.IsTrue(carList.Any());
        }

        [TestMethod]
        public async Task TestGetByKeywordAsync()
        {
            List<Car> carList = await _carRepository!.GetByKeywordAsync("1990");
            Assert.IsTrue(carList.Any());
        }

        [TestMethod]
        public async Task TestExistAsync()
        {
            bool exist = await _carRepository!.ExistAsync(1);
            Assert.IsTrue(exist);
        }

        [TestMethod]
        public async Task TestCountAsync()
        {
            Assert.IsTrue(await _carRepository!.CountAsync() > 0);
        }
    }
}