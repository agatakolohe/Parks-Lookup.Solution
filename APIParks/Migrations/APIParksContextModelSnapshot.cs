﻿// <auto-generated />
using APIParks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIParks.Migrations
{
    [DbContext(typeof(APIParksContext))]
    partial class APIParksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIParks.Models.National", b =>
                {
                    b.Property<int>("NationalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NationalParkDescription");

                    b.Property<string>("NationalParkLocation");

                    b.Property<string>("NationalParkName");

                    b.HasKey("NationalId");

                    b.ToTable("Nationals");
                });

            modelBuilder.Entity("APIParks.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StateParkDescription");

                    b.Property<string>("StateParkLocation");

                    b.Property<string>("StateParkName");

                    b.HasKey("StateId");

                    b.ToTable("States");
                });
#pragma warning restore 612, 618
        }
    }
}
