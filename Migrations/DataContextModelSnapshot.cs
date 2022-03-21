﻿// <auto-generated />
using System;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("DatingApp.API.Models.Allocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activity1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activity2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activity3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BarnameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("FinalAcceptance")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FinalDecisionDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Hour")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsedUnit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BarnameId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Allocations");
                });

            modelBuilder.Entity("DatingApp.API.Models.Barname", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaravordNo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Barname");
                });

            modelBuilder.Entity("DatingApp.API.Models.BarnameGroup", b =>
                {
                    b.Property<int>("BarnameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BasicDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BarnameId", "BasicDataId");

                    b.HasIndex("BasicDataId");

                    b.ToTable("BarnameGroups");
                });

            modelBuilder.Entity("DatingApp.API.Models.BarnameNetwork", b =>
                {
                    b.Property<int>("BarnameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BasicDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BarnameId", "BasicDataId");

                    b.HasIndex("BasicDataId");

                    b.ToTable("BarnameNetworks");
                });

            modelBuilder.Entity("DatingApp.API.Models.BarnameProducer", b =>
                {
                    b.Property<int>("BarnameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BarnameId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("BarnameProducers");
                });

            modelBuilder.Entity("DatingApp.API.Models.BasicData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Parent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BasicDatas");
                });

            modelBuilder.Entity("DatingApp.API.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("DatingApp.API.Models.ProcessDataReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Activity")
                        .HasColumnType("TEXT");

                    b.Property<int>("ScreenplayId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ProcessDataRegs");
                });

            modelBuilder.Entity("DatingApp.API.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BasicDataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ResourceId");

                    b.HasIndex("BasicDataId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("DatingApp.API.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("DatingApp.API.Models.TimeSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hour")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TimeSections");
                });

            modelBuilder.Entity("DatingApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrgId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("photoUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DatingApp.API.Models.Allocation", b =>
                {
                    b.HasOne("DatingApp.API.Models.Barname", "Barname")
                        .WithMany()
                        .HasForeignKey("BarnameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barname");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("DatingApp.API.Models.Barname", b =>
                {
                    b.HasOne("DatingApp.API.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DatingApp.API.Models.BarnameGroup", b =>
                {
                    b.HasOne("DatingApp.API.Models.Barname", "Barname")
                        .WithMany("BarnameGroups")
                        .HasForeignKey("BarnameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.BasicData", "BasicData")
                        .WithMany()
                        .HasForeignKey("BasicDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barname");

                    b.Navigation("BasicData");
                });

            modelBuilder.Entity("DatingApp.API.Models.BarnameNetwork", b =>
                {
                    b.HasOne("DatingApp.API.Models.Barname", "Barname")
                        .WithMany("BarnameNetworks")
                        .HasForeignKey("BarnameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.BasicData", "BasicData")
                        .WithMany()
                        .HasForeignKey("BasicDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barname");

                    b.Navigation("BasicData");
                });

            modelBuilder.Entity("DatingApp.API.Models.BarnameProducer", b =>
                {
                    b.HasOne("DatingApp.API.Models.Barname", "Barname")
                        .WithMany("BarnameProducers")
                        .HasForeignKey("BarnameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.Person", "Producer")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barname");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DatingApp.API.Models.ProcessDataReg", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DatingApp.API.Models.Resource", b =>
                {
                    b.HasOne("DatingApp.API.Models.BasicData", "BasicData")
                        .WithMany()
                        .HasForeignKey("BasicDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicData");
                });

            modelBuilder.Entity("DatingApp.API.Models.Barname", b =>
                {
                    b.Navigation("BarnameGroups");

                    b.Navigation("BarnameNetworks");

                    b.Navigation("BarnameProducers");
                });

            modelBuilder.Entity("DatingApp.API.Models.User", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
