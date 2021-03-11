﻿// <auto-generated />
using CAPP.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CAPP.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210226231030_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CAPP.Domain.Entities.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("KeyWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("OperationGroups");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationGroupOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OperationGroupId")
                        .HasColumnType("int");

                    b.Property<int>("OperationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperationGroupId");

                    b.HasIndex("OperationId");

                    b.ToTable("OperationGroupOperations");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("OperationObjects");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationOperationObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OperationId")
                        .HasColumnType("int");

                    b.Property<int>("OperationObjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.HasIndex("OperationObjectId");

                    b.ToTable("OperationOperationObjects");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationGroupOperation", b =>
                {
                    b.HasOne("CAPP.Domain.Entities.OperationGroup", "OperationGroup")
                        .WithMany()
                        .HasForeignKey("OperationGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CAPP.Domain.Entities.Operation", "Operation")
                        .WithMany("OperationGroupOperations")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");

                    b.Navigation("OperationGroup");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationOperationObject", b =>
                {
                    b.HasOne("CAPP.Domain.Entities.Operation", "Operation")
                        .WithMany()
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CAPP.Domain.Entities.OperationObject", "OperationObject")
                        .WithMany("OperationOperationObjects")
                        .HasForeignKey("OperationObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");

                    b.Navigation("OperationObject");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.Operation", b =>
                {
                    b.Navigation("OperationGroupOperations");
                });

            modelBuilder.Entity("CAPP.Domain.Entities.OperationObject", b =>
                {
                    b.Navigation("OperationOperationObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
