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
        public async Task TestInitialize()
        {
            _dbContext = await GetDbContext();
            _userRepository = new UserRepository(_dbContext);
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
            User? user = await _dbContext!.Users!
                .Where(u => u.Id == 1)
                .FirstOrDefaultAsync();
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
        public async Task TestGetByKeywordAsync()
        {
            List<User> userList = await _userRepository!.GetByKeywordAsync("Pedro");
            Assert.IsTrue(userList.Any());
        }

        [TestMethod]
        public async Task TestExistAsync()
        {
            bool exist = await _userRepository!.ExistAsync(1);
            Assert.IsTrue(exist);
        }

        [TestMethod]
        public async Task TestCountAsync()
        {
            Assert.IsTrue(await _userRepository!.CountAsync() > 0);
        }

        [TestMethod]
        public async Task TestAuthenticateAsync()
        {
            string email = "carlosduarte.1@hotmail.com";
            string password = "12345";
            Assert.IsTrue(await _userRepository!.AuthenticateAsync(email, password) is not null);
        }
    }
}