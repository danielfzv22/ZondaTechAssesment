using ZondaTechAssesment.Models;

namespace ZondaTechAssesment.Services
{
    public class MockDataService
    {
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }

        public MockDataService()
        {
            Customers =
            [
                new()
                {
                    Id = 1,
                    Name = "Luminor Environmental",
                    Email = "contact@luminor.com",
                    Phone = "123-456-7890",
                    Address = "412 Queens Drive, Guelph, ON",
                    Industry = "Software Development",
                    ContactPerson = "Chantale Desroches",
                    RegistrationDate = new DateTime(2022, 4, 15)},

                new()
                {
                    Id = 2,
                    Name = "TechHive",
                    Email = "info@techhive.io",
                    Phone = "987-654-3210",
                    Address = "123 Innovation Drive, Kitchener, ON",
                    Industry = "Software Development",
                    ContactPerson = "Daniel Zuniga",
                    RegistrationDate = new DateTime(2022, 4, 15)},
                new()
                {
                    Id = 3,
                    Name = "TechNova Inc.",
                    Email = "contact@technova.com",
                    Phone = "+1-555-123-4567",
                    Address = "123 Innovation Drive, Kitchener, ON",
                    Industry = "Software Development",
                    ContactPerson = "Jane Doe",
                    RegistrationDate = new DateTime(2022, 4, 15)
                },
                new()
                {
                    Id = 4,
                    Name = "GreenCore Solutions",
                    Email = "hello@greencore.ca",
                    Phone = "+1-416-987-6543",
                    Address = "88 Eco Park Blvd, Mississauga, ON",
                    Industry = "Environmental Tech",
                    ContactPerson = "Lucas Wong",
                    RegistrationDate = new DateTime(2021, 7, 20)
                },
                new()
                {
                    Id = 5,
                    Name = "ByteForge Labs",
                    Email = "team@byteforge.io",
                    Phone = "+1-778-234-5678",
                    Address = "10 Circuit Way, Vancouver, BC",
                    Industry = "AI Research",
                    ContactPerson = "Amara Singh",
                    RegistrationDate = new DateTime(2023, 1, 5)
                },
                new()
                {
                    Id = 6,
                    Name = "AquaSys Technologies",
                    Email = "support@aquasys.com",
                    Phone = "+1-905-111-2233",
                    Address = "56 Waterlane Rd, Hamilton, ON",
                    Industry = "Water Management",
                    ContactPerson = "Carlos Rivera",
                    RegistrationDate = new DateTime(2020, 11, 9)
                },
                new()
                {
                    Id = 7,
                    Name = "NexLink Media",
                    Email = "admin@nexlinkmedia.com",
                    Phone = "+1-647-321-7788",
                    Address = "400 King St W, Toronto, ON",
                    Industry = "Digital Marketing",
                    ContactPerson = "Michelle Dupont",
                    RegistrationDate = new DateTime(2019, 3, 28)
                }
            ];

            Products = new List<Product>
            {
                new() { Id = 1, CustomerId = 1, Name = "Nexa Chat Engine", Price = 49.99M },
                new() { Id = 2, CustomerId = 1, Name = "Nexa API Gateway", Price = 89.99M },
                new() { Id = 3, CustomerId = 2, Name = "Aether Grid", Price = 119.00M },
                new() { Id = 4, CustomerId = 3, Name = "Quark Stream", Price = 74.99M },
                new() { Id = 5, CustomerId = 4, Name = "BitCrate Encryptor", Price = 29.99M },
                new() { Id = 6, CustomerId = 5, Name = "Vortex Engine", Price = 99.00M },
                new() { Id = 7, CustomerId = 3, Name = "Quark Auth", Price = 59.00M },
                new() { Id = 8, CustomerId = 1, Name = "NovaWidget Pro", Price = 299.99m },
                new() { Id = 9, CustomerId = 1, Name = "NovaSensor Mini", Price = 149.50m },
                new() { Id = 10, CustomerId = 2, Name = "EcoTrack 300", Price = 199.99m },
                new() { Id = 11, CustomerId = 2, Name = "GreenCore Air Analyzer", Price = 399.00m},
                new() { Id = 12, CustomerId = 3, Name = "ByteBot Dev Kit", Price = 899.99m},
                new() { Id = 13, CustomerId = 3, Name = "ForgeChip AI Module", Price = 1299.00m},
                new() { Id = 14, CustomerId = 3, Name = "NeuralCore-X", Price = 1599.99m},
                new() { Id = 15, CustomerId = 4, Name = "AquaSense Pro", Price = 699.99m,},
                new() { Id = 16, CustomerId = 4, Name = "HydroGuard Sensor", Price = 499.50m,},
                new() { Id = 17, CustomerId = 4, Name = "FlowCheck Lite", Price = 229.99m},
                new() { Id = 18, CustomerId = 5, Name = "AdPulse Tracker", Price = 299.99m},
                new() { Id = 19, CustomerId = 5, Name = "NexVision Studio", Price = 899.00m},
                new() { Id = 20, CustomerId = 5, Name = "ContentBoost Engine", Price = 499.99m,},
                new() { Id = 21, CustomerId = 2, Name = "EcoVolt Battery", Price = 349.00m},
                new() { Id = 22, CustomerId = 1, Name = "NovaCore Panel", Price = 1099.99m},
                new() { Id = 23, CustomerId = 1, Name = "NovaLight Strip", Price = 89.99m },
            };
        }
    }
}
