using InsuranceWebApplication.Enums;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Test
{
    [TestClass]
    public class InsuranceRepositoryTest
    {
        private AppDbContext? _dbContext;
        private IInsuranceRepository? _insuranceRepository;

        [TestInitialize]
        public async Task TestInitialize()
        {
            _dbContext = await GetDbContext();
            _insuranceRepository = new InsuranceRepository(_dbContext);
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
            Insurance insurance = new Insurance()
            {
                UserId = 1,
                CarId = 1,
                StartDate = new DateTime(1995, 1, 1),
                EndDate = new DateTime(2000, 1, 1),
                TypeOfInsurance = "Common",
                Premium = 2000.0m,
                Status = InsuranceStatus.Active,
            };
            Insurance? insertedInsurance = await _insuranceRepository!.CreateAsync(insurance);
            Insurance? existingInsurance = await _insuranceRepository!.GetByIdAsync(insertedInsurance!.Id);
            Assert.IsNotNull(insertedInsurance);
            Assert.IsNotNull(existingInsurance);
            Assert.IsTrue(insertedInsurance?.Id == existingInsurance?.Id);
        }

        [TestMethod]
        public async Task TestUpdateAsync()
        {
            decimal newPremium = 45555.0m;
            Insurance? insurance = await _dbContext!.Insurances!
                .Where(i => i.Id == 1)
                .FirstOrDefaultAsync();
            insurance!.Premium = newPremium;
            Insurance? updatedInsurance = await _insuranceRepository!.UpdateAsync(insurance!);
            Assert.IsTrue(updatedInsurance!.Premium == newPremium);
        }

        [TestMethod]
        public async Task TestDeleteAsync()
        {
            int insuranceId = 155;
            Insurance? deletedInsurance = await _insuranceRepository!.DeleteAsync(insuranceId);
            Insurance? insurance = await _insuranceRepository.GetByIdAsync(insuranceId);
            Assert.IsNull(insurance);
            Assert.IsTrue(deletedInsurance!.IsDeleted);
        }

        [TestMethod]
        public async Task TestGetAllAsync()
        {
            var insuranceList = await _insuranceRepository!.GetAllAsync();
            Assert.IsTrue(insuranceList.Any());
        }

        [TestMethod]
        public async Task TestGetByKeywordAsync()
        {
            List<Insurance> insuranceList = await _insuranceRepository!.GetByKeywordAsync("Pedro");
            Assert.IsTrue(insuranceList.Any());
        }

        [TestMethod]
        public async Task TestExistAsync()
        {
            bool exist = await _insuranceRepository!.ExistAsync(1);
            Assert.IsTrue(exist);
        }

        [TestMethod]
        public async Task TestCountAsync()
        {
            Assert.IsTrue(await _insuranceRepository!.CountAsync() > 0);
        }
    }
}
