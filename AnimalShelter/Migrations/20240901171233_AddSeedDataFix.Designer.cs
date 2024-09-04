﻿// <auto-generated />
using System;
using AnimalShelter.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240901171233_AddSeedDataFix")]
    partial class AddSeedDataFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimalShelter.Entities.Adoption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AdopterContact")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("AdopterName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("AdoptionFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimalID");

                    b.ToTable("Adoptions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AdopterContact = "john322@email.em",
                            AdopterName = "John Doe",
                            AdoptionDate = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AdoptionFee = 200.00m,
                            AnimalID = 1
                        },
                        new
                        {
                            ID = 2,
                            AdopterContact = "@Sm1th22 - telegram",
                            AdopterName = "Jane Smith",
                            AdoptionDate = new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AdoptionFee = 150.00m,
                            AnimalID = 2
                        },
                        new
                        {
                            ID = 3,
                            AdopterContact = "23476230123674 - phone",
                            AdopterName = "Emily Johnson",
                            AdoptionDate = new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AdoptionFee = 250.00m,
                            AnimalID = 3
                        });
                });

            modelBuilder.Entity("AnimalShelter.Entities.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AnimalTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("CageID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdopted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("ShelterID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimalTypeID");

                    b.HasIndex("CageID");

                    b.HasIndex("IsAdopted");

                    b.HasIndex("ShelterID");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AdoptionDate = new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3634),
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3629),
                            Breed = "Golden Retriever",
                            CageID = 1,
                            IsAdopted = true,
                            Name = "Buddy",
                            PhotoUrl = "buddy.jpg"
                        },
                        new
                        {
                            ID = 2,
                            AdoptionDate = new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3645),
                            AnimalTypeID = 2,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3643),
                            Breed = "Siamese",
                            CageID = 2,
                            IsAdopted = true,
                            Name = "Whiskers",
                            PhotoUrl = "whiskers.jpg"
                        },
                        new
                        {
                            ID = 3,
                            AdoptionDate = new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3648),
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3646),
                            Breed = "Labrador",
                            CageID = 3,
                            IsAdopted = true,
                            Name = "Max",
                            PhotoUrl = "max.jpg"
                        },
                        new
                        {
                            ID = 4,
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3649),
                            Breed = "German Shepherd",
                            CageID = 3,
                            IsAdopted = false,
                            Name = "Rex",
                            PhotoUrl = "rex.jpg"
                        },
                        new
                        {
                            ID = 5,
                            AnimalTypeID = 2,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3650),
                            Breed = "Maine Coon",
                            CageID = 4,
                            IsAdopted = false,
                            Name = "Mittens",
                            PhotoUrl = "mittens.jpg"
                        },
                        new
                        {
                            ID = 6,
                            AnimalTypeID = 3,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3652),
                            Breed = "Canary",
                            CageID = 5,
                            IsAdopted = false,
                            Name = "Tweety",
                            PhotoUrl = "tweety.jpg"
                        },
                        new
                        {
                            ID = 7,
                            AnimalTypeID = 3,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3653),
                            Breed = "Parrot",
                            CageID = 5,
                            IsAdopted = false,
                            Name = "Sky",
                            PhotoUrl = "sky.jpg"
                        },
                        new
                        {
                            ID = 8,
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3655),
                            Breed = "Beagle",
                            CageID = 6,
                            IsAdopted = false,
                            Name = "Charlie",
                            PhotoUrl = "charlie.jpg"
                        },
                        new
                        {
                            ID = 9,
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3656),
                            Breed = "Bulldog",
                            CageID = 6,
                            IsAdopted = false,
                            Name = "Rocky",
                            PhotoUrl = "rocky.jpg"
                        },
                        new
                        {
                            ID = 10,
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3658),
                            Breed = "Poodle",
                            CageID = 6,
                            IsAdopted = false,
                            Name = "Bella",
                            PhotoUrl = "bella.jpg"
                        },
                        new
                        {
                            ID = 11,
                            AnimalTypeID = 1,
                            ArrivalDate = new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3659),
                            Breed = "Husky",
                            CageID = 6,
                            IsAdopted = false,
                            Name = "Luna",
                            PhotoUrl = "luna.jpg"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Entities.Cage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnimalTypeID")
                        .HasColumnType("int");

                    b.Property<int>("CageNumber")
                        .HasColumnType("int");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<int>("ShelterID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimalTypeID");

                    b.HasIndex("CageNumber");

                    b.HasIndex("ShelterID");

                    b.ToTable("Cages");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AnimalTypeID = 1,
                            CageNumber = 101,
                            MaxCapacity = 1,
                            ShelterID = 1
                        },
                        new
                        {
                            ID = 2,
                            AnimalTypeID = 2,
                            CageNumber = 102,
                            MaxCapacity = 1,
                            ShelterID = 1
                        },
                        new
                        {
                            ID = 3,
                            AnimalTypeID = 1,
                            CageNumber = 201,
                            MaxCapacity = 2,
                            ShelterID = 1
                        },
                        new
                        {
                            ID = 4,
                            AnimalTypeID = 2,
                            CageNumber = 202,
                            MaxCapacity = 2,
                            ShelterID = 1
                        },
                        new
                        {
                            ID = 5,
                            AnimalTypeID = 3,
                            CageNumber = 301,
                            MaxCapacity = 3,
                            ShelterID = 1
                        },
                        new
                        {
                            ID = 6,
                            AnimalTypeID = 1,
                            CageNumber = 401,
                            MaxCapacity = 4,
                            ShelterID = 1
                        },
                        new
                        {
                            ID = 7,
                            AnimalTypeID = 4,
                            CageNumber = 501,
                            MaxCapacity = 5,
                            ShelterID = 1
                        });
                });

            modelBuilder.Entity("AnimalShelter.Entities.IncomeReport", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("ShelterID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ShelterID");

                    b.ToTable("IncomeReports");
                });

            modelBuilder.Entity("AnimalShelter.Entities.RefAnimalType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RefAnimalType");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Type = "Dog"
                        },
                        new
                        {
                            ID = 2,
                            Type = "Cat"
                        },
                        new
                        {
                            ID = 3,
                            Type = "Bird"
                        },
                        new
                        {
                            ID = 4,
                            Type = "Rabbit"
                        },
                        new
                        {
                            ID = 5,
                            Type = "Hamster"
                        },
                        new
                        {
                            ID = 6,
                            Type = "Reptile"
                        },
                        new
                        {
                            ID = 7,
                            Type = "Fish"
                        },
                        new
                        {
                            ID = 8,
                            Type = "Other"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Entities.Shelter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("ID");

                    b.ToTable("Shelters");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Location = "",
                            Name = ""
                        });
                });

            modelBuilder.Entity("AnimalShelter.Entities.Adoption", b =>
                {
                    b.HasOne("AnimalShelter.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("AnimalShelter.Entities.Animal", b =>
                {
                    b.HasOne("AnimalShelter.Entities.RefAnimalType", "AnimalType")
                        .WithMany()
                        .HasForeignKey("AnimalTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalShelter.Entities.Cage", "Cage")
                        .WithMany("Animals")
                        .HasForeignKey("CageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalShelter.Entities.Shelter", null)
                        .WithMany("Animals")
                        .HasForeignKey("ShelterID");

                    b.Navigation("AnimalType");

                    b.Navigation("Cage");
                });

            modelBuilder.Entity("AnimalShelter.Entities.Cage", b =>
                {
                    b.HasOne("AnimalShelter.Entities.RefAnimalType", "AnimalType")
                        .WithMany()
                        .HasForeignKey("AnimalTypeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AnimalShelter.Entities.Shelter", "Shelter")
                        .WithMany("Cages")
                        .HasForeignKey("ShelterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalType");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("AnimalShelter.Entities.IncomeReport", b =>
                {
                    b.HasOne("AnimalShelter.Entities.Shelter", "Shelter")
                        .WithMany()
                        .HasForeignKey("ShelterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("AnimalShelter.Entities.Cage", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("AnimalShelter.Entities.Shelter", b =>
                {
                    b.Navigation("Animals");

                    b.Navigation("Cages");
                });
#pragma warning restore 612, 618
        }
    }
}
