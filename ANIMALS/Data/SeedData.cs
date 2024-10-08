using ANIMALS.Models;
using Microsoft.EntityFrameworkCore;

namespace ANIMALS.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AnimalsDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<AnimalsDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                    new Animal
                    {
                        Name = "Lions",
                        LifeSpan = "12 to 16 years",
                        Price = 15000m,
                        DateOfBirth = Convert.ToDateTime("2023/04/06"),
                        Description = "Lions are large carnivorous felines known for their strength and majestic mane, often referred to as the 'king of the jungle'."
                    },
                    new Animal
                    {
                        Name = "Dolphins",
                        LifeSpan = "30 to 50 years",
                        Price = 55000m,
                        DateOfBirth = Convert.ToDateTime("2021/06/08"),
                        Description = "Dolphins are intelligent marine mammals recognized for their playful behavior and advanced communication skills."
                    },

                    new Animal
                    {
                        Name = "Alpacas",
                        LifeSpan = "15 to 20 years",
                        Price = 3200m,
                        DateOfBirth = Convert.ToDateTime("2022/01/15"),
                        Description = "Alpacas are domesticated herbivores, prized for their soft wool and gentle demeanor."
                    },
                    new Animal
                    {
                        Name = "Kangaroos",
                        LifeSpan = "20 to 23 years",
                        Price = 4500m,
                        DateOfBirth = Convert.ToDateTime("2022/07/12"),
                        Description = "Kangaroos are marsupials known for their powerful hind legs, strong tail, and ability to hop great distances."
                    },
                    new Animal
                    {
                        Name = "Penguins",
                        LifeSpan = "15 to 20 years",
                        Price = 3000m,
                        DateOfBirth = Convert.ToDateTime("2021/11/25"),
                        Description = "Penguins are flightless birds that thrive in cold climates, known for their distinctive black and white plumage."
                    },
                    new Animal
                    {
                        Name = "Camels",
                        LifeSpan = "40 to 50 years",
                        Price = 9500m,
                        DateOfBirth = Convert.ToDateTime("2020/03/14"),
                        Description = "Camels are large herbivores adapted to arid environments, famous for their ability to store water in their humps."
                    },
                    new Animal
                    {
                        Name = "Rabbits",
                        LifeSpan = "8 to 12 years",
                        Price = 200m,
                        DateOfBirth = Convert.ToDateTime("2023/01/06"),
                        Description = "Rabbits are small mammals known for their long ears, strong hind legs, and soft fur."
                    },
                    new Animal
                    {
                        Name = "Owls",
                        LifeSpan = "10 to 15 years",
                        Price = 700m,
                        DateOfBirth = Convert.ToDateTime("2022/03/01"),
                        Description = "Owls are nocturnal birds of prey with exceptional vision and the ability to rotate their heads significantly."
                    });

            }
            context.SaveChanges();
        }
    }
}
