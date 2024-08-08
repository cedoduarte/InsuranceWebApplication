using System.Security.Cryptography;
using System.Text;

namespace DbSeeding
{
    public class Program
    {
        private static Random Random = new Random();
        private static int UserId = 0;
        private static int CarId = 0;
        private static int InsuranceId = 0;
        private static int TotalRecords = 200;
        private static string[] Names = new string[]
        {
            "Antonio", "Manuel", "Francisco", "José", "Juan", "Javier", "David", "Daniel", "Francisco Javier", "Pedro",
            "Luis", "Miguel", "Alejandro", "Carlos", "Ángel", "Rafael", "Sergio", "Jesús", "Fernando", "Pablo",
            "Alberto", "Andrés", "Mario", "Guillermo", "Enrique", "Alberto", "Tomás", "Iván", "Emilio", "Rubén",
            "Óscar", "Víctor", "Julián", "Ernesto", "Ricardo", "Martín", "Samuel", "Sergio", "Alfonso", "José Antonio",
            "Francisco José", "Germán", "Francisco Manuel", "Nicolás", "Luis Miguel", "Hugo", "Agustín", "Hugo",
            "Emiliano", "César", "Adrián", "Ángel Luis", "Javier Luis", "Sebastián", "Fabián", "Leonardo", "Raúl",
            "Juan Carlos", "Raúl", "Marcos", "Manuel Jesús", "Aitor", "Moisés", "Martín", "Julio", "Daniel", "Salvador",
            "Joaquín", "Jaime", "Juan Pablo", "Alan", "Benjamín", "Federico", "Luis Fernando", "Rodrigo", "Jonás",
            "Eugenio", "Santiago", "Mauro", "Marco", "Octavio", "Ramón", "Adrián", "Gonzalo", "Nicolás", "Sergio",
            "Víctor Manuel", "Joaquín", "Mario", "Jaime", "Sergio", "Adrián", "Eduardo", "Nelson", "Julián", "Agustín",
            "Simón", "Claudio", "Felipe", "Francisco Javier",
            "María", "Carmen", "Isabel", "Ana", "Laura", "Francisco", "María Dolores", "María Teresa", "Juana", "Sofía",
            "Pilar", "Teresa", "María Isabel", "Elena", "Dolores", "Marta", "Rosa", "María Jesús", "Beatriz", "Patricia",
            "Lourdes", "María Pilar", "Andrea", "María José", "Carolina", "Natalia", "María Fernanda", "Inés", "Clara",
            "Gabriela", "Mariana", "Silvia", "María Luisa", "Alicia", "Paula", "Adriana", "Carmen María", "Julia", "Eugenia",
            "Verónica", "Rosario", "Mariana", "Lorena", "Jimena", "Vanessa", "Marta", "Teresa", "Paula", "Nuria", "Emilia",
            "Silvia", "Susana", "Julia", "Celia", "Valeria", "Ana María", "Gabriela", "Teresa", "Marcela", "Angélica",
            "Lourdes", "Gloria", "Isabel", "Natalia", "Sandra", "Susana", "Mercedes", "Carla", "Adriana", "Miriam", "Claudia",
            "Paloma", "Sofía", "Blanca", "Magdalena", "Andrea", "Lorena", "Fabiola", "Alejandra", "Mariana", "Cecilia",
            "Gabriela", "Mónica", "Amelia", "Rosa María", "Yolanda", "Juana María", "Nora", "Camila", "Elvira", "Marta",
            "Raquel", "Verónica", "Lorena", "Paula", "Marisol", "Alicia", "Marta", "Laura", "Isabel"
        };
        private static string[] LastNames = new string[]
        {
            "García", "Rodríguez", "González", "Fernández", "López", "Pérez", "Martínez", "Sánchez", "Romero", "Ruiz",
            "Hernández", "Jiménez", "Mendoza", "Moreno", "Torres", "Vázquez", "Ramos", "Castro", "Gutiérrez", "Márquez",
            "Ortega", "Morales", "Vega", "Cruz", "Alvarez", "Reyes", "Paredes", "Salazar", "Córdoba", "Bermúdez", "Muñoz",
            "Henao", "Jaramillo", "Lozano", "Gómez", "Velázquez", "Rivera", "Moya", "Serrano", "Cardenas", "Bravo", "Arrieta",
            "Barrios", "Acosta", "Serrano", "Gallego", "Ospina", "Jaramillo", "Trujillo", "Chávez", "Bermúdez", "Lara",
            "Rojas", "Villarreal", "Ríos", "Palacios", "Cano", "Rincón", "Díaz", "Arévalo", "García", "Vargas", "Bermúdez",
            "Sosa", "Sánchez", "Suárez", "Cárdenas", "Navarro", "Aranda", "López", "Valencia", "Correa", "Gómez", "Mendoza",
            "Mora", "Pinto", "Guzmán", "Duran", "Márquez", "Galvis", "Medina", "Arias", "Vásquez", "Núñez", "Henao",
            "García", "Hurtado", "Villegas", "Salazar", "Ayala", "López", "Figueroa", "Ortega", "Pérez", "Martínez", "Jurado",
            "Ochoa", "Bautista", "Téllez", "Alonso", "García", "Hernández", "Mendoza", "Ortiz", "Agudelo", "Múnera",
            "Uribe", "Martínez", "Herrera", "Pérez", "Carvajal", "Murillo", "Piedrahita", "Ocampo", "Hernández", "Gómez",
            "García", "Sánchez", "López", "Zapata", "Cruz", "Rodríguez", "García", "Córdoba", "Morales", "Lozano",
            "Suárez", "Márquez", "Tovar", "Villalba", "Quintero", "Herrera", "Castaño", "García", "Gómez", "Melo",
            "García", "Montoya", "Arias", "Salazar", "González", "Arango", "Ramírez", "Aristizábal", "Vélez", "Díaz",
            "Álvarez", "Montoya", "García", "Serna", "Pérez", "Rincón", "González", "Ríos", "Zapata", "García",
            "Hernández", "Ramírez", "Arrieta", "Rodríguez", "García", "Gómez", "Álvarez", "López", "Ospina", "Mendoza",
            "Jaramillo", "García", "Téllez", "Cardenas", "Gómez", "Barreto", "Vásquez", "Gómez", "Hurtado", "Romero"
        };
        private static string[] Colors = new string[]
        {
            "#FFFFFF", // White
            "#000000", // Black
            "#FF0000", // Red
            "#00FF00", // Green
            "#0000FF", // Blue
            "#FFFF00", // Yellow
            "#FF00FF", // Magenta
            "#00FFFF", // Cyan
            "#C0C0C0", // Silver
            "#808080", // Gray
            "#800000", // Maroon
            "#808000", // Olive
            "#008000", // Dark Green
            "#800080", // Purple
            "#008080", // Teal
            "#000080", // Navy
            "#F0F8FF", // Alice Blue
            "#FAEBD7", // Antique White
            "#00FA9A", // Medium Spring Green
            "#FF4500"  // Orange Red
        };
        private static string[] InsuranceTypes = new string[]
        {
            "Liability Insurance",
            "Bodily Injury Liability",
            "Property Damage Liability",
            "Collision Insurance",
            "Collision Coverage",
            "Comprehensive Insurance",
            "Comprehensive Coverage",
            "Personal Injury Protection (PIP)",
            "Uninsured Motorist Coverage",
            "Underinsured Motorist Coverage",
            "Medical Payments Coverage (MedPay)",
            "Roadside Assistance",
            "Rental Reimbursement",
            "Gap Insurance",
            "Extended Warranty"
        };
        private static InsuranceStatus[] insuranceStatuses = new InsuranceStatus[]
        {
            InsuranceStatus.Active,
            InsuranceStatus.Expired,
            InsuranceStatus.Pending,
            InsuranceStatus.Cancelled,
            InsuranceStatus.Suspended,
            InsuranceStatus.Lapsed,
            InsuranceStatus.UnderReview,
            InsuranceStatus.InForce
        };
        private static List<User> users = new();
        private static List<Car> cars = new();
        private static List<Insurance> insurances = new();

        public static void Main(string[] args)
        {
            PopulateUsers(TotalRecords);
            PopulateCars(TotalRecords);
            PopulateInsurances(TotalRecords);
            WriteFile(users, "users.txt");
            WriteFile(cars, "cars.txt");
            WriteFile(insurances, "insurances.txt");            
            Console.WriteLine("done!");
        }

        private static void WriteFile(List<User> userList, string filePath)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("[");
            int i = 0;
            var user = userList[i];
            builder.AppendLine("{");
            builder.AppendLine($"\"Id\": \"{user.Id}\",");
            builder.AppendLine($"\"FirstName\": \"{user.FirstName}\",");
            builder.AppendLine($"\"LastName\": \"{user.LastName}\",");
            builder.AppendLine($"\"Email\": \"{user.Email}\",");
            builder.AppendLine($"\"PasswordHash\": \"{user.PasswordHash}\",");
            builder.AppendLine($"\"LastModified\": \"new DateTime({user.LastModified!.Value.Year}, {user.LastModified!.Value.Month}, {user.LastModified!.Value.Day})\",");
            builder.AppendLine($"\"IsDeleted\": \"{user.IsDeleted}\",");
            builder.AppendLine($"\"LastDeleted\": \"new DateTime({user.LastDeleted!.Value.Year}, {user.LastDeleted!.Value.Month}, {user.LastDeleted!.Value.Day})\"");
            builder.AppendLine("}");
            for (i = 1; i < userList.Count; i++)
            {
                user = userList[i];
                builder.AppendLine(",{");
                builder.AppendLine($"\"Id\": \"{user.Id}\",");
                builder.AppendLine($"\"FirstName\": \"{user.FirstName}\",");
                builder.AppendLine($"\"LastName\": \"{user.LastName}\",");
                builder.AppendLine($"\"Email\": \"{user.Email}\",");
                builder.AppendLine($"\"PasswordHash\": \"{user.PasswordHash}\",");
                builder.AppendLine($"\"LastModified\": \"new DateTime({user.LastModified!.Value.Year}, {user.LastModified!.Value.Month}, {user.LastModified!.Value.Day})\",");
                builder.AppendLine($"\"IsDeleted\": \"{user.IsDeleted}\",");
                builder.AppendLine($"\"LastDeleted\": \"new DateTime({user.LastDeleted!.Value.Year}, {user.LastDeleted!.Value.Month}, {user.LastDeleted!.Value.Day})\"");
                builder.AppendLine("}");
            }
            builder.AppendLine("]");
            File.WriteAllText(filePath, builder.ToString());
        }

        private static void WriteFile(List<Car> carList, string filePath)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("[");
            int i = 0;
            var car = carList[i];
            builder.AppendLine("{");
            builder.AppendLine($"\"Id\": \"{car.Id}\",");
            builder.AppendLine($"\"Model\": \"{car.Model}\",");
            builder.AppendLine($"\"Color\": \"{car.Color}\",");
            builder.AppendLine($"\"Price\": \"{car.Price}\",");
            builder.AppendLine($"\"PlateNumber\": \"{car.PlateNumber}\",");
            builder.AppendLine($"\"LastModified\": \"new DateTime({car.LastModified!.Value.Year}, {car.LastModified!.Value.Month}, {car.LastModified!.Value.Day})\",");
            builder.AppendLine($"\"IsDeleted\": \"{car.IsDeleted}\",");
            builder.AppendLine($"\"LastDeleted\": \"new DateTime({car.LastDeleted!.Value.Year}, {car.LastDeleted!.Value.Month}, {car.LastDeleted!.Value.Day})\"");
            builder.AppendLine("}");
            for (i = 1; i < carList.Count; i++)
            {
                car = carList[i];
                builder.AppendLine(",{");
                builder.AppendLine($"\"Id\": \"{car.Id}\",");
                builder.AppendLine($"\"Model\": \"{car.Model}\",");
                builder.AppendLine($"\"Color\": \"{car.Color}\",");
                builder.AppendLine($"\"Price\": \"{car.Price}\",");
                builder.AppendLine($"\"PlateNumber\": \"{car.PlateNumber}\",");
                builder.AppendLine($"\"LastModified\": \"new DateTime({car.LastModified!.Value.Year}, {car.LastModified!.Value.Month}, {car.LastModified!.Value.Day})\",");
                builder.AppendLine($"\"IsDeleted\": \"{car.IsDeleted}\",");
                builder.AppendLine($"\"LastDeleted\": \"new DateTime({car.LastDeleted!.Value.Year}, {car.LastDeleted!.Value.Month}, {car.LastDeleted!.Value.Day})\"");
                builder.AppendLine("}");
            }
            builder.AppendLine("]");
            File.WriteAllText(filePath, builder.ToString());
        }

        private static void WriteFile(List<Insurance> insuranceList, string filePath)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("[");
            int i = 0;
            var insurance = insuranceList[i];
            builder.AppendLine("{");
            builder.AppendLine($"\"Id\": \"{insurance.Id}\",");
            builder.AppendLine($"\"UserId\": \"{insurance.UserId}\",");
            builder.AppendLine($"\"CarId\": \"{insurance.CarId}\",");
            builder.AppendLine($"\"StartDate\": \"new DateTime({insurance.StartDate!.Value.Year}, {insurance.StartDate!.Value.Month}, {insurance.StartDate!.Value.Day})\",");
            builder.AppendLine($"\"EndDate\": \"new DateTime({insurance.EndDate!.Value.Year}, {insurance.EndDate!.Value.Month}, {insurance.EndDate!.Value.Day})\",");
            builder.AppendLine($"\"TypeOfInsurance\": \"{insurance.TypeOfInsurance}\",");
            builder.AppendLine($"\"Premium\": \"{insurance.Premium}\",");
            builder.AppendLine($"\"Status\": \"{InsuranceStatusToString(insurance.Status)}\",");
            builder.AppendLine($"\"LastModified\": \"new DateTime({insurance.LastModified!.Value.Year}, {insurance.LastModified!.Value.Month}, {insurance.LastModified!.Value.Day})\",");
            builder.AppendLine($"\"IsDeleted\": \"{insurance.IsDeleted}\",");
            builder.AppendLine($"\"LastDeleted\": \"new DateTime({insurance.LastDeleted!.Value.Year}, {insurance.LastDeleted!.Value.Month}, {insurance.LastDeleted!.Value.Day})\"");
            builder.AppendLine("}");
            for (i = 1; i < insuranceList.Count; i++)
            {
                insurance = insuranceList[i];
                builder.AppendLine(",{");
                builder.AppendLine($"\"Id\": \"{insurance.Id}\",");
                builder.AppendLine($"\"UserId\": \"{insurance.UserId}\",");
                builder.AppendLine($"\"CarId\": \"{insurance.CarId}\",");
                builder.AppendLine($"\"StartDate\": \"new DateTime({insurance.StartDate!.Value.Year}, {insurance.StartDate!.Value.Month}, {insurance.StartDate!.Value.Day})\",");
                builder.AppendLine($"\"EndDate\": \"new DateTime({insurance.EndDate!.Value.Year}, {insurance.EndDate!.Value.Month}, {insurance.EndDate!.Value.Day})\",");
                builder.AppendLine($"\"TypeOfInsurance\": \"{insurance.TypeOfInsurance}\",");
                builder.AppendLine($"\"Premium\": \"{insurance.Premium}\",");
                builder.AppendLine($"\"Status\": \"{InsuranceStatusToString(insurance.Status)}\",");
                builder.AppendLine($"\"LastModified\": \"new DateTime({insurance.LastModified!.Value.Year}, {insurance.LastModified!.Value.Month}, {insurance.LastModified!.Value.Day})\",");
                builder.AppendLine($"\"IsDeleted\": \"{insurance.IsDeleted}\",");
                builder.AppendLine($"\"LastDeleted\": \"new DateTime({insurance.LastDeleted!.Value.Year}, {insurance.LastDeleted!.Value.Month}, {insurance.LastDeleted!.Value.Day})\"");
                builder.AppendLine("}");
            }
            builder.AppendLine("]");
            File.WriteAllText(filePath, builder.ToString());
        }

        private static string InsuranceStatusToString(InsuranceStatus status)
        {
            string result = status switch
            {
                InsuranceStatus.Active => "InsuranceStatus.Active",
                InsuranceStatus.Expired => "InsuranceStatus.Expired",
                InsuranceStatus.Pending => "InsuranceStatus.Pending",
                InsuranceStatus.Cancelled => "InsuranceStatus.Cancelled",
                InsuranceStatus.Suspended => "InsuranceStatus.Suspended",
                InsuranceStatus.Lapsed => "InsuranceStatus.Lapsed",
                InsuranceStatus.UnderReview => "InsuranceStatus.UnderReview",
                InsuranceStatus.InForce => "InsuranceStatus.InForce",
                _ => "Unknown"
            };
            return result;
        }

        private static void PopulateInsurances(int count)
        {
            for (int i = 0; i < count; i++)
            {
                insurances.Add(GetRandomInsurance());
            }
        }

        private static void PopulateCars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                cars.Add(GetRandomCar());
            }
        }

        private static void PopulateUsers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                users.Add(GetRandomUser());
            }
        }

        private static void PrintInsurance(Insurance insurance)
        {
            Console.WriteLine(insurance.Id);
            Console.WriteLine(insurance.UserId);
            Console.WriteLine(insurance.CarId);
            Console.WriteLine(insurance.StartDate);
            Console.WriteLine(insurance.EndDate);
            Console.WriteLine(insurance.TypeOfInsurance);
            Console.WriteLine(insurance.Premium);
            Console.WriteLine(insurance.Status);
            Console.WriteLine(insurance.LastModified);
            Console.WriteLine(insurance.IsDeleted);
            Console.WriteLine(insurance.LastDeleted);
            Console.WriteLine("");
        }

        private static void PrintCar(Car car)
        {
            Console.WriteLine(car.Id);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Color);
            Console.WriteLine(car.Price);
            Console.WriteLine(car.PlateNumber);
            Console.WriteLine(car.LastModified);
            Console.WriteLine(car.IsDeleted);
            Console.WriteLine(car.LastDeleted);
            Console.WriteLine("");
        }

        private static void PrintUser(User user)
        {
            Console.WriteLine(user.Id);
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.LastName);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.PasswordHash);
            Console.WriteLine(user.LastModified);
            Console.WriteLine(user.IsDeleted);
            Console.WriteLine(user.LastDeleted);
            Console.WriteLine("");
        }

        private static string GetSha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                var hash = new StringBuilder();
                byte[] hashArray = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                foreach (byte b in hashArray)
                {
                    hash.Append(b.ToString("x"));
                }
                return hash.ToString();
            }
        }

        private static T GetRandomValue<T>(T[] array)
        {
            int index = Random.Next(0, array.Length - 1);
            return array[index];
        }

        private static T GetRandomValueFromList<T>(List<T> list)
        {
            int index = Random.Next(0, list.Count - 1);
            return list[index];
        }

        private static string GetRandomEmail()
        {
            Guid randomGuid = Guid.NewGuid();
            string guidString = randomGuid.ToString();
            return $"{guidString}@gmail.com";
        }

        private static string GetRandomPlateNumber()
        {
            Guid randomGuid = Guid.NewGuid();
            string guidString = randomGuid.ToString();
            return guidString;
        }

        private static decimal GetRandomDecimal(decimal minValue, decimal maxValue)
        {
            double randomDouble = Random.NextDouble();
            decimal randomDecimal = (decimal)randomDouble;
            decimal scaledRandomDecimal = minValue + (randomDecimal * (maxValue - minValue));
            return scaledRandomDecimal;
        }

        private static DateTime GetRandomDateTime(DateTime start, DateTime end)
        {
            // Generate a random number of days between the start and end dates
            TimeSpan timeSpan = end - start;
            int randomDays = Random.Next(0, timeSpan.Days);

            // Generate a random DateTime by adding random days to the start date
            DateTime randomDateTime = start.AddDays(randomDays);

            // Optionally, add random hours, minutes, and seconds
            int randomHours = Random.Next(0, 24);
            int randomMinutes = Random.Next(0, 60);
            int randomSeconds = Random.Next(0, 60);

            randomDateTime = randomDateTime
                .AddHours(randomHours)
                .AddMinutes(randomMinutes)
                .AddSeconds(randomSeconds);
            return randomDateTime;
        }

        private static Insurance GetRandomInsurance()
        {
            InsuranceId++;
            var startDate = GetRandomDateTime(new DateTime(1990, 1, 1), DateTime.UtcNow);
            var endDate = startDate.AddDays(365);
            return new Insurance()
            {
                Id = InsuranceId,
                UserId = GetRandomValueFromList(users).Id,
                CarId = GetRandomValueFromList(cars).Id,
                StartDate = startDate,
                EndDate = endDate,
                TypeOfInsurance = GetRandomValue(InsuranceTypes),
                Premium = GetRandomDecimal(2000.0m, 10000.0m),
                Status = GetRandomValue(insuranceStatuses),
                LastModified = DateTime.UtcNow,
                IsDeleted = false,
                LastDeleted = DateTime.UtcNow
            };
        }

        private static Car GetRandomCar()
        {
            CarId++;
            return new Car()
            {
                Id = CarId,
                Model = $"{Random.Next(1990, 2024)}",
                Color = GetRandomValue(Colors),
                Price = GetRandomDecimal(50000.0m, 1000000.0m),
                PlateNumber = GetRandomPlateNumber(),
                LastModified = DateTime.UtcNow,
                IsDeleted = false,
                LastDeleted = DateTime.UtcNow
            };
        }

        private static User GetRandomUser()
        {
            UserId++;
            return new User()
            {
                Id = UserId,
                FirstName = GetRandomValue(Names),
                LastName = GetRandomValue(LastNames),
                Email = GetRandomEmail(),
                PasswordHash = GetSha256("12345"),
                LastModified = DateTime.UtcNow,
                IsDeleted = false,
                LastDeleted = DateTime.UtcNow
            };
        }
    }
}