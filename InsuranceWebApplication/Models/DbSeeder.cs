using InsuranceWebApplication.Enums;

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
                        FirstName = "Adrián",
                        LastName = "Vega",
                        Email = "bb2730d7-3797-4e83-8b8f-45b943ac340e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Hurtado",
                        Email = "ddb837d2-d4da-4c9a-9040-c0c7b3a7268a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Luis",
                        LastName = "Trujillo",
                        Email = "a3047347-d94b-4b00-ab64-b2fdf9c97d07@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María",
                        LastName = "Serrano",
                        Email = "fdd16603-fa62-407c-a8db-7c29df490a58@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nuria",
                        LastName = "Ochoa",
                        Email = "56cda595-8c72-4292-a638-324c19f43744@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María José",
                        LastName = "Ruiz",
                        Email = "84bf9434-cc6c-45be-931c-80f08f7a208c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nora",
                        LastName = "Hernández",
                        Email = "45d42959-a3d0-4768-958f-27c2076e87e9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Gómez",
                        Email = "bc866703-f4c5-49d5-863f-5488654691cc@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Uribe",
                        Email = "00401d8e-fb92-447f-b0c7-be5828eb78d8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alberto",
                        LastName = "Hernández",
                        Email = "62f30c58-278b-44e8-ad16-84210fee5f4a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ricardo",
                        LastName = "Lara",
                        Email = "bb48bb0f-c63b-4372-8cb6-24ec99dcd8cc@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Valencia",
                        Email = "0fee0e46-21b1-4c50-8185-9db5ecf742f3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Pilar",
                        LastName = "García",
                        Email = "06d81ef0-5137-4327-8f86-f808406d8120@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Simón",
                        LastName = "Ospina",
                        Email = "80cc62df-73b2-4091-bd6d-45c3e2e39875@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Tomás",
                        LastName = "Martínez",
                        Email = "e56c78ac-fca3-4f9f-aaaf-34b95414d54c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adriana",
                        LastName = "Márquez",
                        Email = "fd481117-936c-4c13-ab36-ba7f4ac91b6d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Javier Luis",
                        LastName = "Rincón",
                        Email = "0d649daa-8313-438a-bdd8-43d659be1952@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marisol",
                        LastName = "Hernández",
                        Email = "ac620244-a54e-420c-a1a4-b5e467a23701@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alfonso",
                        LastName = "Rodríguez",
                        Email = "65122e02-b74d-4473-bca8-c1558750a647@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Lorena",
                        LastName = "Cruz",
                        Email = "84a23994-5b58-40ae-9407-ab1b99780344@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Hugo",
                        LastName = "García",
                        Email = "f72d378e-1ce9-4949-8483-4c06e930fba5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Navarro",
                        Email = "0c3ff70c-dbb1-4261-aaee-4df7f0f5c4e8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María",
                        LastName = "Vélez",
                        Email = "528496f4-ab9e-4992-96c3-fed537ede245@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jonás",
                        LastName = "Montoya",
                        Email = "b48c3c92-5097-400f-8f48-5e1e50a13413@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Ríos",
                        Email = "c06ccfd8-9530-4873-b419-500ca9ff8c3e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Clara",
                        LastName = "Guzmán",
                        Email = "643b701d-3e05-4545-b7ec-71021f05e798@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "García",
                        Email = "003f76b2-6ab7-49e4-a942-090a62236cca@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Luisa",
                        LastName = "González",
                        Email = "e136aaf2-4882-4990-b7e0-7dc985f40c16@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Arango",
                        Email = "0e5eebba-c86c-4ea1-8709-e9f43d861d85@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "López",
                        Email = "b640a66e-38d5-4e79-8e47-bcb9b56d606d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rubén",
                        LastName = "Zapata",
                        Email = "b3496718-93a7-4a9a-8250-686616699d17@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eduardo",
                        LastName = "Reyes",
                        Email = "73ef82e9-696c-49aa-a602-28aee9dd4ed9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Santiago",
                        LastName = "Márquez",
                        Email = "0bd30b6a-a596-45e7-b5d6-1103da5b9680@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrea",
                        LastName = "González",
                        Email = "4a51d2cd-de53-4a4e-a12c-182318a3690a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Fernanda",
                        LastName = "Vélez",
                        Email = "8af3b4c3-0728-4b44-900c-bbc1c8e4d1f8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alicia",
                        LastName = "Ospina",
                        Email = "0a094469-8dd1-4298-aa5f-c7d9eb48f80c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mario",
                        LastName = "Gómez",
                        Email = "f9bac0e1-1749-4550-a594-8e4d2ba68e75@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrés",
                        LastName = "Martínez",
                        Email = "1a9416fc-a79f-4ca2-8338-bf4f53570f0c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Felipe",
                        LastName = "Zapata",
                        Email = "90da1a82-aeee-4e87-9523-8841b7010309@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrea",
                        LastName = "Gallego",
                        Email = "29a908bc-a3fc-4eb2-9d3a-00d08f97e955@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco",
                        LastName = "Guzmán",
                        Email = "8b55a302-1c7f-4d69-8ff6-bfbc4f655f49@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Joaquín",
                        LastName = "Rivera",
                        Email = "eaaf3db7-1cf4-465b-a51f-794a1479887a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Jaramillo",
                        Email = "d1ee1142-ef7f-449d-ab9b-d4816811c83b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rafael",
                        LastName = "Moya",
                        Email = "a3d0477c-4ee0-466c-b174-7ab8d90d0be3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Daniel",
                        LastName = "Herrera",
                        Email = "445286b7-66d0-4c4d-b627-dea76cc105e2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Natalia",
                        LastName = "Romero",
                        Email = "346b8b81-d32d-4585-8153-82f69a51e129@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Miguel",
                        LastName = "Rojas",
                        Email = "626532d3-f953-4408-8d81-0950b768637a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julián",
                        LastName = "Ayala",
                        Email = "542b3cb3-9f14-4c4c-85d1-3aaa3d7da837@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Jesús",
                        LastName = "García",
                        Email = "d840180a-7612-4203-903a-1b3988155f91@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Martín",
                        LastName = "Gómez",
                        Email = "fc678bba-c73e-4103-af05-a4add8690535@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Lorena",
                        LastName = "Rodríguez",
                        Email = "4a4a23aa-90a7-4b34-acd9-2d95c0ff0dde@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rosario",
                        LastName = "Guzmán",
                        Email = "e6206ee8-d8eb-4f6d-85d7-b1f914194ab8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Patricia",
                        LastName = "Hernández",
                        Email = "cec1d314-0104-442a-a6d0-2dee372cf940@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alan",
                        LastName = "Ríos",
                        Email = "77b48873-1dff-4609-873b-c0202fa53e29@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rodrigo",
                        LastName = "Ortiz",
                        Email = "9eeb0c42-f655-487a-8289-d6629cfb0018@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Agustín",
                        LastName = "Serna",
                        Email = "5d73e24a-c79d-4b4c-a7c8-d17d20c2017d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Rodríguez",
                        Email = "d3bbebf8-33ff-4773-9390-966d5c3806c2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Lorena",
                        LastName = "Álvarez",
                        Email = "26315337-77a9-4036-a807-24579c9a9746@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Pérez",
                        Email = "d4a147af-4f9d-4061-94dc-8338aef92081@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Benjamín",
                        LastName = "Vega",
                        Email = "651cc2bb-d4a9-4c88-a752-d285ef7ceed3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana",
                        LastName = "Alonso",
                        Email = "bf02f549-21f9-439d-9cf5-3dbd680bc8f9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Sergio",
                        LastName = "Díaz",
                        Email = "a6a8be92-f243-471c-bc10-7778ec8cf419@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Pedro",
                        LastName = "García",
                        Email = "48db06f1-b9ba-49f0-9b04-f3051b3878bb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Herrera",
                        Email = "959ca441-df3e-4bbf-956e-2c691fbcc7b5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Guillermo",
                        LastName = "Ramos",
                        Email = "011afed3-fe4c-4f12-960a-cd81f73a5570@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Claudio",
                        LastName = "Hurtado",
                        Email = "207d96ba-1ac4-499b-91d9-274044410a25@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana",
                        LastName = "Chávez",
                        Email = "6ab28973-03e0-4560-9811-c3803356930f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Teresa",
                        LastName = "Hurtado",
                        Email = "f58839a9-f421-4110-9f45-5c92523efa0d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Cecilia",
                        LastName = "Paredes",
                        Email = "0dd4f164-888a-4550-9525-7052ce94b158@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juan",
                        LastName = "Melo",
                        Email = "28538d4d-dcdc-4a7d-b43f-b3e1338f4a81@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Ríos",
                        Email = "2e487fdf-b8c5-4842-a203-08d9d8495c3c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mario",
                        LastName = "Bravo",
                        Email = "77b496a9-29c3-44e2-b356-bf617dfb42b6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Patricia",
                        LastName = "Ruiz",
                        Email = "25254351-0f7a-4feb-b5c4-b5cf1003c702@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mario",
                        LastName = "Villarreal",
                        Email = "8e646383-698b-4f5a-b149-9edba2ef9a50@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Agustín",
                        LastName = "Vázquez",
                        Email = "f083c6d6-ea38-4e5c-9b15-db6ea4f2c2af@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Sánchez",
                        Email = "55f68ba8-a08f-4877-88ec-0a222559bdf0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gloria",
                        LastName = "Agudelo",
                        Email = "dbf43411-d3bf-4f68-ad26-d4adbd76d33c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ana",
                        LastName = "Arévalo",
                        Email = "5e189474-5e18-47fd-a99e-67f95eba7391@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jesús",
                        LastName = "Jaramillo",
                        Email = "4a68d545-64b4-4287-be3b-bdbad4cba948@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "Henao",
                        Email = "4639baa7-f1f2-42c0-acfa-624778d15018@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Álvarez",
                        Email = "1167a1a2-e5e5-4fbc-987c-ca8cb88c6a17@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adrián",
                        LastName = "Trujillo",
                        Email = "8279ea7c-b7b2-459c-b6a5-7df1052ee046@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juan",
                        LastName = "Vásquez",
                        Email = "451bd237-44bd-4a7f-93a8-4c7c31269fad@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Fabián",
                        LastName = "Vega",
                        Email = "93249950-61cc-4cbb-a9bb-26ced62ba47b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Samuel",
                        LastName = "Gómez",
                        Email = "ffcc729c-dfaf-41c1-a90d-c4e541d989a4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Felipe",
                        LastName = "García",
                        Email = "82ab258e-7e4e-42fc-a2f4-8ab8bc695fec@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Jiménez",
                        Email = "02f5922c-5721-4e87-a7d1-cbf031999b6a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alberto",
                        LastName = "García",
                        Email = "5d929d20-6368-47f6-b547-134002747765@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Paredes",
                        Email = "e24810c6-b99a-4e46-89af-81ca0f810dff@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Antonio",
                        LastName = "Rodríguez",
                        Email = "360a3767-6986-4b7c-b993-822935e71185@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Teresa",
                        LastName = "Arango",
                        Email = "f1a74b2a-1370-4904-8082-ededf7b8ba05@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Lozano",
                        Email = "e71f6445-f4bc-4175-869b-2c7624bc8a1c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Fernanda",
                        LastName = "Cárdenas",
                        Email = "52c64ab9-bb7e-49c5-8bdf-190fa43f1eb8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor Manuel",
                        LastName = "Mendoza",
                        Email = "0f346dc9-c891-4fcb-b5e0-8b41ae042506@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco",
                        LastName = "Mora",
                        Email = "613ccf67-6ee9-4d22-9182-15657fe2f6c6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Figueroa",
                        Email = "55bb7448-cefd-49ab-91a0-fac426ed1827@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Laura",
                        LastName = "Suárez",
                        Email = "5e93222f-a599-4fa9-ad47-b04f81f489ea@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Antonio",
                        LastName = "Gómez",
                        Email = "2f5e107c-466d-4c6c-8afa-77a152371430@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrea",
                        LastName = "Guzmán",
                        Email = "c794c95f-2752-429e-800f-e3fa824a4dec@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ramón",
                        LastName = "Medina",
                        Email = "3d76e3a4-fdd2-4696-8614-0c47e38fa362@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Rodríguez",
                        Email = "480d1068-1748-4321-92fb-5b9207295405@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Guillermo",
                        LastName = "Pérez",
                        Email = "8c0fad8c-f3ae-4b9f-8bd6-196dde54999f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eugenia",
                        LastName = "Jurado",
                        Email = "e5d5f5c9-9bfe-48e0-bac9-c536661b4d01@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Gómez",
                        Email = "7716aaac-c80a-4cb2-91e5-a24047ba0013@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Elena",
                        LastName = "García",
                        Email = "40eb04f6-6504-449b-a187-e3ab9fb3c1fb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mónica",
                        LastName = "Márquez",
                        Email = "91c8ab1a-0f33-4ab0-b865-26ad774d8e5a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alan",
                        LastName = "Bautista",
                        Email = "c54ee271-bcef-4ce2-a87b-b482e3ff6819@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Guillermo",
                        LastName = "Hurtado",
                        Email = "af7c8b79-4180-48a3-bd8c-021e28b78b6c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Hugo",
                        LastName = "García",
                        Email = "dfea83c5-fa90-496f-a7de-5c47baffa615@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Sergio",
                        LastName = "Gutiérrez",
                        Email = "ce11d63a-fc47-436c-8a8b-65ac8226e95d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rosario",
                        LastName = "Díaz",
                        Email = "e3e713e2-b633-4934-afea-5ff726fc6606@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Rincón",
                        Email = "12097c48-731b-4d7f-af93-a91021b30345@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julián",
                        LastName = "Hernández",
                        Email = "9b522d4d-2d8e-40de-9deb-fa581b056ee9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Silvia",
                        LastName = "Bermúdez",
                        Email = "8a34497b-fbd4-4213-8f90-9cbeea184655@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adriana",
                        LastName = "Ocampo",
                        Email = "c6254ac1-14c9-4551-b2d0-9176c5b60fb5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Mendoza",
                        Email = "4a12173c-4085-4857-92ba-a4ce6a8fd199@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Daniel",
                        LastName = "Cardenas",
                        Email = "1a0c9dff-f3a7-4373-991b-3233e408998f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Federico",
                        LastName = "Velázquez",
                        Email = "84c9dc06-98a3-4c0d-8aa2-eba69587426a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Arango",
                        Email = "949878f0-7fa8-4f73-acd1-61fdbf91168f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Cardenas",
                        Email = "287eab24-1a00-466a-8e96-5a4f3123dc92@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "Sánchez",
                        Email = "3ca02b41-db74-4746-8e5f-69d743b51249@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Angélica",
                        LastName = "Rodríguez",
                        Email = "ba08a730-e7c0-4536-846b-ab28a0119bbb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jaime",
                        LastName = "Murillo",
                        Email = "5984000f-d9dd-4165-bfba-0645ab3a7294@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Laura",
                        LastName = "Guzmán",
                        Email = "1955be26-91fb-4ab0-b9d3-52b6bdf9967d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Carmen",
                        LastName = "Jaramillo",
                        Email = "e35fc54b-8ead-4150-a25e-d5186261c270@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Luis Miguel",
                        LastName = "Ospina",
                        Email = "d43c300f-3bca-42e7-9b77-471edc7a6463@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Natalia",
                        LastName = "García",
                        Email = "10dc41de-b79d-46c2-a3eb-b50bdf896e02@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Suárez",
                        Email = "bc06dceb-7f24-4efc-b77a-4edfc3265f08@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Inés",
                        LastName = "Ochoa",
                        Email = "e5869a8d-067e-4674-8e6c-c4bef447040f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Cruz",
                        Email = "0d923420-69d7-443c-83f2-fc1763f543d4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eduardo",
                        LastName = "Ramos",
                        Email = "4376a571-0aaa-40a7-b2a2-3e6ff0766094@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Moisés",
                        LastName = "Salazar",
                        Email = "d1514cf8-d6ed-404e-afc0-9c20e705f917@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Fernanda",
                        LastName = "Fernández",
                        Email = "284e7994-1539-4f6a-904a-33be57deaf47@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Núñez",
                        Email = "611e0c86-57bc-4d23-812f-49e812c33885@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Cruz",
                        Email = "0d508e26-7546-4d07-b64c-856d94be9608@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Hugo",
                        LastName = "Márquez",
                        Email = "73b6445e-d54b-4ab0-b99d-37743e9b2852@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marcos",
                        LastName = "Morales",
                        Email = "0775189c-a135-4a11-b0a3-a14779f52bde@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana María",
                        LastName = "Medina",
                        Email = "ec1c5020-edc8-4a77-ade0-ce0b1033be2b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Carmen María",
                        LastName = "García",
                        Email = "f1f6c1ed-bafa-4a16-add3-d00afd7d552e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adrián",
                        LastName = "Medina",
                        Email = "386a818b-85fd-406b-883e-b977b499d0b9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Luis Miguel",
                        LastName = "Bautista",
                        Email = "e4231f06-787d-442f-967e-c1839d021f7b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco",
                        LastName = "García",
                        Email = "448bf123-9969-46d6-8823-8eaf304f8c98@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Manuel",
                        LastName = "Alvarez",
                        Email = "c919a0cd-5f27-4e33-9d74-e4def43f0d44@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandro",
                        LastName = "Ríos",
                        Email = "2208e58a-3f5e-4b71-98eb-a83e42c9eadd@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Tomás",
                        LastName = "Gómez",
                        Email = "bddc9a1b-1a75-4478-901a-edfd6d3f6de3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Paula",
                        LastName = "Vega",
                        Email = "ce9287cb-0483-413e-b3c9-477a98bdf1ae@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Gómez",
                        Email = "94ebc27a-d042-4b20-814d-ab8720bd4e1b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Manuel Jesús",
                        LastName = "Alvarez",
                        Email = "7f6d162e-3c0c-4c7b-ac75-da501c67c7d0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Velázquez",
                        Email = "06feb174-0dfd-4ec3-9098-b8cf42f565e4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Hernández",
                        Email = "17255b4b-e60e-4d0a-bfe7-8684e472c3a0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Angélica",
                        LastName = "Aristizábal",
                        Email = "77961293-0c00-45e7-91ef-c836b7cf3cfc@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana",
                        LastName = "Bermúdez",
                        Email = "099a16ce-d991-401a-ad3f-e5a0b40bd394@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Palacios",
                        Email = "bb4dea5d-fd8e-41e7-85fa-099a18157326@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Salazar",
                        Email = "64cd42e4-330b-44ca-b369-511d6f2e3514@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "Romero",
                        Email = "99ca9f5d-9c5d-4a26-a0b4-2b4f0426ec52@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Silvia",
                        LastName = "López",
                        Email = "f4579f2c-ca34-4b1b-a883-4b334f60f530@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Serrano",
                        Email = "8e1e0ae1-c7ab-4d93-ad20-2e8247a8d686@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Vargas",
                        Email = "46059a7e-6596-4c1e-8713-6f047e73dfee@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Carmen",
                        LastName = "Correa",
                        Email = "1f7b21a5-3bba-45bb-9178-54c2bad45def@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Silvia",
                        LastName = "García",
                        Email = "9ed92eab-4233-41f3-aff4-72dd325755cb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Patricia",
                        LastName = "Rincón",
                        Email = "bd94dd7d-4037-4ec4-9c42-1a70f3fce5be@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Emilia",
                        LastName = "Bravo",
                        Email = "941777ba-6fdf-4223-9b6e-958e413aa02a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Raquel",
                        LastName = "Rojas",
                        Email = "9a09dbf0-5d20-4ea6-a88b-34e7b69e13dd@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Guzmán",
                        Email = "9251c1e9-cfc9-4860-b959-545278a4b7d4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Martín",
                        LastName = "Reyes",
                        Email = "bd33adcb-042b-4084-9570-a5208f35f590@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eduardo",
                        LastName = "Pérez",
                        Email = "60da0da5-eae0-4c6f-a0f7-51379df673c1@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor Manuel",
                        LastName = "López",
                        Email = "231d48c3-9806-47b9-8930-fba871f568d6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "González",
                        Email = "85818d47-4265-4eff-bfa1-e23876d2a2ca@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Torres",
                        Email = "298aca03-78c4-4989-a4bf-f6859528bdf1@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Samuel",
                        LastName = "Palacios",
                        Email = "a49ac508-1a9f-4633-b07f-aabc99406682@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Zapata",
                        Email = "cb74aef0-2d80-43c7-93b4-e087755860e2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Cardenas",
                        Email = "f05a3edc-828d-4f2f-aeb6-278d8075156c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Pilar",
                        LastName = "Guzmán",
                        Email = "88c5defe-b569-45f7-88ff-fe3928333c1a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Fabiola",
                        LastName = "González",
                        Email = "efa32a6b-161e-4b01-ac21-dcd3a0cd9fef@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ramón",
                        LastName = "Mendoza",
                        Email = "ef7e66c5-92b7-49a9-8ccc-c9b5c2052f53@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "García",
                        Email = "455db3e9-66df-438d-aba4-f2a67770665a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Manuel Jesús",
                        LastName = "Márquez",
                        Email = "29b661d7-606b-45d2-8b30-a1051321d239@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Emilia",
                        LastName = "Pérez",
                        Email = "e2c2b182-5d8f-4465-82fd-ca1b6a808fbe@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rosario",
                        LastName = "Alonso",
                        Email = "7448e016-7736-43f2-a523-9ceb0f2a355c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Herrera",
                        Email = "8239ae46-3a9f-46eb-83f6-4eb6a02f8f59@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor",
                        LastName = "Ospina",
                        Email = "b66a4d25-f346-46fb-a5c2-a3703fb99865@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Chávez",
                        Email = "07f27b3c-6be0-45c7-8f93-1953399ce315@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor",
                        LastName = "Zapata",
                        Email = "ff981b6f-72d2-4ff1-9b9a-082baf28372c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Octavio",
                        LastName = "Bravo",
                        Email = "ae67fe4a-01ec-4f92-91eb-c9153f5a5815@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Montoya",
                        Email = "e1ff83e0-b42b-47b5-9f4e-730c13d7f3d0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Bermúdez",
                        Email = "e3767946-ab32-40f9-8f03-9b7d54fc42b2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ángel Luis",
                        LastName = "Núñez",
                        Email = "0911c243-8bf0-4973-9cea-916b511273fa@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jaime",
                        LastName = "Gallego",
                        Email = "3bf91b97-905e-4794-8835-9040dd2f1641@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adriana",
                        LastName = "Villarreal",
                        Email = "e0f2fc88-0e1c-440f-91fe-2bcc6973ee2e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alberto",
                        LastName = "Ayala",
                        Email = "6b062522-e306-4078-8cb1-5cddf9003d6f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Gómez",
                        Email = "2f4fcca8-cf91-42a5-af52-23b5258fd2d1@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Sánchez",
                        Email = "71e89cbe-0c17-45cf-a2e9-753a219dc22c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Pedro",
                        LastName = "Serna",
                        Email = "a7d98ae5-b17f-4c83-8250-662c7988d6d5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Luisa",
                        LastName = "Rincón",
                        Email = "5f5f22e9-a802-4278-aa52-2f37bd3da2b5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Javier Luis",
                        LastName = "Serna",
                        Email = "58a4f927-175b-437b-bfd8-b22eb07364c3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Agustín",
                        LastName = "Alvarez",
                        Email = "13535bc3-baf7-4e73-901c-0ed23beaf11c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Salazar",
                        Email = "8294d7fd-6ad6-4df8-8c6d-1c296e621518@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Jesús",
                        LastName = "Gómez",
                        Email = "990abfe8-16c5-4e4c-8d7c-e66f4a09dd51@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco José",
                        LastName = "Vega",
                        Email = "8476196f-f152-46df-bd6d-ab5010bc1bf6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Santiago",
                        LastName = "Trujillo",
                        Email = "6edf08e1-a5cf-4807-a233-92087f623301@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
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
                        Model = "2007",
                        Color = "#C0C0C0",
                        Price = 116757.41620677166500000m,
                        PlateNumber = "51fd1b09-0e94-4d80-b7da-bdbd8aa21288",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#0000FF",
                        Price = 985554.7694941524500000m,
                        PlateNumber = "a24557d2-d420-4f26-9256-02db99348495",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#0000FF",
                        Price = 529591.9879954729000000m,
                        PlateNumber = "e348b127-a5cc-418a-bb35-83dcc959aca6",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#000000",
                        Price = 344282.0425267286500000m,
                        PlateNumber = "fe898396-ca5d-44ae-9c5f-c3496c6af307",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2009",
                        Color = "#000000",
                        Price = 618760.0498560178000000m,
                        PlateNumber = "97cd277f-69d5-4e1c-bf02-9c6df93cec90",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2011",
                        Color = "#FAEBD7",
                        Price = 783106.9111875643000000m,
                        PlateNumber = "85bf454b-eed3-4793-ac84-153407f0546c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#0000FF",
                        Price = 562017.4735489094500000m,
                        PlateNumber = "97097221-032e-40bd-b92f-94f1ef671051",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#FAEBD7",
                        Price = 709346.2699616182000000m,
                        PlateNumber = "6c73c9ff-6cdb-424f-b8f3-9df424a3b6d7",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#F0F8FF",
                        Price = 643155.5517040589500000m,
                        PlateNumber = "102bdfbf-5552-45ee-bf5a-5de16f922916",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#008000",
                        Price = 448670.3798580354500000m,
                        PlateNumber = "c5871467-0e99-4b67-8ed5-3c5e9d8311ee",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#0000FF",
                        Price = 682999.5063050001500000m,
                        PlateNumber = "c0d22a89-423a-400e-bbea-cd05b5bdac82",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1996",
                        Color = "#C0C0C0",
                        Price = 756464.565826162000000m,
                        PlateNumber = "3e07725f-74b0-4a9f-acf6-6146df57271e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#800000",
                        Price = 351599.7573199442000000m,
                        PlateNumber = "5c31ad32-6db3-475e-8e4b-289946cf4309",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1994",
                        Color = "#008000",
                        Price = 787509.6242573949000000m,
                        PlateNumber = "bdfa64d7-c211-4cd1-9393-d53a3083aa1d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2016",
                        Color = "#00FF00",
                        Price = 340948.0828361953000000m,
                        PlateNumber = "1e1e8b35-ce26-4f0e-bf13-74788967f5d1",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#800000",
                        Price = 174965.0014968733000000m,
                        PlateNumber = "6ef064a3-1d27-4824-a079-e4a2fe927610",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2016",
                        Color = "#0000FF",
                        Price = 545850.52283368500000m,
                        PlateNumber = "e379c140-b65d-467e-b9b9-ff46626b4ee9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#800080",
                        Price = 78143.92227623798000000m,
                        PlateNumber = "25dd2b28-a076-4db6-b4aa-e3c7a2fb11f3",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2005",
                        Color = "#FFFF00",
                        Price = 509799.1079439323500000m,
                        PlateNumber = "0dab538f-7e5b-4d11-87d7-9e199b3de7ef",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#008080",
                        Price = 410089.3251460671500000m,
                        PlateNumber = "e0deca5e-b267-4cac-8d1c-3e0f60445a5e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2022",
                        Color = "#FF0000",
                        Price = 553042.6118071543500000m,
                        PlateNumber = "a235b5f3-0868-41be-a08b-e4551fbf66ba",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2011",
                        Color = "#FAEBD7",
                        Price = 872187.5420393093000000m,
                        PlateNumber = "8728319a-83d3-4803-8354-fef9a2df89d0",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#F0F8FF",
                        Price = 94857.45139203364000000m,
                        PlateNumber = "97181ca2-0ab8-4ea5-b85e-0451e08a3a1d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#00FFFF",
                        Price = 348928.3944404921500000m,
                        PlateNumber = "63c9f3e4-1f14-4dd2-86d2-5f67c039b653",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2003",
                        Color = "#000080",
                        Price = 343067.5705653721500000m,
                        PlateNumber = "f98ea196-668e-4313-9169-ddc65cd87a16",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2009",
                        Color = "#800000",
                        Price = 566208.243019639500000m,
                        PlateNumber = "10bbe435-9829-40b7-83d1-27b4cad61dbd",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#00FFFF",
                        Price = 505079.9581936099000000m,
                        PlateNumber = "6b0c8c97-69d1-422f-a01a-4a9b3c3a1b64",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1999",
                        Color = "#FF00FF",
                        Price = 395277.8125176420500000m,
                        PlateNumber = "e12e8253-5630-4105-9da7-4dc8ce6e4de0",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#000000",
                        Price = 772475.0215721050500000m,
                        PlateNumber = "aab2e65d-8f86-4d6a-adda-05cb093e95d2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#808080",
                        Price = 914669.0564892181500000m,
                        PlateNumber = "397387c3-0995-4d86-a9a5-c81349a8c0fb",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#008000",
                        Price = 279405.9986242233000000m,
                        PlateNumber = "f67aa237-5ad9-44b3-aeb7-b5b791cfc01c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#008080",
                        Price = 214395.8353182119500000m,
                        PlateNumber = "07f9e254-ac60-49e8-92b5-163113e5ee24",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#FFFFFF",
                        Price = 176057.4786734320500000m,
                        PlateNumber = "00b40176-3211-4b3b-beed-eaee256d233a",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#008000",
                        Price = 198539.2666682165500000m,
                        PlateNumber = "04e2a76d-ff8b-4b3d-a903-48a0ba02d7f7",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#808000",
                        Price = 210265.8830638664000000m,
                        PlateNumber = "f1e443c2-206f-4b94-aaf1-c154ce3677b8",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#00FFFF",
                        Price = 546916.0729784684500000m,
                        PlateNumber = "ebe023b8-37e1-437f-b135-ba9d60df0d79",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#000000",
                        Price = 172863.5896495734000000m,
                        PlateNumber = "c67f6369-b17f-46ae-9e4d-6a98a6be094b",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2012",
                        Color = "#008080",
                        Price = 437901.6989909647000000m,
                        PlateNumber = "a4537430-4855-45ba-b15f-30923b581e22",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1990",
                        Color = "#00FA9A",
                        Price = 867561.3238772675500000m,
                        PlateNumber = "11813f66-c5b8-41be-9dd8-69755554b25d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2003",
                        Color = "#FAEBD7",
                        Price = 740203.2409534442500000m,
                        PlateNumber = "62dda72d-438e-40db-9838-e33cf44a95cb",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2006",
                        Color = "#00FF00",
                        Price = 710336.2353246487000000m,
                        PlateNumber = "c8ed791b-72fe-4b25-8504-8aa1c9c98ab9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#008000",
                        Price = 320707.0555127852000000m,
                        PlateNumber = "0371f164-a3f3-4391-96ec-38ecd06a2284",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#F0F8FF",
                        Price = 206374.0580269511500000m,
                        PlateNumber = "44a021ae-856f-41c1-8d1a-3341616e4fef",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#FF00FF",
                        Price = 114629.95182420066500000m,
                        PlateNumber = "8397b3ce-fc21-419c-b7d3-256bc470d7a5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2009",
                        Color = "#FF0000",
                        Price = 746867.7753650684000000m,
                        PlateNumber = "7f6676b9-c077-4bf7-8c6b-2dd2e12d2de7",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#00FFFF",
                        Price = 753838.8874586273000000m,
                        PlateNumber = "46f7834e-608a-4858-8186-9c3c15fd9eb7",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2002",
                        Color = "#808000",
                        Price = 98174.19699207569000000m,
                        PlateNumber = "1d9b9d8d-09ee-495a-bf61-74b34921bef8",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1990",
                        Color = "#FFFF00",
                        Price = 103575.80299370344000000m,
                        PlateNumber = "de5ef325-f4da-4246-bf48-bf6aececde93",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#F0F8FF",
                        Price = 728825.1484026793000000m,
                        PlateNumber = "3eadf073-e635-45e2-a262-180454323543",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#FFFF00",
                        Price = 441361.0754539931500000m,
                        PlateNumber = "db843520-1de2-4290-bfc9-e06350945b65",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2022",
                        Color = "#800080",
                        Price = 835322.7529233357500000m,
                        PlateNumber = "f400f8f5-4240-415a-9a9e-fea06fc378b9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2004",
                        Color = "#FAEBD7",
                        Price = 257467.1461774094500000m,
                        PlateNumber = "d2d7592f-5e72-417e-b75c-ca192fd396c0",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#00FFFF",
                        Price = 263930.5802439502000000m,
                        PlateNumber = "d20e4473-e189-4945-92d1-b7c75f7217ab",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#008000",
                        Price = 250760.2670309697500000m,
                        PlateNumber = "621644ba-1a49-4506-a190-f2ff73da53a2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#00FFFF",
                        Price = 827732.7952199088500000m,
                        PlateNumber = "7c17a67b-62c9-4786-8060-b1ab951f9b8b",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#800000",
                        Price = 867154.1636552318500000m,
                        PlateNumber = "dad46526-8de6-4073-9192-060568a19e9d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2012",
                        Color = "#FFFF00",
                        Price = 862783.6561250259500000m,
                        PlateNumber = "7f1a6ae5-f111-441b-b424-2b74f34fa42e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#800080",
                        Price = 114495.45616304904500000m,
                        PlateNumber = "d7056d87-894b-438e-9186-78bdc464737e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#000000",
                        Price = 274392.4995846178500000m,
                        PlateNumber = "6c6f51fb-32be-464a-81cd-0dc96e8d3541",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2006",
                        Color = "#800080",
                        Price = 744272.2394329323500000m,
                        PlateNumber = "5e94619e-4f97-470c-9522-952d7fbe9679",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#FF00FF",
                        Price = 701409.7633582269000000m,
                        PlateNumber = "2ad626fb-dedd-43e8-869b-754130c6940f",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1996",
                        Color = "#FFFFFF",
                        Price = 581871.3222658905500000m,
                        PlateNumber = "bf5c198e-904a-4cab-a3fa-a9b53e565cba",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2003",
                        Color = "#800000",
                        Price = 555980.8680355851000000m,
                        PlateNumber = "f38d9f51-bd77-440e-be35-d1835aa42387",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#808000",
                        Price = 898246.0068783938000000m,
                        PlateNumber = "2daf2263-8210-470d-a967-2919a7e48b86",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#808000",
                        Price = 939874.3344217013000000m,
                        PlateNumber = "2be186ed-e333-47d3-a80a-33975f8b5aec",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1996",
                        Color = "#FF0000",
                        Price = 601831.0154922929000000m,
                        PlateNumber = "7f1151c9-8414-45a8-acd6-6fa6d7f7a960",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#FF00FF",
                        Price = 235594.8538889656000000m,
                        PlateNumber = "9d5a9d7a-5a74-45f3-822b-7aa235ee5a4e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#008080",
                        Price = 785316.4698221806500000m,
                        PlateNumber = "c79487b7-ac00-451e-a496-1c7ba1ba2730",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1991",
                        Color = "#800000",
                        Price = 388549.6754092957000000m,
                        PlateNumber = "36757102-636a-4461-bd69-e2f0faf9d073",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1996",
                        Color = "#008080",
                        Price = 714368.7238553858500000m,
                        PlateNumber = "85ae8e6f-a731-490b-953d-28e79c2a08ee",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#FF00FF",
                        Price = 302087.2697013964000000m,
                        PlateNumber = "87eb0a93-aedf-44b7-a163-2ad4e59dca64",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#0000FF",
                        Price = 891274.1234146031500000m,
                        PlateNumber = "e9291fc2-3ced-47fe-8411-f3a4a7dead44",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#FFFF00",
                        Price = 746061.51408415500000m,
                        PlateNumber = "dfe6002b-a609-4f5e-825d-7db630119b16",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2005",
                        Color = "#00FFFF",
                        Price = 549546.1430088769000000m,
                        PlateNumber = "8bd63746-4c6a-40c0-b31f-e43241ac930d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1991",
                        Color = "#FFFFFF",
                        Price = 930158.521286776000000m,
                        PlateNumber = "0c855663-bae0-4d30-abd2-45be62016829",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#008000",
                        Price = 181993.5557872238500000m,
                        PlateNumber = "9cd971c7-2ae0-4150-976f-f5b4e0122f5a",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2007",
                        Color = "#808080",
                        Price = 349529.4875892192000000m,
                        PlateNumber = "35a2b2f4-b725-4cc9-aaaf-01245656b0a1",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2022",
                        Color = "#800080",
                        Price = 534391.4928273288000000m,
                        PlateNumber = "78852dee-e8ab-45b6-a0a6-f9c69db26138",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#00FFFF",
                        Price = 510067.8481029022000000m,
                        PlateNumber = "389c4b2d-39bd-407d-8a06-0f3a5f1af801",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#008080",
                        Price = 242170.5900908329500000m,
                        PlateNumber = "fab6f232-7f13-49c9-b29e-7b8d7c2b6545",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1990",
                        Color = "#008080",
                        Price = 871566.3571960587500000m,
                        PlateNumber = "78ab19eb-48d7-4fe3-9c52-f015065e1dcc",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2007",
                        Color = "#F0F8FF",
                        Price = 473069.8933498610500000m,
                        PlateNumber = "2e1d1aca-b21b-4be5-9c2b-12065e9d83cf",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2002",
                        Color = "#C0C0C0",
                        Price = 796440.5948699277500000m,
                        PlateNumber = "03acb584-17b4-4061-a3e3-6b648d7ba763",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2011",
                        Color = "#000080",
                        Price = 327611.5995849039000000m,
                        PlateNumber = "aa842dfc-97c9-4d41-a058-9536664e18a7",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2022",
                        Color = "#0000FF",
                        Price = 600944.9876745471500000m,
                        PlateNumber = "5b1938d9-9010-446c-8550-508599bbba0c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#000000",
                        Price = 971056.0824786282000000m,
                        PlateNumber = "5afa3259-3f01-494d-8d93-f6ca941ce4f6",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#808080",
                        Price = 663166.791814643000000m,
                        PlateNumber = "87298069-e72d-413b-aba1-2248500add5d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#000000",
                        Price = 730871.6607304723000000m,
                        PlateNumber = "c7e95a0b-5f80-4fff-a9c9-d06f005f9901",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2011",
                        Color = "#008000",
                        Price = 166352.4658154378000000m,
                        PlateNumber = "72eaa709-2b76-42df-aad4-9ee07eeb0900",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2007",
                        Color = "#800000",
                        Price = 936968.5082284716000000m,
                        PlateNumber = "e9f83cf1-e6ab-4094-bc04-15b0d8a5ffea",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2021",
                        Color = "#C0C0C0",
                        Price = 789712.736033651000000m,
                        PlateNumber = "0f118037-61cc-4332-b46f-787cdc4f71ae",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#808080",
                        Price = 735240.360293651500000m,
                        PlateNumber = "fc818f46-88a6-454d-b84d-9c38ab18ca01",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#00FFFF",
                        Price = 536176.4109341595500000m,
                        PlateNumber = "5da6b1ab-e107-49b6-8d12-5c058fa31e7f",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#FFFF00",
                        Price = 870407.3178862196500000m,
                        PlateNumber = "dc26f6f3-bbbf-4a58-8e2a-defc833f63de",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#000080",
                        Price = 175581.0668059442000000m,
                        PlateNumber = "f56a7cac-c1e0-4df5-8c50-244413543f4e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#FF00FF",
                        Price = 719533.2500201531500000m,
                        PlateNumber = "b543d33d-9dd4-47d5-8b48-0e802be13163",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#00FFFF",
                        Price = 740801.6576238038000000m,
                        PlateNumber = "c0fec430-5bec-43c8-ace2-ff95ccc1dbd2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#800080",
                        Price = 363805.3185334515500000m,
                        PlateNumber = "e7ed6974-8787-4ee8-842a-88b8b88f4caa",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2007",
                        Color = "#00FA9A",
                        Price = 934469.1494204099000000m,
                        PlateNumber = "e4083d3a-ff57-4281-a5df-0d6c722ac93c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1990",
                        Color = "#808080",
                        Price = 679205.0625860646500000m,
                        PlateNumber = "db08aee8-b680-4240-bf71-18e3a2acc950",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2021",
                        Color = "#008080",
                        Price = 693352.985801189500000m,
                        PlateNumber = "b77379ca-102d-4c99-9db4-c5ce3aa68c08",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#FF00FF",
                        Price = 506293.1748592139000000m,
                        PlateNumber = "2de02ecc-fd6f-459c-a40d-c49379d49143",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2009",
                        Color = "#00FA9A",
                        Price = 347046.0990574766000000m,
                        PlateNumber = "50366eb9-504c-47bc-8f88-2efcb893de91",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2012",
                        Color = "#00FA9A",
                        Price = 540781.5313039773500000m,
                        PlateNumber = "7c407079-608d-4f8b-b349-9a4747da93e9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1991",
                        Color = "#00FA9A",
                        Price = 266864.5945690281500000m,
                        PlateNumber = "fea76262-eaf2-4850-931e-094bad9508d3",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#000080",
                        Price = 214929.6266487199000000m,
                        PlateNumber = "d955effa-5e16-4214-a095-765c145a350e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2011",
                        Color = "#808000",
                        Price = 214723.664769551500000m,
                        PlateNumber = "91c8691d-70ab-4db9-8ffe-5ee9d8a0b3be",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#0000FF",
                        Price = 189655.617363072000000m,
                        PlateNumber = "dfc6a2c3-bbff-4adb-a906-5cd4e8841479",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#FF00FF",
                        Price = 715177.2505260915500000m,
                        PlateNumber = "6eb911ed-cfdf-4003-807c-9fdb4daa5fdd",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#808080",
                        Price = 252506.9241586274500000m,
                        PlateNumber = "842a76f9-1e5d-4a74-8002-766e93506f27",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1994",
                        Color = "#008000",
                        Price = 851389.5275417738500000m,
                        PlateNumber = "76931241-1d35-4a11-9434-8712eb36ea56",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#00FFFF",
                        Price = 642188.7282921471500000m,
                        PlateNumber = "350f8255-829f-46da-9e48-73005ffbff33",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#808080",
                        Price = 844533.6060443267000000m,
                        PlateNumber = "fb3bb4ac-b292-481b-884d-89163960eaa6",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#808000",
                        Price = 370790.1034005419000000m,
                        PlateNumber = "c41d7b27-76ce-4a82-9ffb-15c7f63643e8",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#800080",
                        Price = 518366.3567564657500000m,
                        PlateNumber = "9ef04ccc-7563-4504-9244-71f57502b064",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1996",
                        Color = "#FF00FF",
                        Price = 682581.3295124426000000m,
                        PlateNumber = "e0d64677-356f-49e3-ae87-b66f4524d2aa",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#FFFFFF",
                        Price = 486251.3360626782000000m,
                        PlateNumber = "63c0aeff-314c-43d0-afea-29798d30b7bc",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#C0C0C0",
                        Price = 523585.1139289044000000m,
                        PlateNumber = "185ca864-5fc3-45f5-96d4-57fc2ed75305",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#008000",
                        Price = 934749.3368748029500000m,
                        PlateNumber = "4dd699ab-fab9-46b1-a34b-6cc50016d99c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2007",
                        Color = "#C0C0C0",
                        Price = 792594.288969012500000m,
                        PlateNumber = "969c90cd-0bd7-4e8b-a687-aee871ac0d9c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#808000",
                        Price = 617916.3880614457000000m,
                        PlateNumber = "46402868-45e7-4ea2-956f-2f032eef9b57",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#000080",
                        Price = 525922.2304821643000000m,
                        PlateNumber = "c2fad541-afbe-4a86-aada-c6cb906edf92",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#800080",
                        Price = 255381.8236953449500000m,
                        PlateNumber = "2ff39a70-c104-4801-8c97-42b3128663cf",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#00FA9A",
                        Price = 324440.0454081676500000m,
                        PlateNumber = "7ec025a0-31a6-402c-af15-5504dc46e6d1",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#F0F8FF",
                        Price = 82846.85026908610500000m,
                        PlateNumber = "cf73cbd7-cefb-4959-b09b-62a735790454",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2013",
                        Color = "#FF0000",
                        Price = 980831.5734956970500000m,
                        PlateNumber = "6033d007-f9bc-4f1a-bdd2-075f6dc87e56",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1991",
                        Color = "#00FFFF",
                        Price = 79684.49263569931500000m,
                        PlateNumber = "5e217325-a869-45bb-870d-cb6e4927906c",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1990",
                        Color = "#800000",
                        Price = 472371.2596443366500000m,
                        PlateNumber = "65453d48-37a8-432b-919f-c237bcc77132",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#FF00FF",
                        Price = 333948.3228386849000000m,
                        PlateNumber = "9045749b-3694-4a2c-b686-6c6fb5ac7da1",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#008000",
                        Price = 266885.0919454213000000m,
                        PlateNumber = "9ce97286-1409-476a-b9e3-d86fa67206df",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#008080",
                        Price = 696225.4584148058000000m,
                        PlateNumber = "86974663-e39f-4481-b424-05eb7e39267d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#00FFFF",
                        Price = 636474.2468910046500000m,
                        PlateNumber = "e63c5c03-2797-4b23-b7cd-165e79bd5808",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#000080",
                        Price = 203958.6174087934000000m,
                        PlateNumber = "d3469a7d-a227-4ced-a422-0279fb65dad8",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#008080",
                        Price = 483266.8791470662500000m,
                        PlateNumber = "bc9ef6c9-5015-4ca6-aff0-23aa093898a3",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#FF0000",
                        Price = 815602.1047169152500000m,
                        PlateNumber = "a197e094-4f1c-462b-a42b-dc12728641a4",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#0000FF",
                        Price = 570539.541146862000000m,
                        PlateNumber = "599f0f81-b342-4edf-97dd-c961404083da",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2005",
                        Color = "#000080",
                        Price = 331886.7043074756000000m,
                        PlateNumber = "072a89a1-969d-471c-9003-b71e65621d92",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2003",
                        Color = "#000080",
                        Price = 83679.85546433366500000m,
                        PlateNumber = "8927e0f0-0fa7-4789-8a98-5f3651f34205",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2013",
                        Color = "#800000",
                        Price = 842937.1668479466500000m,
                        PlateNumber = "54bf1903-756f-479d-81e7-4654b4128bac",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#000000",
                        Price = 99464.86644299953500000m,
                        PlateNumber = "b34e6251-a417-44a6-81be-ba3a09695164",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1996",
                        Color = "#C0C0C0",
                        Price = 502752.2880357792000000m,
                        PlateNumber = "b535bd6b-a3f0-48aa-b3d3-454a3c2e0301",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2012",
                        Color = "#808080",
                        Price = 559649.0665261009000000m,
                        PlateNumber = "c5ce0378-1238-46b7-8d61-fec98dfb67f0",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2019",
                        Color = "#0000FF",
                        Price = 121186.68075472260500000m,
                        PlateNumber = "ac741853-793d-4ab8-bb12-78eb8f93ecae",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#808080",
                        Price = 305700.7418961985500000m,
                        PlateNumber = "ae83e15f-7652-4093-a048-40c134cc1f09",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1999",
                        Color = "#800080",
                        Price = 370497.8002503973000000m,
                        PlateNumber = "40b9c197-e6d1-4c60-aca9-e46b0991f98f",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#FFFF00",
                        Price = 156712.650127606000000m,
                        PlateNumber = "f5c96e04-c4d7-4f86-acff-44161f636dea",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2005",
                        Color = "#000000",
                        Price = 968876.3501538717500000m,
                        PlateNumber = "aa255b58-6989-4fc8-950e-78e0c6d6b1fd",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#FF0000",
                        Price = 276440.9349228387000000m,
                        PlateNumber = "99474c45-c1e1-41f2-9c67-2f6a87d2ad8b",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2004",
                        Color = "#C0C0C0",
                        Price = 296369.6085882303000000m,
                        PlateNumber = "26d93cdb-80d3-480c-afe4-aa8bf0f2f4da",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2022",
                        Color = "#00FF00",
                        Price = 385780.6495175076500000m,
                        PlateNumber = "1d21c08b-5a5c-40e5-8b9e-36a4275460f9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2021",
                        Color = "#FF00FF",
                        Price = 198985.7710978917500000m,
                        PlateNumber = "1af06409-1a61-4b1b-9dff-63a66cf39148",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#808000",
                        Price = 423702.7531750067000000m,
                        PlateNumber = "5cdcd158-039d-4194-9bfa-866fb583f5e2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#008080",
                        Price = 346641.1804259785500000m,
                        PlateNumber = "9f92b591-8819-4ffc-a325-fee331e5ab4a",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2021",
                        Color = "#00FFFF",
                        Price = 839424.5464787026500000m,
                        PlateNumber = "51f4e12e-3b74-46bb-ac16-7da84eead7cd",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#C0C0C0",
                        Price = 260513.7823645434000000m,
                        PlateNumber = "c4fed68b-0637-4df1-a3ad-9962dfc62254",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#800000",
                        Price = 362616.0479474039000000m,
                        PlateNumber = "5f838b76-314e-40e4-a313-653e957b280d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1991",
                        Color = "#008000",
                        Price = 854592.3267130730500000m,
                        PlateNumber = "080b6979-383c-4819-b2ff-dd94d91e48ac",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#FF0000",
                        Price = 749655.1837057037000000m,
                        PlateNumber = "6e288a10-e044-4a18-b93c-5808d036e9d9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#FAEBD7",
                        Price = 119292.25204756588500000m,
                        PlateNumber = "307a0fd6-c662-4759-92ca-436e910ef1ed",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#FF0000",
                        Price = 67268.33597621971000000m,
                        PlateNumber = "e3f8d2b8-0f84-4432-8fbf-591ef3cd23e4",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1999",
                        Color = "#FFFFFF",
                        Price = 888348.1157218850500000m,
                        PlateNumber = "ad2999a1-226d-4ec0-a86f-5005d47e9418",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2013",
                        Color = "#FFFF00",
                        Price = 706656.7733272658000000m,
                        PlateNumber = "1378ebc7-6bb7-4415-90e6-7db541293477",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1997",
                        Color = "#FF00FF",
                        Price = 375954.6136606163000000m,
                        PlateNumber = "2b21ed8e-82a4-4fcc-88e5-367d889f28d1",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#00FFFF",
                        Price = 708779.7429940524500000m,
                        PlateNumber = "96808cd9-55c1-455d-822d-d550e942264a",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2003",
                        Color = "#FF00FF",
                        Price = 506441.4242636323500000m,
                        PlateNumber = "ead35a90-3196-42c3-9e74-380f3fe4a65b",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1993",
                        Color = "#000000",
                        Price = 933962.1555821121000000m,
                        PlateNumber = "2454d785-befa-4bb4-af98-026eef9390ef",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2006",
                        Color = "#00FFFF",
                        Price = 540173.3481574474000000m,
                        PlateNumber = "14d1cc84-4f7e-4f08-a8cd-a859e3d7a891",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#808080",
                        Price = 180960.4782621552500000m,
                        PlateNumber = "119cc70e-76a6-47ac-96d1-3f84f1d91065",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#00FA9A",
                        Price = 361436.5343843635500000m,
                        PlateNumber = "1cc45d05-f536-4750-b8e0-70b358a7a9f2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#FF00FF",
                        Price = 260074.7121823167000000m,
                        PlateNumber = "216585f5-8057-453a-b53c-62e15e2eb1f8",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#C0C0C0",
                        Price = 661708.5326472598500000m,
                        PlateNumber = "998011c7-ff3f-44f6-b1c8-614ec69a396e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1992",
                        Color = "#00FFFF",
                        Price = 868906.9278169483500000m,
                        PlateNumber = "bab2e715-ff85-47a1-bb11-5bc2d52a2076",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#00FF00",
                        Price = 640842.1383209556500000m,
                        PlateNumber = "8bccfd56-5f07-4630-bb63-4a6784823d13",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2008",
                        Color = "#800000",
                        Price = 189123.7683024882000000m,
                        PlateNumber = "4d5c139f-0a26-491f-b361-a69ff05ab3b9",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2010",
                        Color = "#008080",
                        Price = 99212.02893111722500000m,
                        PlateNumber = "a77b0663-70cc-4779-884b-0121771baba2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2006",
                        Color = "#808080",
                        Price = 952455.7957018926500000m,
                        PlateNumber = "62e249dd-05eb-45cd-81ec-b75b88af98f2",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#000000",
                        Price = 649743.4694102023000000m,
                        PlateNumber = "dfcdba90-aafd-427f-83a4-7b71cd148f44",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2012",
                        Color = "#00FA9A",
                        Price = 260466.8183935352000000m,
                        PlateNumber = "4d752703-fd28-4d71-8e2e-8082a8a38c72",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1994",
                        Color = "#FF0000",
                        Price = 835166.5163167592500000m,
                        PlateNumber = "0618a753-a01b-4940-83a1-aad053c78e6e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2004",
                        Color = "#FFFF00",
                        Price = 276871.1264918640500000m,
                        PlateNumber = "ce854efc-6d1e-4785-bc43-ba9f5b6646cf",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#FAEBD7",
                        Price = 967449.9525856119500000m,
                        PlateNumber = "ee48e09e-52e7-4a6d-b047-42332eeee834",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2006",
                        Color = "#00FFFF",
                        Price = 756637.4623732141000000m,
                        PlateNumber = "52a2cfb9-43ad-4070-b0ad-f76f13c3647b",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2000",
                        Color = "#000080",
                        Price = 888267.1887015830500000m,
                        PlateNumber = "d8698ed8-fde6-4ca8-b53d-4c2376d7a8f7",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2005",
                        Color = "#00FF00",
                        Price = 91652.86373116719500000m,
                        PlateNumber = "50e3cd38-13bc-43d3-a48f-13b6c2ad51ef",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#FF0000",
                        Price = 711415.0511319215500000m,
                        PlateNumber = "44af5ca5-0603-401c-9533-e9fca200b08e",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2001",
                        Color = "#00FF00",
                        Price = 203890.547277548000000m,
                        PlateNumber = "ff65e166-50a0-4987-a2cd-63fea5fbd7aa",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2012",
                        Color = "#FFFF00",
                        Price = 200226.6798277298000000m,
                        PlateNumber = "ba863cfd-411a-449e-a7b7-3515bc9bf3c6",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2007",
                        Color = "#00FFFF",
                        Price = 101205.46269372821500000m,
                        PlateNumber = "897d46ef-d623-4823-a3ab-f86ea300f39b",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#000080",
                        Price = 293987.9020963587000000m,
                        PlateNumber = "957c4b38-1a70-48ae-a1cd-19ab5fb17773",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2015",
                        Color = "#800080",
                        Price = 804608.57847389000000m,
                        PlateNumber = "87949960-9448-414c-9341-f23fb8e91f04",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2014",
                        Color = "#000000",
                        Price = 453777.6607430114500000m,
                        PlateNumber = "b25d1f98-bdbe-4374-9baa-bba56b8d0051",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1995",
                        Color = "#00FF00",
                        Price = 162599.2845247912500000m,
                        PlateNumber = "2c9caaf3-ca58-4832-9d7e-5bc8d0a7f8ac",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#0000FF",
                        Price = 570912.1056784678000000m,
                        PlateNumber = "6cdc789d-2c29-4094-88ad-39278747fa3d",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2016",
                        Color = "#00FA9A",
                        Price = 299773.4459942494000000m,
                        PlateNumber = "138a92a8-3a32-4e2b-a65f-0b4320ac60d5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2023",
                        Color = "#FAEBD7",
                        Price = 630988.8135261970500000m,
                        PlateNumber = "a096be65-7204-44e7-a0c3-1d7bd6cdd662",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2018",
                        Color = "#800000",
                        Price = 392502.8720452148500000m,
                        PlateNumber = "7d484496-ecfb-42a1-bf6f-3aa7fcd23ab1",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#F0F8FF",
                        Price = 108126.98015784487000000m,
                        PlateNumber = "187545bc-1eb8-4220-bc40-ad4ed4b56d40",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2020",
                        Color = "#800000",
                        Price = 277427.1794097494500000m,
                        PlateNumber = "ffd2f6f0-3ab5-42d3-a0e2-1cb8caa3ad35",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "2017",
                        Color = "#FF0000",
                        Price = 967462.0746262757500000m,
                        PlateNumber = "7143df8d-9577-4745-8539-c394a66c2d58",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Car()
                    {
                        Model = "1998",
                        Color = "#800000",
                        Price = 917522.9258951446500000m,
                        PlateNumber = "797aa095-9dd8-4056-acb4-15c8abfaeef0",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
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
                        UserId = 193,
                        CarId = 123,
                        StartDate = new DateTime(2021, 6, 24),
                        EndDate = new DateTime(2022, 6, 24),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 5420.3280978410560000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 142,
                        CarId = 174,
                        StartDate = new DateTime(1990, 5, 21),
                        EndDate = new DateTime(1991, 5, 21),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 2253.95447751161360000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 70,
                        CarId = 142,
                        StartDate = new DateTime(2016, 10, 14),
                        EndDate = new DateTime(2017, 10, 14),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 3680.2336533095440000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 134,
                        CarId = 99,
                        StartDate = new DateTime(1998, 8, 29),
                        EndDate = new DateTime(1999, 8, 29),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 8068.5661734972240000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 36,
                        CarId = 61,
                        StartDate = new DateTime(2023, 11, 27),
                        EndDate = new DateTime(2024, 11, 26),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 8356.1550748886960000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 175,
                        CarId = 13,
                        StartDate = new DateTime(2022, 1, 26),
                        EndDate = new DateTime(2023, 1, 26),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 3529.3791371555680000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 34,
                        CarId = 147,
                        StartDate = new DateTime(2019, 7, 29),
                        EndDate = new DateTime(2020, 7, 28),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 7272.7165205039520000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 111,
                        CarId = 67,
                        StartDate = new DateTime(2003, 2, 15),
                        EndDate = new DateTime(2004, 2, 15),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 6871.4158693610640000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 51,
                        CarId = 132,
                        StartDate = new DateTime(2005, 1, 29),
                        EndDate = new DateTime(2006, 1, 29),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 2804.3532754158160000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 153,
                        CarId = 98,
                        StartDate = new DateTime(2013, 3, 6),
                        EndDate = new DateTime(2014, 3, 6),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 6313.7531311260080000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 52,
                        CarId = 79,
                        StartDate = new DateTime(2004, 2, 8),
                        EndDate = new DateTime(2005, 2, 7),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 5772.9616718499680000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 41,
                        CarId = 26,
                        StartDate = new DateTime(2010, 11, 6),
                        EndDate = new DateTime(2011, 11, 6),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 2288.87061030143120000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 113,
                        CarId = 80,
                        StartDate = new DateTime(1997, 7, 5),
                        EndDate = new DateTime(1998, 7, 5),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 8088.3287923441520000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 169,
                        CarId = 116,
                        StartDate = new DateTime(1994, 7, 12),
                        EndDate = new DateTime(1995, 7, 12),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 2681.83071183555120000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 2,
                        CarId = 53,
                        StartDate = new DateTime(2024, 7, 21),
                        EndDate = new DateTime(2025, 7, 21),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 9018.3021667359680000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 13,
                        CarId = 47,
                        StartDate = new DateTime(2024, 1, 17),
                        EndDate = new DateTime(2025, 1, 16),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 7748.2551925936560000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 113,
                        CarId = 92,
                        StartDate = new DateTime(1995, 9, 7),
                        EndDate = new DateTime(1996, 9, 6),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 5288.2778389723280000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 30,
                        CarId = 45,
                        StartDate = new DateTime(2018, 9, 17),
                        EndDate = new DateTime(2019, 9, 17),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 8491.7496446640720000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 23,
                        CarId = 177,
                        StartDate = new DateTime(1991, 3, 20),
                        EndDate = new DateTime(1992, 3, 19),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 8576.3070830090560000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 91,
                        CarId = 116,
                        StartDate = new DateTime(1997, 10, 28),
                        EndDate = new DateTime(1998, 10, 28),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 7554.5804249388400000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 128,
                        CarId = 26,
                        StartDate = new DateTime(2020, 2, 26),
                        EndDate = new DateTime(2021, 2, 25),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 5616.8759775728160000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 21,
                        CarId = 123,
                        StartDate = new DateTime(2005, 6, 4),
                        EndDate = new DateTime(2006, 6, 4),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 2699.89478159270480000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 154,
                        CarId = 78,
                        StartDate = new DateTime(1993, 11, 19),
                        EndDate = new DateTime(1994, 11, 19),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 3044.5695836103840000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 26,
                        CarId = 70,
                        StartDate = new DateTime(2008, 10, 29),
                        EndDate = new DateTime(2009, 10, 29),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 8136.6034974736080000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 190,
                        CarId = 160,
                        StartDate = new DateTime(2024, 4, 1),
                        EndDate = new DateTime(2025, 4, 1),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 5614.3018795259440000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 15,
                        CarId = 103,
                        StartDate = new DateTime(1995, 9, 2),
                        EndDate = new DateTime(1996, 9, 1),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 8957.4797424471920000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 21,
                        CarId = 168,
                        StartDate = new DateTime(2013, 12, 7),
                        EndDate = new DateTime(2014, 12, 7),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 3857.2056422932560000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 105,
                        CarId = 130,
                        StartDate = new DateTime(1994, 10, 14),
                        EndDate = new DateTime(1995, 10, 14),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 4784.52075166320000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 128,
                        CarId = 165,
                        StartDate = new DateTime(1994, 3, 27),
                        EndDate = new DateTime(1995, 3, 27),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 3163.3007504995600000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 5,
                        CarId = 81,
                        StartDate = new DateTime(2001, 11, 25),
                        EndDate = new DateTime(2002, 11, 25),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 3270.2368244759600000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 135,
                        CarId = 5,
                        StartDate = new DateTime(2011, 10, 18),
                        EndDate = new DateTime(2012, 10, 17),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 5421.5695795350560000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 16,
                        CarId = 125,
                        StartDate = new DateTime(2000, 5, 4),
                        EndDate = new DateTime(2001, 5, 4),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 7379.9731754043680000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 6,
                        CarId = 5,
                        StartDate = new DateTime(2015, 12, 29),
                        EndDate = new DateTime(2016, 12, 28),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 6843.627746728560000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 36,
                        CarId = 112,
                        StartDate = new DateTime(2000, 3, 5),
                        EndDate = new DateTime(2001, 3, 5),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 6731.0641973533760000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 60,
                        CarId = 119,
                        StartDate = new DateTime(2011, 5, 5),
                        EndDate = new DateTime(2012, 5, 4),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 4844.4642333542640000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 62,
                        CarId = 156,
                        StartDate = new DateTime(1995, 7, 13),
                        EndDate = new DateTime(1996, 7, 12),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 7113.5370091540160000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 96,
                        CarId = 178,
                        StartDate = new DateTime(1991, 10, 17),
                        EndDate = new DateTime(1992, 10, 16),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 4227.2224986482640000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 37,
                        CarId = 136,
                        StartDate = new DateTime(2010, 3, 17),
                        EndDate = new DateTime(2011, 3, 17),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 8450.1660632578240000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 127,
                        CarId = 78,
                        StartDate = new DateTime(2023, 11, 5),
                        EndDate = new DateTime(2024, 11, 4),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 5502.6047105557520000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 143,
                        CarId = 87,
                        StartDate = new DateTime(1991, 5, 12),
                        EndDate = new DateTime(1992, 5, 11),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 8059.5250565153440000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 163,
                        CarId = 83,
                        StartDate = new DateTime(2017, 9, 17),
                        EndDate = new DateTime(2018, 9, 17),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 6755.5176125050320000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 161,
                        CarId = 81,
                        StartDate = new DateTime(2001, 5, 19),
                        EndDate = new DateTime(2002, 5, 19),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 2916.3988044944080000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 91,
                        CarId = 157,
                        StartDate = new DateTime(2009, 10, 11),
                        EndDate = new DateTime(2010, 10, 11),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 8907.4332349612640000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 191,
                        CarId = 165,
                        StartDate = new DateTime(2021, 11, 12),
                        EndDate = new DateTime(2022, 11, 12),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 5364.3248087899680000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 42,
                        CarId = 182,
                        StartDate = new DateTime(2017, 4, 10),
                        EndDate = new DateTime(2018, 4, 10),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 7735.4638554428320000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 11,
                        CarId = 177,
                        StartDate = new DateTime(2006, 2, 9),
                        EndDate = new DateTime(2007, 2, 9),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 6658.2628891011920000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 124,
                        CarId = 176,
                        StartDate = new DateTime(2001, 4, 29),
                        EndDate = new DateTime(2002, 4, 29),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 3547.032050615600000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 70,
                        CarId = 187,
                        StartDate = new DateTime(1991, 7, 3),
                        EndDate = new DateTime(1992, 7, 2),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 8677.5311127453840000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 71,
                        CarId = 130,
                        StartDate = new DateTime(2001, 5, 31),
                        EndDate = new DateTime(2002, 5, 31),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 2805.6109042211680000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 154,
                        CarId = 180,
                        StartDate = new DateTime(2010, 11, 27),
                        EndDate = new DateTime(2011, 11, 27),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 8547.4920975144080000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 12,
                        CarId = 188,
                        StartDate = new DateTime(1999, 3, 29),
                        EndDate = new DateTime(2000, 3, 28),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 9403.5594190105120000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 183,
                        CarId = 168,
                        StartDate = new DateTime(2006, 7, 29),
                        EndDate = new DateTime(2007, 7, 29),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 8644.3677011223120000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 121,
                        CarId = 50,
                        StartDate = new DateTime(2020, 8, 24),
                        EndDate = new DateTime(2021, 8, 24),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 4999.1198154480000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 84,
                        CarId = 162,
                        StartDate = new DateTime(2001, 12, 19),
                        EndDate = new DateTime(2002, 12, 19),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 9795.8495773289920000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 37,
                        CarId = 18,
                        StartDate = new DateTime(2001, 12, 3),
                        EndDate = new DateTime(2002, 12, 3),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 4720.0988406169040000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 194,
                        CarId = 147,
                        StartDate = new DateTime(2023, 4, 1),
                        EndDate = new DateTime(2024, 3, 31),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 5102.328091642160000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 180,
                        CarId = 103,
                        StartDate = new DateTime(2005, 4, 24),
                        EndDate = new DateTime(2006, 4, 24),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 4407.8582874716880000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 58,
                        CarId = 130,
                        StartDate = new DateTime(2015, 4, 16),
                        EndDate = new DateTime(2016, 4, 15),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 4326.7972836784400000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 28,
                        CarId = 83,
                        StartDate = new DateTime(2012, 4, 11),
                        EndDate = new DateTime(2013, 4, 11),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 8415.9278071143680000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 22,
                        CarId = 75,
                        StartDate = new DateTime(2018, 8, 15),
                        EndDate = new DateTime(2019, 8, 15),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 9263.9997785282880000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 163,
                        CarId = 136,
                        StartDate = new DateTime(2019, 12, 24),
                        EndDate = new DateTime(2020, 12, 23),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 7136.1064960487920000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 83,
                        CarId = 142,
                        StartDate = new DateTime(1991, 9, 14),
                        EndDate = new DateTime(1992, 9, 13),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 9190.7743377978560000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 170,
                        CarId = 103,
                        StartDate = new DateTime(2015, 1, 18),
                        EndDate = new DateTime(2016, 1, 18),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 7501.4059747311680000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 2,
                        CarId = 28,
                        StartDate = new DateTime(1990, 6, 29),
                        EndDate = new DateTime(1991, 6, 29),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 7678.3353179474880000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 165,
                        CarId = 69,
                        StartDate = new DateTime(2020, 8, 30),
                        EndDate = new DateTime(2021, 8, 30),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 4317.7756017374160000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 191,
                        CarId = 88,
                        StartDate = new DateTime(2022, 3, 22),
                        EndDate = new DateTime(2023, 3, 22),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 6595.0638788571920000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 17,
                        CarId = 89,
                        StartDate = new DateTime(2007, 6, 22),
                        EndDate = new DateTime(2008, 6, 21),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 5319.8711260470160000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 28,
                        CarId = 128,
                        StartDate = new DateTime(2006, 6, 18),
                        EndDate = new DateTime(2007, 6, 18),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 9041.9191894121360000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 145,
                        CarId = 81,
                        StartDate = new DateTime(2001, 4, 28),
                        EndDate = new DateTime(2002, 4, 28),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 8952.88920607520000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 60,
                        CarId = 122,
                        StartDate = new DateTime(2006, 8, 3),
                        EndDate = new DateTime(2007, 8, 3),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 9865.1955565616720000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 150,
                        CarId = 31,
                        StartDate = new DateTime(1994, 8, 10),
                        EndDate = new DateTime(1995, 8, 10),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 7001.5900346501840000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 163,
                        CarId = 138,
                        StartDate = new DateTime(2024, 3, 21),
                        EndDate = new DateTime(2025, 3, 21),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 3095.4238778502800000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 165,
                        CarId = 29,
                        StartDate = new DateTime(2012, 5, 6),
                        EndDate = new DateTime(2013, 5, 6),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 2779.15253488698160000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 46,
                        CarId = 37,
                        StartDate = new DateTime(1992, 11, 25),
                        EndDate = new DateTime(1993, 11, 25),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 7025.655722950160000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 166,
                        CarId = 77,
                        StartDate = new DateTime(2022, 4, 27),
                        EndDate = new DateTime(2023, 4, 27),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 4414.3533624152960000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 40,
                        CarId = 187,
                        StartDate = new DateTime(1999, 11, 21),
                        EndDate = new DateTime(2000, 11, 20),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 6743.4431933845040000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 82,
                        CarId = 52,
                        StartDate = new DateTime(2005, 2, 3),
                        EndDate = new DateTime(2006, 2, 3),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 2926.6752769495520000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 62,
                        CarId = 151,
                        StartDate = new DateTime(1994, 11, 23),
                        EndDate = new DateTime(1995, 11, 23),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 4447.9906298507920000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 78,
                        CarId = 78,
                        StartDate = new DateTime(2007, 1, 10),
                        EndDate = new DateTime(2008, 1, 10),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 4405.1762775310720000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 128,
                        CarId = 95,
                        StartDate = new DateTime(1998, 7, 22),
                        EndDate = new DateTime(1999, 7, 22),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 8579.2712563202560000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 150,
                        CarId = 66,
                        StartDate = new DateTime(2016, 1, 9),
                        EndDate = new DateTime(2017, 1, 8),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 3776.8219095937360000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 165,
                        CarId = 114,
                        StartDate = new DateTime(2007, 7, 22),
                        EndDate = new DateTime(2008, 7, 21),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 6009.4299164141120000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 145,
                        CarId = 31,
                        StartDate = new DateTime(1992, 3, 9),
                        EndDate = new DateTime(1993, 3, 9),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 7292.4044632071040000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 13,
                        CarId = 76,
                        StartDate = new DateTime(2006, 5, 17),
                        EndDate = new DateTime(2007, 5, 17),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 8272.6408255389520000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 99,
                        CarId = 174,
                        StartDate = new DateTime(2006, 4, 15),
                        EndDate = new DateTime(2007, 4, 15),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 9603.2691297389200000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 69,
                        CarId = 109,
                        StartDate = new DateTime(1998, 9, 29),
                        EndDate = new DateTime(1999, 9, 29),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 6320.2668641883840000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 154,
                        CarId = 108,
                        StartDate = new DateTime(2016, 5, 28),
                        EndDate = new DateTime(2017, 5, 28),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 3670.2222730351840000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 134,
                        CarId = 73,
                        StartDate = new DateTime(2013, 11, 13),
                        EndDate = new DateTime(2014, 11, 13),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 9898.929082664720000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 100,
                        CarId = 49,
                        StartDate = new DateTime(2003, 4, 17),
                        EndDate = new DateTime(2004, 4, 16),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 7338.8787260878160000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 13,
                        CarId = 183,
                        StartDate = new DateTime(2008, 2, 27),
                        EndDate = new DateTime(2009, 2, 26),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 3657.016191918640000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 46,
                        CarId = 147,
                        StartDate = new DateTime(2000, 7, 27),
                        EndDate = new DateTime(2001, 7, 27),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 2617.06040007207840000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 153,
                        CarId = 44,
                        StartDate = new DateTime(1999, 4, 18),
                        EndDate = new DateTime(2000, 4, 17),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 6739.972605826720000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 23,
                        CarId = 154,
                        StartDate = new DateTime(1991, 5, 4),
                        EndDate = new DateTime(1992, 5, 3),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 7382.7361444528880000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 49,
                        CarId = 76,
                        StartDate = new DateTime(2012, 8, 29),
                        EndDate = new DateTime(2013, 8, 29),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 4912.9939059766240000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 61,
                        CarId = 13,
                        StartDate = new DateTime(1991, 9, 13),
                        EndDate = new DateTime(1992, 9, 12),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 9195.8617197190080000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 184,
                        CarId = 82,
                        StartDate = new DateTime(2022, 2, 8),
                        EndDate = new DateTime(2023, 2, 8),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 5470.9289127079120000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 187,
                        CarId = 2,
                        StartDate = new DateTime(2011, 11, 5),
                        EndDate = new DateTime(2012, 11, 4),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 9406.2584327819920000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 90,
                        CarId = 133,
                        StartDate = new DateTime(1999, 3, 26),
                        EndDate = new DateTime(2000, 3, 25),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 6389.198605535920000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 97,
                        CarId = 135,
                        StartDate = new DateTime(2015, 8, 13),
                        EndDate = new DateTime(2016, 8, 12),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 6372.1213677899600000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 152,
                        CarId = 182,
                        StartDate = new DateTime(2006, 9, 6),
                        EndDate = new DateTime(2007, 9, 6),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 6678.0419519436320000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 42,
                        CarId = 104,
                        StartDate = new DateTime(1994, 11, 30),
                        EndDate = new DateTime(1995, 11, 30),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 6752.6829578594800000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 12,
                        CarId = 197,
                        StartDate = new DateTime(2004, 9, 17),
                        EndDate = new DateTime(2005, 9, 17),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 3697.1297465399600000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 149,
                        CarId = 15,
                        StartDate = new DateTime(1990, 3, 11),
                        EndDate = new DateTime(1991, 3, 11),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 7237.8109651027440000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 51,
                        CarId = 65,
                        StartDate = new DateTime(2022, 4, 3),
                        EndDate = new DateTime(2023, 4, 3),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 6197.2492395463040000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 44,
                        CarId = 54,
                        StartDate = new DateTime(2007, 8, 30),
                        EndDate = new DateTime(2008, 8, 29),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 5255.4935582820720000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 1,
                        CarId = 16,
                        StartDate = new DateTime(1995, 1, 26),
                        EndDate = new DateTime(1996, 1, 26),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 8248.3595700903680000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 67,
                        CarId = 194,
                        StartDate = new DateTime(2007, 6, 3),
                        EndDate = new DateTime(2008, 6, 2),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 8386.7119136425760000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 198,
                        CarId = 71,
                        StartDate = new DateTime(2010, 3, 12),
                        EndDate = new DateTime(2011, 3, 12),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 6026.4563532242080000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 131,
                        CarId = 151,
                        StartDate = new DateTime(2001, 12, 31),
                        EndDate = new DateTime(2002, 12, 31),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 4285.9650742408480000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 149,
                        CarId = 171,
                        StartDate = new DateTime(2010, 4, 6),
                        EndDate = new DateTime(2011, 4, 6),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 9549.2056308064080000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 176,
                        CarId = 69,
                        StartDate = new DateTime(2003, 5, 17),
                        EndDate = new DateTime(2004, 5, 16),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 8114.05810584480000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 182,
                        CarId = 85,
                        StartDate = new DateTime(1998, 4, 11),
                        EndDate = new DateTime(1999, 4, 11),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 4396.817401770880000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 72,
                        CarId = 123,
                        StartDate = new DateTime(2020, 7, 17),
                        EndDate = new DateTime(2021, 7, 17),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 4583.0095127526480000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 100,
                        CarId = 123,
                        StartDate = new DateTime(2003, 6, 1),
                        EndDate = new DateTime(2004, 5, 31),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 2664.83713206958880000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 86,
                        CarId = 28,
                        StartDate = new DateTime(2021, 1, 28),
                        EndDate = new DateTime(2022, 1, 28),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 6256.5153438622960000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 121,
                        CarId = 149,
                        StartDate = new DateTime(2018, 6, 14),
                        EndDate = new DateTime(2019, 6, 14),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 3514.0630499443680000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 146,
                        CarId = 132,
                        StartDate = new DateTime(2016, 5, 14),
                        EndDate = new DateTime(2017, 5, 14),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 6874.2077198077360000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 121,
                        CarId = 184,
                        StartDate = new DateTime(2019, 3, 2),
                        EndDate = new DateTime(2020, 3, 1),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 4248.3861712598320000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 109,
                        CarId = 76,
                        StartDate = new DateTime(1997, 7, 29),
                        EndDate = new DateTime(1998, 7, 29),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 2630.83812416023120000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 173,
                        CarId = 47,
                        StartDate = new DateTime(1995, 4, 18),
                        EndDate = new DateTime(1996, 4, 17),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 8180.2183574266960000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 91,
                        CarId = 75,
                        StartDate = new DateTime(1993, 8, 13),
                        EndDate = new DateTime(1994, 8, 13),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 3877.8577316787680000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 133,
                        CarId = 21,
                        StartDate = new DateTime(2019, 8, 10),
                        EndDate = new DateTime(2020, 8, 9),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 8967.935436452640000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 173,
                        CarId = 64,
                        StartDate = new DateTime(2011, 5, 25),
                        EndDate = new DateTime(2012, 5, 24),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 9490.662957449520000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 77,
                        CarId = 14,
                        StartDate = new DateTime(2008, 1, 11),
                        EndDate = new DateTime(2009, 1, 10),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 3763.4385891512160000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 40,
                        CarId = 46,
                        StartDate = new DateTime(2013, 2, 16),
                        EndDate = new DateTime(2014, 2, 16),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 2278.61947546170720000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 105,
                        CarId = 22,
                        StartDate = new DateTime(2020, 4, 20),
                        EndDate = new DateTime(2021, 4, 20),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 6826.919041015120000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 186,
                        CarId = 25,
                        StartDate = new DateTime(2001, 1, 11),
                        EndDate = new DateTime(2002, 1, 11),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 7503.9933897694480000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 49,
                        CarId = 109,
                        StartDate = new DateTime(1999, 7, 22),
                        EndDate = new DateTime(2000, 7, 21),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 9993.1604817186480000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 30,
                        CarId = 78,
                        StartDate = new DateTime(2004, 1, 21),
                        EndDate = new DateTime(2005, 1, 20),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 4229.2662590012560000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 110,
                        CarId = 134,
                        StartDate = new DateTime(2020, 12, 6),
                        EndDate = new DateTime(2021, 12, 6),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 5049.8011595445440000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 73,
                        CarId = 47,
                        StartDate = new DateTime(1993, 10, 21),
                        EndDate = new DateTime(1994, 10, 21),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 7784.3118341886720000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 172,
                        CarId = 165,
                        StartDate = new DateTime(2022, 11, 22),
                        EndDate = new DateTime(2023, 11, 22),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 2722.68110897387520000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 40,
                        CarId = 26,
                        StartDate = new DateTime(2023, 1, 12),
                        EndDate = new DateTime(2024, 1, 12),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 2408.72596264380240000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 134,
                        CarId = 175,
                        StartDate = new DateTime(2001, 6, 23),
                        EndDate = new DateTime(2002, 6, 23),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 8048.6602148047600000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 136,
                        CarId = 84,
                        StartDate = new DateTime(2018, 8, 23),
                        EndDate = new DateTime(2019, 8, 23),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 7035.2105840074080000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 46,
                        CarId = 88,
                        StartDate = new DateTime(1995, 9, 18),
                        EndDate = new DateTime(1996, 9, 17),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 8316.545954239280000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 116,
                        CarId = 147,
                        StartDate = new DateTime(2022, 8, 6),
                        EndDate = new DateTime(2023, 8, 6),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 5894.3662674280880000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 143,
                        CarId = 99,
                        StartDate = new DateTime(1999, 9, 24),
                        EndDate = new DateTime(2000, 9, 23),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 7558.2340870262960000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 44,
                        CarId = 106,
                        StartDate = new DateTime(2021, 9, 6),
                        EndDate = new DateTime(2022, 9, 6),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 4064.9599455318960000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 139,
                        CarId = 173,
                        StartDate = new DateTime(2020, 4, 30),
                        EndDate = new DateTime(2021, 4, 30),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 8654.7477185208560000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 79,
                        CarId = 140,
                        StartDate = new DateTime(2016, 9, 24),
                        EndDate = new DateTime(2017, 9, 24),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 9344.3060709606080000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 192,
                        CarId = 53,
                        StartDate = new DateTime(2018, 2, 14),
                        EndDate = new DateTime(2019, 2, 14),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 3771.9478737305840000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 110,
                        CarId = 4,
                        StartDate = new DateTime(2007, 9, 17),
                        EndDate = new DateTime(2008, 9, 16),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 7712.2275645845920000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 140,
                        CarId = 8,
                        StartDate = new DateTime(2004, 3, 27),
                        EndDate = new DateTime(2005, 3, 27),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 5544.5252732102640000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 132,
                        CarId = 109,
                        StartDate = new DateTime(2009, 4, 21),
                        EndDate = new DateTime(2010, 4, 21),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 4797.3574306934160000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 195,
                        CarId = 180,
                        StartDate = new DateTime(2011, 10, 30),
                        EndDate = new DateTime(2012, 10, 29),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 9462.4699009656160000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 127,
                        CarId = 109,
                        StartDate = new DateTime(2003, 5, 29),
                        EndDate = new DateTime(2004, 5, 28),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 9287.0954286425680000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 43,
                        CarId = 192,
                        StartDate = new DateTime(1996, 3, 13),
                        EndDate = new DateTime(1997, 3, 13),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 6015.0839855218080000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 150,
                        CarId = 183,
                        StartDate = new DateTime(2000, 1, 4),
                        EndDate = new DateTime(2001, 1, 3),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 4965.8601532603600000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 53,
                        CarId = 6,
                        StartDate = new DateTime(1991, 9, 3),
                        EndDate = new DateTime(1992, 9, 2),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 8882.939602608160000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 135,
                        CarId = 155,
                        StartDate = new DateTime(2012, 3, 31),
                        EndDate = new DateTime(2013, 3, 31),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 2172.95741822118080000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 182,
                        CarId = 65,
                        StartDate = new DateTime(2007, 6, 25),
                        EndDate = new DateTime(2008, 6, 24),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 5268.9319354042960000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 106,
                        CarId = 69,
                        StartDate = new DateTime(2003, 12, 13),
                        EndDate = new DateTime(2004, 12, 12),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 5967.7758652753520000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 101,
                        CarId = 177,
                        StartDate = new DateTime(2005, 11, 25),
                        EndDate = new DateTime(2006, 11, 25),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 6138.4644888774960000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 55,
                        CarId = 187,
                        StartDate = new DateTime(1997, 5, 12),
                        EndDate = new DateTime(1998, 5, 12),
                        TypeOfInsurance = "Underinsured Motorist Coverage",
                        Premium = 2807.3944147825280000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 148,
                        CarId = 62,
                        StartDate = new DateTime(2009, 9, 24),
                        EndDate = new DateTime(2010, 9, 24),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 7599.8682313281520000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 181,
                        CarId = 135,
                        StartDate = new DateTime(2019, 6, 30),
                        EndDate = new DateTime(2020, 6, 29),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 2703.16835320803360000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 131,
                        CarId = 144,
                        StartDate = new DateTime(1997, 5, 28),
                        EndDate = new DateTime(1998, 5, 28),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 6893.3897612754640000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 141,
                        CarId = 43,
                        StartDate = new DateTime(2005, 4, 27),
                        EndDate = new DateTime(2006, 4, 27),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 5002.3467724784560000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 94,
                        CarId = 186,
                        StartDate = new DateTime(2015, 8, 15),
                        EndDate = new DateTime(2016, 8, 14),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 9167.9991498682960000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 68,
                        CarId = 197,
                        StartDate = new DateTime(1996, 12, 15),
                        EndDate = new DateTime(1997, 12, 15),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 6717.8611498290880000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 27,
                        CarId = 64,
                        StartDate = new DateTime(1996, 7, 14),
                        EndDate = new DateTime(1997, 7, 14),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 8402.0322884814640000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 155,
                        CarId = 71,
                        StartDate = new DateTime(2011, 9, 6),
                        EndDate = new DateTime(2012, 9, 5),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 6175.9441234495840000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 186,
                        CarId = 181,
                        StartDate = new DateTime(1999, 3, 11),
                        EndDate = new DateTime(2000, 3, 10),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 4205.6424562566880000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 18,
                        CarId = 124,
                        StartDate = new DateTime(1993, 9, 16),
                        EndDate = new DateTime(1994, 9, 16),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 2174.37317808590640000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 123,
                        CarId = 28,
                        StartDate = new DateTime(2023, 11, 19),
                        EndDate = new DateTime(2024, 11, 18),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 3185.1344795282800000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 48,
                        CarId = 96,
                        StartDate = new DateTime(2018, 12, 15),
                        EndDate = new DateTime(2019, 12, 15),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 9149.2182289163360000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 94,
                        CarId = 62,
                        StartDate = new DateTime(1994, 11, 26),
                        EndDate = new DateTime(1995, 11, 26),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 9714.8426438613440000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 143,
                        CarId = 142,
                        StartDate = new DateTime(1994, 9, 3),
                        EndDate = new DateTime(1995, 9, 3),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 8883.1384340032080000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 153,
                        CarId = 109,
                        StartDate = new DateTime(2008, 5, 18),
                        EndDate = new DateTime(2009, 5, 18),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 9608.5810072615040000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 193,
                        CarId = 35,
                        StartDate = new DateTime(1998, 8, 8),
                        EndDate = new DateTime(1999, 8, 8),
                        TypeOfInsurance = "Comprehensive Insurance",
                        Premium = 5303.840874702560000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 175,
                        CarId = 10,
                        StartDate = new DateTime(1998, 3, 31),
                        EndDate = new DateTime(1999, 3, 31),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 8131.6187147585360000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 79,
                        CarId = 196,
                        StartDate = new DateTime(1993, 4, 22),
                        EndDate = new DateTime(1994, 4, 22),
                        TypeOfInsurance = "Uninsured Motorist Coverage",
                        Premium = 9350.3569632664880000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 125,
                        CarId = 32,
                        StartDate = new DateTime(1993, 12, 27),
                        EndDate = new DateTime(1994, 12, 27),
                        TypeOfInsurance = "Rental Reimbursement",
                        Premium = 4386.6145819419920000m,
                        Status = InsuranceStatus.Cancelled,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 123,
                        CarId = 98,
                        StartDate = new DateTime(2010, 12, 14),
                        EndDate = new DateTime(2011, 12, 14),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 5400.6222922134560000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 144,
                        CarId = 136,
                        StartDate = new DateTime(1990, 2, 27),
                        EndDate = new DateTime(1991, 2, 27),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 4949.9440145033280000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 192,
                        CarId = 171,
                        StartDate = new DateTime(2020, 4, 9),
                        EndDate = new DateTime(2021, 4, 9),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 2255.41863891006960000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 44,
                        CarId = 40,
                        StartDate = new DateTime(1992, 1, 12),
                        EndDate = new DateTime(1993, 1, 11),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 8471.1549804688480000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 121,
                        CarId = 169,
                        StartDate = new DateTime(2000, 10, 6),
                        EndDate = new DateTime(2001, 10, 6),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 8202.121568265760000m,
                        Status = InsuranceStatus.UnderReview,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 71,
                        CarId = 153,
                        StartDate = new DateTime(2014, 10, 15),
                        EndDate = new DateTime(2015, 10, 15),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 4621.7996797862560000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 180,
                        CarId = 51,
                        StartDate = new DateTime(2003, 8, 31),
                        EndDate = new DateTime(2004, 8, 30),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 3512.5998040922480000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 9,
                        CarId = 164,
                        StartDate = new DateTime(1990, 5, 13),
                        EndDate = new DateTime(1991, 5, 13),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 2135.80319157068320000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 117,
                        CarId = 71,
                        StartDate = new DateTime(1997, 2, 16),
                        EndDate = new DateTime(1998, 2, 16),
                        TypeOfInsurance = "Gap Insurance",
                        Premium = 9735.6263324999600000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 101,
                        CarId = 185,
                        StartDate = new DateTime(2016, 1, 9),
                        EndDate = new DateTime(2017, 1, 8),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 4705.6925994331520000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 119,
                        CarId = 73,
                        StartDate = new DateTime(2017, 6, 29),
                        EndDate = new DateTime(2018, 6, 29),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 3180.238508360160000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 116,
                        CarId = 88,
                        StartDate = new DateTime(2006, 6, 19),
                        EndDate = new DateTime(2007, 6, 19),
                        TypeOfInsurance = "Liability Insurance",
                        Premium = 7923.4640541630880000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 118,
                        CarId = 90,
                        StartDate = new DateTime(2002, 2, 2),
                        EndDate = new DateTime(2003, 2, 2),
                        TypeOfInsurance = "Roadside Assistance",
                        Premium = 5144.7859834954160000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 120,
                        CarId = 121,
                        StartDate = new DateTime(1990, 10, 31),
                        EndDate = new DateTime(1991, 10, 31),
                        TypeOfInsurance = "Bodily Injury Liability",
                        Premium = 5326.3749310321760000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 96,
                        CarId = 51,
                        StartDate = new DateTime(1996, 5, 1),
                        EndDate = new DateTime(1997, 5, 1),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 4508.2955552978160000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 99,
                        CarId = 98,
                        StartDate = new DateTime(2001, 3, 29),
                        EndDate = new DateTime(2002, 3, 29),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 5295.2075470777520000m,
                        Status = InsuranceStatus.Suspended,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 97,
                        CarId = 117,
                        StartDate = new DateTime(1995, 7, 16),
                        EndDate = new DateTime(1996, 7, 15),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 2964.553151950480000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 38,
                        CarId = 130,
                        StartDate = new DateTime(2006, 12, 18),
                        EndDate = new DateTime(2007, 12, 18),
                        TypeOfInsurance = "Collision Insurance",
                        Premium = 5371.2425558611120000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 128,
                        CarId = 116,
                        StartDate = new DateTime(2007, 8, 22),
                        EndDate = new DateTime(2008, 8, 21),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 2996.3709454284320000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 134,
                        CarId = 36,
                        StartDate = new DateTime(2024, 4, 5),
                        EndDate = new DateTime(2025, 4, 5),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 6478.7981694993360000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 49,
                        CarId = 35,
                        StartDate = new DateTime(2021, 1, 6),
                        EndDate = new DateTime(2022, 1, 6),
                        TypeOfInsurance = "Medical Payments Coverage (MedPay)",
                        Premium = 3774.9927998926320000m,
                        Status = InsuranceStatus.Expired,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 189,
                        CarId = 23,
                        StartDate = new DateTime(2021, 6, 18),
                        EndDate = new DateTime(2022, 6, 18),
                        TypeOfInsurance = "Property Damage Liability",
                        Premium = 2190.29266877429040000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 195,
                        CarId = 90,
                        StartDate = new DateTime(2014, 11, 16),
                        EndDate = new DateTime(2015, 11, 16),
                        TypeOfInsurance = "Collision Coverage",
                        Premium = 5375.9614935450720000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 106,
                        CarId = 22,
                        StartDate = new DateTime(2023, 1, 28),
                        EndDate = new DateTime(2024, 1, 28),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 6507.6849544218880000m,
                        Status = InsuranceStatus.Lapsed,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 196,
                        CarId = 104,
                        StartDate = new DateTime(2020, 4, 17),
                        EndDate = new DateTime(2021, 4, 17),
                        TypeOfInsurance = "Comprehensive Coverage",
                        Premium = 5653.6702454697120000m,
                        Status = InsuranceStatus.Active,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new Insurance()
                    {
                        UserId = 43,
                        CarId = 82,
                        StartDate = new DateTime(1990, 8, 2),
                        EndDate = new DateTime(1991, 8, 2),
                        TypeOfInsurance = "Personal Injury Protection (PIP)",
                        Premium = 3108.9812588628640000m,
                        Status = InsuranceStatus.Pending,
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
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
