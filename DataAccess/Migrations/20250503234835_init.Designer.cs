﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250503234835_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataAccess.Domain.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("BidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("BidDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BidStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("BidId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("DataAccess.Domain.PaymentHistory", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientSecret")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StripePaymentId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("PaymentHistories");
                });

            modelBuilder.Entity("DataAccess.Domain.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdditionalInformation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("AuctionPrice")
                        .HasColumnType("double");

                    b.Property<string>("BrandAndModel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("EngineCapacity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ManufacturingYear")
                        .HasColumnType("int");

                    b.Property<int>("Millage")
                        .HasColumnType("int");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SellerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("VehicleId");

                    b.HasIndex("SellerId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            VehicleId = 1,
                            AdditionalInformation = "Excellent condition, single owner",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Toyota Camry",
                            Color = "Silver",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9005),
                            EngineCapacity = 2.5m,
                            Image = "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg",
                            IsActive = true,
                            ManufacturingYear = 2020,
                            Millage = 15000,
                            PlateNumber = "34AA21",
                            Price = 25000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(8946)
                        },
                        new
                        {
                            VehicleId = 2,
                            AdditionalInformation = "Good condition, one previous owner",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Honda Civic",
                            Color = "Blue",
                            EndTime = new DateTime(2025, 5, 28, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9016),
                            EngineCapacity = 1.8m,
                            Image = "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg",
                            IsActive = false,
                            ManufacturingYear = 2019,
                            Millage = 20000,
                            PlateNumber = "34AA21",
                            Price = 18000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9013)
                        },
                        new
                        {
                            VehicleId = 3,
                            AdditionalInformation = "Low mileage, well-maintained",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Ford F-150",
                            Color = "Red",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9021),
                            EngineCapacity = 5.0m,
                            Image = "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg",
                            IsActive = true,
                            ManufacturingYear = 2018,
                            Millage = 25000,
                            PlateNumber = "34AA21",
                            Price = 28000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9020)
                        },
                        new
                        {
                            VehicleId = 4,
                            AdditionalInformation = "Great condition, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Nissan Altima",
                            Color = "Black",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9026),
                            EngineCapacity = 2.5m,
                            Image = "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg",
                            IsActive = true,
                            ManufacturingYear = 2017,
                            Millage = 30000,
                            PlateNumber = "34AA21",
                            Price = 16000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9024)
                        },
                        new
                        {
                            VehicleId = 5,
                            AdditionalInformation = "Well-maintained, single owner",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Chevrolet Malibu",
                            Color = "Silver",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9030),
                            EngineCapacity = 2.4m,
                            Image = "https://cdn.carbuzz.com/gallery-images/2016-chevrolet-malibu-carbuzz-489817-1600.jpg",
                            IsActive = true,
                            ManufacturingYear = 2017,
                            Millage = 28000,
                            PlateNumber = "34AA21",
                            Price = 15500.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9029)
                        },
                        new
                        {
                            VehicleId = 6,
                            AdditionalInformation = "Like new, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Ferrari 488 GTB",
                            Color = "Red",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9035),
                            EngineCapacity = 3.9m,
                            Image = "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg",
                            IsActive = true,
                            ManufacturingYear = 2022,
                            Millage = 1000,
                            PlateNumber = "34AA21",
                            Price = 300000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9034)
                        },
                        new
                        {
                            VehicleId = 7,
                            AdditionalInformation = "Excellent condition, one owner",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Lamborghini Huracan",
                            Color = "Yellow",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9039),
                            EngineCapacity = 5.2m,
                            Image = "https://w.forfun.com/fetch/03/033f1bda44fe68f0aaa4db19f84a2e54.jpeg",
                            IsActive = true,
                            ManufacturingYear = 2021,
                            Millage = 2000,
                            PlateNumber = "34AA21",
                            Price = 280000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9038)
                        },
                        new
                        {
                            VehicleId = 8,
                            AdditionalInformation = "Low mileage, well-maintained",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Porsche 911",
                            Color = "White",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9044),
                            EngineCapacity = 3.0m,
                            Image = "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900",
                            IsActive = true,
                            ManufacturingYear = 2020,
                            Millage = 5000,
                            PlateNumber = "34AA21",
                            Price = 180000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9043)
                        },
                        new
                        {
                            VehicleId = 9,
                            AdditionalInformation = "Excellent condition, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Aston Martin DB11",
                            Color = "Black",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9050),
                            EngineCapacity = 5.2m,
                            Image = "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg",
                            IsActive = true,
                            ManufacturingYear = 2019,
                            Millage = 6000,
                            PlateNumber = "34AA21",
                            Price = 250000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9048)
                        },
                        new
                        {
                            VehicleId = 10,
                            AdditionalInformation = "Like new, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "McLaren 720S",
                            Color = "Orange",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9054),
                            EngineCapacity = 4.0m,
                            Image = "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg",
                            IsActive = true,
                            ManufacturingYear = 2021,
                            Millage = 4000,
                            PlateNumber = "34AA21",
                            Price = 280000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9053)
                        },
                        new
                        {
                            VehicleId = 11,
                            AdditionalInformation = "Rare, collector's item",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Bugatti Chiron",
                            Color = "Blue",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9059),
                            EngineCapacity = 8.0m,
                            Image = "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg",
                            IsActive = true,
                            ManufacturingYear = 2018,
                            Millage = 3000,
                            PlateNumber = "34AA21",
                            Price = 350000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9057)
                        },
                        new
                        {
                            VehicleId = 12,
                            AdditionalInformation = "High-performance masterpiece",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Koenigsegg Jesko",
                            Color = "Silver",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9063),
                            EngineCapacity = 5.0m,
                            Image = "https://wallpapercave.com/wp/wp5031567.jpg",
                            IsActive = true,
                            ManufacturingYear = 2022,
                            Millage = 1500,
                            PlateNumber = "34AA21",
                            Price = 400000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9062)
                        },
                        new
                        {
                            VehicleId = 13,
                            AdditionalInformation = "Hybrid supercar, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Ferrari SF90 Stradale",
                            Color = "Red",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9067),
                            EngineCapacity = 4.0m,
                            Image = "https://4kwallpapers.com/images/wallpapers/novitec-ferrari-sf90-stradale-2022-5k-8k-2880x1800-8481.jpeg",
                            IsActive = true,
                            ManufacturingYear = 2021,
                            Millage = 2000,
                            PlateNumber = "34AA21",
                            Price = 275000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9066)
                        },
                        new
                        {
                            VehicleId = 14,
                            AdditionalInformation = "Exotic masterpiece, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Pagani Huayra",
                            Color = "Green",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9072),
                            EngineCapacity = 6.0m,
                            Image = "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg",
                            IsActive = true,
                            ManufacturingYear = 2020,
                            Millage = 2500,
                            PlateNumber = "34AA21",
                            Price = 320000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9071)
                        },
                        new
                        {
                            VehicleId = 15,
                            AdditionalInformation = "Luxury sports coupe",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Lexus LC 500",
                            Color = "Black",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9077),
                            EngineCapacity = 5.0m,
                            Image = "https://wallpapercave.com/wp/wp6603188.jpg",
                            IsActive = true,
                            ManufacturingYear = 2019,
                            Millage = 5000,
                            PlateNumber = "34AA21",
                            Price = 60000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9076)
                        },
                        new
                        {
                            VehicleId = 16,
                            AdditionalInformation = "High-performance electric car",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Tesla Model S",
                            Color = "Blue",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9081),
                            EngineCapacity = 0.0m,
                            Image = "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg",
                            IsActive = true,
                            ManufacturingYear = 2022,
                            Millage = 1500,
                            PlateNumber = "34AA21",
                            Price = 90000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9080)
                        },
                        new
                        {
                            VehicleId = 17,
                            AdditionalInformation = "Luxury sports car, low mileage",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Audi R8",
                            Color = "Silver",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9086),
                            EngineCapacity = 5.2m,
                            Image = "https://wallpapercave.com/wp/wp8343229.jpg",
                            IsActive = true,
                            ManufacturingYear = 2021,
                            Millage = 3000,
                            PlateNumber = "34AA21",
                            Price = 120000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9085)
                        },
                        new
                        {
                            VehicleId = 18,
                            AdditionalInformation = "High-performance luxury car",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Mercedes-AMG GT",
                            Color = "Black",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9091),
                            EngineCapacity = 4.0m,
                            Image = "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg",
                            IsActive = true,
                            ManufacturingYear = 2020,
                            Millage = 4000,
                            PlateNumber = "34AA21",
                            Price = 110000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9090)
                        },
                        new
                        {
                            VehicleId = 19,
                            AdditionalInformation = "High-performance Japanese sports car",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Nissan GT-R",
                            Color = "Blue",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9099),
                            EngineCapacity = 3.8m,
                            Image = "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg",
                            IsActive = true,
                            ManufacturingYear = 2021,
                            Millage = 2500,
                            PlateNumber = "34AA21",
                            Price = 95000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9097)
                        },
                        new
                        {
                            VehicleId = 20,
                            AdditionalInformation = "High-performance American muscle car",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Ford Mustang Shelby GT500",
                            Color = "Red",
                            EndTime = new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9103),
                            EngineCapacity = 5.2m,
                            Image = "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg",
                            IsActive = true,
                            ManufacturingYear = 2022,
                            Millage = 1500,
                            PlateNumber = "34AA21",
                            Price = 75000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9102)
                        },
                        new
                        {
                            VehicleId = 21,
                            AdditionalInformation = "Sports car with exceptional handling",
                            AuctionPrice = 0.0,
                            BrandAndModel = "Porsche Cayman GT4",
                            Color = "Yellow",
                            EndTime = new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9107),
                            EngineCapacity = 4.0m,
                            Image = "https://media.porsche.com/mediakit/718-cayman-gt4-rs/00-photos/media-drive/718-Cayman-GT4-RS-GT-silbermetallic-S-GO1306/image-thumb__47840__mk2-modal-item/porschecayman_estoril07005_high_1.jpg",
                            IsActive = true,
                            ManufacturingYear = 2021,
                            Millage = 3500,
                            PlateNumber = "34AA21",
                            Price = 95000.00m,
                            SellerId = "a0f7d450-2823-4757-bd02-248ca71de618",
                            StartTime = new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9106)
                        });
                });

            modelBuilder.Entity("DataAccess.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DataAccess.Domain.Bid", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", "User")
                        .WithMany("Bids")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Domain.Vehicle", "Vehicle")
                        .WithMany("Bids")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("DataAccess.Domain.PaymentHistory", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", "User")
                        .WithMany("PaymentHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("DataAccess.Domain.Vehicle", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", "Seller")
                        .WithMany("Vehicles")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Domain.Vehicle", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("DataAccess.Models.ApplicationUser", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("PaymentHistories");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
