﻿// <auto-generated />
using System;
using AeroApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aeroapi.Migrations
{
    [DbContext(typeof(AeroContext))]
    partial class AeroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AeroApi.Model.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locais");
                });

            modelBuilder.Entity("AeroApi.Model.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Documento")
                        .HasColumnType("text");

                    b.Property<int>("Poltrona")
                        .HasColumnType("int");

                    b.Property<int>("VooId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VooId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("AeroApi.Model.Voo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataIda")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataVolta")
                        .HasColumnType("datetime");

                    b.Property<int>("LocalDestinoId")
                        .HasColumnType("int");

                    b.Property<int>("LocalOrigemId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroParadas")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<TimeSpan>("TempoIda")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TempoVolta")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("LocalDestinoId");

                    b.HasIndex("LocalOrigemId");

                    b.ToTable("Voos");
                });

            modelBuilder.Entity("AeroApi.Model.Reserva", b =>
                {
                    b.HasOne("AeroApi.Model.Voo", "Voo")
                        .WithMany()
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AeroApi.Model.Voo", b =>
                {
                    b.HasOne("AeroApi.Model.Local", "LocalDestino")
                        .WithMany()
                        .HasForeignKey("LocalDestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeroApi.Model.Local", "LocalOrigem")
                        .WithMany()
                        .HasForeignKey("LocalOrigemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
