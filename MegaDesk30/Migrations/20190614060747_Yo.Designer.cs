﻿// <auto-generated />
using System;
using MegaDesk30.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDesk30.Migrations
{
    [DbContext(typeof(MegaDesk30Context))]
    [Migration("20190614060747_Yo")]
    partial class Yo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDesk30.Models.Delivery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MatertialType");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("MegaDesk30.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("depth");

                    b.Property<int?>("newMaterialID");

                    b.Property<int>("numDrawers");

                    b.Property<int>("width");

                    b.HasKey("ID");

                    b.HasIndex("newMaterialID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDesk30.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customerName");

                    b.Property<decimal>("deskPrice");

                    b.Property<int?>("newDeskID");

                    b.Property<DateTime>("quoteDate");

                    b.Property<decimal>("rushDays");

                    b.Property<decimal>("shippingCost");

                    b.HasKey("ID");

                    b.HasIndex("newDeskID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegaDesk30.Models.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaterialType");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.ToTable("Material_1");
                });

            modelBuilder.Entity("MegaDesk30.Models.Desk", b =>
                {
                    b.HasOne("MegaDesk30.Models.Material", "newMaterial")
                        .WithMany()
                        .HasForeignKey("newMaterialID");
                });

            modelBuilder.Entity("MegaDesk30.Models.DeskQuote", b =>
                {
                    b.HasOne("MegaDesk30.Models.Desk", "newDesk")
                        .WithMany()
                        .HasForeignKey("newDeskID");
                });
#pragma warning restore 612, 618
        }
    }
}