using AnimalShelter.Entities;

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace AnimalShelter.Context {
    public class AppDbContext : DbContext {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<IncomeReport> IncomeReports { get; set; }
        public DbSet<RefAnimalType> RefAnimalType { get; set; }

        public AppDbContext() : base() {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = new SqliteConnectionStringBuilder() {
                Mode = SqliteOpenMode.ReadWriteCreate,
                ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString
            }.ConnectionString;

            optionsBuilder.UseSqlite(connectionString)
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Name });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shelter>(b => {
                b.Property(s => s.ID)
                    .UseIdentityColumn();

                b.HasData(
                    new Shelter { ID = 1, Name = "", Location = "" }
                );
            });

            modelBuilder.Entity<RefAnimalType>(b => {
                b.Property(at => at.ID)
                    .UseIdentityColumn();

                b.HasData(
                    new RefAnimalType { ID = 1, Type = "Dog" },
                    new RefAnimalType { ID = 2, Type = "Cat" },
                    new RefAnimalType { ID = 3, Type = "Bird" },
                    new RefAnimalType { ID = 4, Type = "Rabbit" },
                    new RefAnimalType { ID = 5, Type = "Hamster" },
                    new RefAnimalType { ID = 6, Type = "Reptile" },
                    new RefAnimalType { ID = 7, Type = "Fish" },
                    new RefAnimalType { ID = 8, Type = "Other" 
                });
            });

            modelBuilder.Entity<Cage>(b => {
                b.HasIndex(c => c.CageNumber);
                b.Property(c => c.ID)
                    .UseIdentityColumn();

                b.HasData(
                    new Cage {
                        ID = 1,
                        CageNumber = 101,
                        MaxCapacity = 1,
                        OccupiedCapacity = 0,
                        AnimalTypeID = 1 // Dog
                    },
                    new Cage {
                        ID = 2,
                        CageNumber = 102,
                        MaxCapacity = 1,
                        OccupiedCapacity = 0,
                        AnimalTypeID = 2 // Cat
                    },
                    new Cage {
                        ID = 3,
                        CageNumber = 201,
                        MaxCapacity = 2,
                        OccupiedCapacity = 1,
                        AnimalTypeID = 1 // Dog
                    },
                    new Cage {
                        ID = 4,
                        CageNumber = 202,
                        MaxCapacity = 2,
                        OccupiedCapacity = 1,
                        AnimalTypeID = 2 // Cat
                    },
                    new Cage {
                        ID = 5,
                        CageNumber = 301,
                        MaxCapacity = 3,
                        OccupiedCapacity = 2,
                        AnimalTypeID = 3 // Bird
                    },
                    new Cage {
                        ID = 6,
                        CageNumber = 401,
                        MaxCapacity = 4,
                        OccupiedCapacity = 4,
                        AnimalTypeID = 1 // Dog
                    },
                    new Cage {
                        ID = 7,
                        CageNumber = 501,
                        MaxCapacity = 5,
                        AnimalTypeID = 4 // Rabbit
                    }
                );
            });

            modelBuilder.Entity<Animal>(b => {
                b.HasIndex(a => a.IsAdopted);
                b.Property(a => a.ID)
                    .UseIdentityColumn();

                b.HasData(
                    new Animal {
                        ID = 1,
                        Name = "Buddy",
                        Breed = "Golden Retriever",
                        AnimalTypeID = 1, // Dog
                        CageID = 1, // Вольер 101
                        PhotoUrl = "buddy.jpg",
                        IsAdopted = true,
                        AdoptionDate = DateTime.UtcNow.AddDays(14),
                    },
                    new Animal {
                        ID = 2,
                        Name = "Whiskers",
                        Breed = "Siamese",
                        AnimalTypeID = 2, // Cat
                        CageID = 2, // Вольер 102
                        PhotoUrl = "whiskers.jpg",
                        IsAdopted = true,
                        AdoptionDate = DateTime.UtcNow.AddDays(14),
                    },
                    new Animal {
                        ID = 3,
                        Name = "Max",
                        Breed = "Labrador",
                        AnimalTypeID = 1, // Dog
                        CageID = 3, // Вольер 201
                        PhotoUrl = "max.jpg",
                        IsAdopted = true,
                        AdoptionDate = DateTime.UtcNow.AddDays(14),
                    },
                    new Animal {
                        ID = 4,
                        Name = "Rex",
                        Breed = "German Shepherd",
                        AnimalTypeID = 1, // Dog
                        CageID = 3, // Вольер 201
                        PhotoUrl = "rex.jpg"
                    },
                    new Animal {
                        ID = 5,
                        Name = "Mittens",
                        Breed = "Maine Coon",
                        AnimalTypeID = 2, // Cat
                        CageID = 4, // Вольер 202
                        PhotoUrl = "mittens.jpg"
                    },
                    new Animal {
                        ID = 6,
                        Name = "Tweety",
                        Breed = "Canary",
                        AnimalTypeID = 3, // Bird
                        CageID = 5, // Вольер 301
                        PhotoUrl = "tweety.jpg"
                    },
                    new Animal {
                        ID = 7,
                        Name = "Sky",
                        Breed = "Parrot",
                        AnimalTypeID = 3, // Bird
                        CageID = 5, // Вольер 301
                        PhotoUrl = "sky.jpg"
                    },
                    new Animal {
                        ID = 8,
                        Name = "Charlie",
                        Breed = "Beagle",
                        AnimalTypeID = 1, // Dog
                        CageID = 6, // Вольер 401
                        PhotoUrl = "charlie.jpg"
                    },
                    new Animal {
                        ID = 9,
                        Name = "Rocky",
                        Breed = "Bulldog",
                        AnimalTypeID = 1, // Dog
                        CageID = 6, // Вольер 401
                        PhotoUrl = "rocky.jpg"
                    },
                    new Animal {
                        ID = 10,
                        Name = "Bella",
                        Breed = "Poodle",
                        AnimalTypeID = 1, // Dog
                        CageID = 6, // Вольер 401
                        PhotoUrl = "bella.jpg"
                    },
                    new Animal {
                        ID = 11,
                        Name = "Luna",
                        Breed = "Husky",
                        AnimalTypeID = 1, // Dog
                        CageID = 6, // Вольер 401
                        PhotoUrl = "luna.jpg"
                    }
                );
            });

            modelBuilder.Entity<Adoption>(b => {
                b.Property(a => a.ID)
                    .UseIdentityColumn();

                b.HasData(
                    new Adoption {
                        ID = 1,
                        AnimalID = 1, // Buddy
                        AdoptionDate = new DateTime(2024, 5, 15), 
                        AdoptionFee = 200.00m, 
                        AdopterName = "John Doe", 
                        AdopterContact = "john322@email.em"
                    },
                    new Adoption {
                        ID = 2,
                        AnimalID = 2, // Whiskers
                        AdoptionDate = new DateTime(2024, 6, 20),
                        AdoptionFee = 150.00m,
                        AdopterName = "Jane Smith",
                        AdopterContact = "@Sm1th22 - telegram"
                    },
                    new Adoption {
                        ID = 3,
                        AnimalID = 3, // Max
                        AdoptionDate = new DateTime(2024, 7, 10),
                        AdoptionFee = 250.00m,
                        AdopterName = "Emily Johnson",
                        AdopterContact = "23476230123674 - phone"
                    }
                );
            });

            modelBuilder.Entity<IncomeReport>(b => {
                b.Property(ir => ir.ID)
                    .UseIdentityColumn();
            });
        }
    }
}