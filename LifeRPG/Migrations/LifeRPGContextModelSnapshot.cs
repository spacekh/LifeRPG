﻿// <auto-generated />
using System;
using LifeRPG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LifeRPG.Migrations
{
    [DbContext(typeof(LifeRPGContext))]
    partial class LifeRPGContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("LifeRPG.Models.AndroidMetadata", b =>
                {
                    b.Property<string>("Locale")
                        .HasColumnName("locale");

                    b.HasKey("Locale");

                    b.ToTable("android_metadata");
                });

            modelBuilder.Entity("LifeRPG.Models.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("_id");

                    b.Property<string>("Category")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<long?>("ExpirationDate")
                        .HasColumnName("expirationDate");

                    b.Property<long?>("HasExpirationReminder")
                        .HasColumnName("hasExpirationReminder");

                    b.Property<string>("Icon")
                        .HasColumnName("icon");

                    b.Property<long?>("IsActive")
                        .HasColumnName("isActive");

                    b.Property<long?>("IsConsumable")
                        .HasColumnName("isConsumable");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<long?>("QuantityAvailable")
                        .HasColumnName("quantityAvailable");

                    b.Property<long?>("QuantityConsumed")
                        .HasColumnName("quantityConsumed");

                    b.Property<long?>("RelativePosition")
                        .HasColumnName("relativePosition");

                    b.Property<long?>("RewardId")
                        .HasColumnName("rewardId");

                    b.Property<long?>("TimeCreated")
                        .HasColumnName("timeCreated");

                    b.Property<long?>("TimeLastConsumed")
                        .HasColumnName("timeLastConsumed");

                    b.Property<long?>("TimeUpdated")
                        .HasColumnName("timeUpdated");

                    b.Property<long?>("Value")
                        .HasColumnName("value");

                    b.Property<long?>("ValueUnits")
                        .HasColumnName("valueUnits");

                    b.HasKey("Id");

                    b.ToTable("inventory");
                });

            modelBuilder.Entity("LifeRPG.Models.Missions", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("_id");

                    b.Property<long>("Completed")
                        .HasColumnName("completed");

                    b.Property<long?>("Continuous")
                        .HasColumnName("continuous");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<long>("Difficulty")
                        .HasColumnName("difficulty");

                    b.Property<long?>("Duration")
                        .HasColumnName("duration");

                    b.Property<long?>("DurationUnits")
                        .HasColumnName("durationUnits");

                    b.Property<long>("Fear")
                        .HasColumnName("fear");

                    b.Property<long?>("HasLocation")
                        .HasColumnName("hasLocation");

                    b.Property<long?>("HasReminders")
                        .HasColumnName("hasReminders");

                    b.Property<string>("IconAsset")
                        .HasColumnName("iconAsset");

                    b.Property<long?>("Interval")
                        .HasColumnName("interval");

                    b.Property<long?>("IsDueAtSpecificTime")
                        .HasColumnName("isDueAtSpecificTime");

                    b.Property<double?>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<long?>("LevelCreated")
                        .HasColumnName("levelCreated");

                    b.Property<long?>("LevelDone")
                        .HasColumnName("levelDone");

                    b.Property<double?>("Longitude")
                        .HasColumnName("longitude");

                    b.Property<string>("Notes")
                        .HasColumnName("notes");

                    b.Property<long?>("Parent")
                        .HasColumnName("parent");

                    b.Property<long>("Productiveness")
                        .HasColumnName("productiveness");

                    b.Property<long?>("RelativePosition")
                        .HasColumnName("relativePosition");

                    b.Property<string>("Repetition")
                        .HasColumnName("repetition");

                    b.Property<long?>("RewardPoints")
                        .HasColumnName("rewardPoints");

                    b.Property<long?>("SeriesId")
                        .HasColumnName("seriesId");

                    b.Property<long?>("TimeCompleted")
                        .HasColumnName("timeCompleted");

                    b.Property<long>("TimeCreated")
                        .HasColumnName("timeCreated");

                    b.Property<long?>("TimeDue")
                        .HasColumnName("timeDue");

                    b.Property<long?>("TimeUpdated")
                        .HasColumnName("timeUpdated");

                    b.Property<string>("Title")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("missions");
                });

            modelBuilder.Entity("LifeRPG.Models.Profile", b =>
                {
                    b.Property<string>("Setting")
                        .HasColumnName("setting");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("Setting");

                    b.ToTable("profile");
                });

            modelBuilder.Entity("LifeRPG.Models.Profiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("RewardPoints");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("LifeRPG.Models.Reminders", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("_id");

                    b.Property<long?>("JobId")
                        .HasColumnName("jobId");

                    b.Property<long?>("ObjectId")
                        .HasColumnName("objectId");

                    b.Property<long?>("ObjectType")
                        .HasColumnName("objectType");

                    b.Property<long?>("ReminderAmount")
                        .HasColumnName("reminderAmount");

                    b.Property<long?>("ReminderUnits")
                        .HasColumnName("reminderUnits");

                    b.HasKey("Id");

                    b.ToTable("reminders");
                });

            modelBuilder.Entity("LifeRPG.Models.Rewards", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("_id");

                    b.Property<long?>("AddsToInventory")
                        .HasColumnName("addsToInventory");

                    b.Property<string>("Category")
                        .HasColumnName("category");

                    b.Property<long?>("ClaimTotal")
                        .HasColumnName("claimTotal");

                    b.Property<long?>("Cost")
                        .HasColumnName("cost");

                    b.Property<long?>("CostIncrement")
                        .HasColumnName("costIncrement");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("IconAsset")
                        .HasColumnName("iconAsset");

                    b.Property<long?>("IsCostIncrementing")
                        .HasColumnName("isCostIncrementing");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<long?>("QuantityAvailable")
                        .HasColumnName("quantityAvailable");

                    b.Property<long?>("TimeCreated")
                        .HasColumnName("timeCreated");

                    b.Property<long?>("TimeLastUpdated")
                        .HasColumnName("timeLastUpdated");

                    b.Property<long?>("TimeUpdated")
                        .HasColumnName("timeUpdated");

                    b.HasKey("Id");

                    b.ToTable("rewards");
                });

            modelBuilder.Entity("LifeRPG.Models.SkillDetails", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("_id");

                    b.Property<string>("Category")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Icon")
                        .HasColumnName("icon");

                    b.Property<string>("Notes")
                        .HasColumnName("notes");

                    b.Property<string>("Skill")
                        .HasColumnName("skill");

                    b.Property<long?>("StartingXp")
                        .HasColumnName("startingXP");

                    b.HasKey("Id");

                    b.ToTable("skillDetails");
                });

            modelBuilder.Entity("LifeRPG.Models.Skills", b =>
                {
                    b.Property<string>("Skill")
                        .HasColumnName("skill");

                    b.Property<long>("MissionId")
                        .HasColumnName("missionId");

                    b.HasKey("Skill", "MissionId");

                    b.ToTable("skills");
                });

            modelBuilder.Entity("LifeRPG.ViewModels.ProfileViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("RewardPoints");

                    b.Property<string>("Title");

                    b.Property<int>("XP");

                    b.HasKey("Id");

                    b.ToTable("ProfileViewModel");
                });
#pragma warning restore 612, 618
        }
    }
}
