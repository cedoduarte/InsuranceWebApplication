using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using InsuranceWebApplication.Services;
using Microsoft.EntityFrameworkCore;

namespace Test
{
    [TestClass]
    public class UserServiceTest
    {
        private AppDbContext? _dbContext;
        private UserRepository? _userRepository;
        private UserService? _userService;

        [TestInitialize]
        public void TestInitialize()
        {
            _dbContext = GetDbContext();
            _userRepository = new UserRepository(_dbContext!);
            _userService = new UserService(_userRepository);
        }

        private AppDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var dbContext = new AppDbContext(builder);
            dbContext.Database.EnsureCreated();
            DbSeeder.DoSeeding(dbContext);
            return dbContext;
        }

        [TestMethod]
        public async Task TestCreateAsync()
        {
            // Arrange            
            var user = new User()
            {
                FirstName = "Carlos",
                LastName = "Duarte",
                Email = "bb2730d7-3797-4e83-8b8f-45b943ac340e@gmail.com",
                PasswordHash = "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                LastModified = new DateTime(2024, 8, 8),
                IsDeleted = false,
                LastDeleted = new DateTime(2024, 8, 8)
            };

            // Act
            var insertedUser = await _userService!.CreateAsync(user);
            var existingUser = await _userService!.GetByNameAsync("Carlos Duarte");

            // Assert
            Assert.IsNotNull(insertedUser);
            Assert.IsNotNull(existingUser);
            Assert.IsTrue(insertedUser?.Id == existingUser?.Id);
        }

        [TestMethod]
        public async Task TestUpdateAsync()
        {
            // Arrange
            string newName = "Rodolfo";
            var user = await _userService!.GetByIdAsync(1);
            user!.FirstName = newName;

            // Act
            var updatedUser = await _userService!.UpdateAsync(user!);

            // Assert
            Assert.IsTrue(string.Equals(updatedUser!.FirstName, newName));
        }

        [TestMethod]
        public async Task TestDeleteAsync()
        {
            // Arrange
            int userId = 155;

            // Act
            await _userService!.DeleteAsync(userId);

            // Assert
            var deletedUser = await _userService.GetByIdAsync(userId);
            Assert.IsTrue(deletedUser!.IsDeleted);
        }

        [TestMethod]
        public async Task GetByNameAsync()
        {
            // Act
            var userList = await _userService!.GetAllAsync();

            // Assert
            Assert.IsTrue(userList.Count > 0);
        }
    }
}