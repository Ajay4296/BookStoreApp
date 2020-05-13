﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DBContext;

namespace Repository.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20200513080136_newEntry")]
    partial class newEntry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.BookStoreModel", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName");

                    b.Property<int>("BookCount");

                    b.Property<string>("BookImage");

                    b.Property<string>("BookTittle");

                    b.Property<double>("Price");

                    b.Property<string>("Summary");

                    b.HasKey("BookID");

                    b.ToTable("BookStore");
                });

            modelBuilder.Entity("Model.Model.AddressModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityTown")
                        .IsRequired();

                    b.Property<int>("ContactNumber");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("LandMark")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("ZipCode");

                    b.HasKey("Email");

                    b.ToTable("AddressSpace");
                });

            modelBuilder.Entity("Model.Model.CartModel", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Book_ID");

                    b.Property<int>("SelectBookCount");

                    b.HasKey("CartID");

                    b.ToTable("CartTable");
                });
#pragma warning restore 612, 618
        }
    }
}
