using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Test
{
    [TestClass]
    public class UserRepositoryTest
    {
        private AppDbContext? _dbContext;
        private IUserRepository? _userRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _dbContext = GetDbContext();
            _userRepository = new UserRepository(_dbContext);
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
            User user = new User()
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
            User? insertedUser = await _userRepository!.CreateAsync(user);
            User? existingUser = await _userRepository!.GetByIdAsync(insertedUser!.Id);

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
            User? user = await _userRepository!.GetByIdAsync(1);
            user!.FirstName = newName;

            // Act
            User? updatedUser = await _userRepository!.UpdateAsync(user!);

            // Assert
            Assert.IsTrue(string.Equals(updatedUser!.FirstName, newName));
        }

        [TestMethod]
        public async Task TestDeleteAsync()
        {
            // Arrange
            int userId = 155;

            // Act
            User? deletedUser = await _userRepository!.DeleteAsync(userId);
            User? user = await _userRepository.GetByIdAsync(userId);

            // Assert
            Assert.IsNull(user);
            Assert.IsTrue(deletedUser!.IsDeleted);
        }

        [TestMethod]
        public async Task TestGetAllAsync()
        {
            // Act
            var userList = await _userRepository!.GetAllAsync();

            // Assert
            Assert.IsTrue(userList.Any());
        }

        [TestMethod]
        public async Task TestGetByKeyword()
        {
            List<User> userList = await _userRepository!.GetByKeyword("Pedro");
            Assert.IsTrue(userList.Any());
        }
    }
}