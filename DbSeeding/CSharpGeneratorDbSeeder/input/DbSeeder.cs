using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Models
{
    public static class DbSeeder
    {
        public static void DoSeeding(AppDbContext dbContext)
        {
            SeedUsers(dbContext);
            SeedCars(dbContext);
            SeedInsurances(dbContext);
        }

        private static void SeedUsers(AppDbContext dbContext)
        {
            if (!dbContext.Users!.Any())
            {
                var users = new User[] 
                {
                    new User()
                    {
                        
                    }
                };
                foreach (User user in users)
                {
                    dbContext.Users!.Add(user);
                }
                dbContext.SaveChanges();
            }
        }

        private static void SeedCars(AppDbContext dbContext)
        {
            if (!dbContext.Cars!.Any())
            {
                var cars = new Car[]
                {
                    new Car()
                    {
                    }
                };
                foreach (Car car in cars)
                {
                    dbContext.Cars!.Add(car);
                }
                dbContext.SaveChanges();
            }
        }

        private static void SeedInsurances(AppDbContext dbContext)
        {
            if (!dbContext.Insurances!.Any())
            {
                var insurances = new Insurance[]
                {
                    new Insurance()
                    {
                    }
                };
                foreach (Insurance insurance in insurances)
                {
                    dbContext.Insurances!.Add(insurance);
                }
                dbContext.SaveChanges();
            }
        }
    }
}
