﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20221221170755_CreateViewEpisodes_View")]
    partial class CreateViewEpisodes_View
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Gosho Aoyama"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Rudyard Kipling"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Kozu Kozuha"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Guy Ritchie"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Akira Kurosawa"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Polly",
                            WhoPlayed = "Anneke Wills"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Zoe Heriot",
                            WhoPlayed = "Wendy Padbury"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Nyssa",
                            WhoPlayed = "Sarah Sutton"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Mickey Smith",
                            WhoPlayed = "Noel Clarke"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Nardole",
                            WhoPlayed = "Matt Lucas"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            DoctorName = "William",
                            DoctorNumber = 1
                        },
                        new
                        {
                            DoctorId = 2,
                            DoctorName = "Patrick",
                            DoctorNumber = 2
                        },
                        new
                        {
                            DoctorId = 3,
                            DoctorName = "Jon",
                            DoctorNumber = 3
                        },
                        new
                        {
                            DoctorId = 4,
                            DoctorName = "Tom",
                            DoctorNumber = 4
                        },
                        new
                        {
                            DoctorId = 5,
                            DoctorName = "Peter",
                            DoctorNumber = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Hunter",
                            EnemyName = "Hisoka"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Snow White and the Seven Dwarfs",
                            EnemyName = "Queen Grimhilde"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "Cinderella",
                            EnemyName = "Lady Tremaine"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "The lion is the king of the jungle",
                            EnemyName = "Scar"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "the little Mermaid",
                            EnemyName = "Ursula"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.Property<int>("EpisodeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("0");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Notes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(400)")
                        .HasDefaultValueSql("NULL");

                    b.Property<int>("SeriesNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 4,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2002, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Classic",
                            SeriesNumber = 1,
                            Title = "The Heirs of the Dragon"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 4,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2002, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Classic",
                            SeriesNumber = 1,
                            Title = "The Rogue Prince"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 5,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2002, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Classic",
                            SeriesNumber = 1,
                            Title = "Second of His Name"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2002, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Classic",
                            SeriesNumber = 2,
                            Title = "King of the Narrow Sea"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 1,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2002, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Classic",
                            SeriesNumber = 2,
                            Title = "We Light the Way"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"), 1L, 1);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 5,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 4,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 1,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 6,
                            CompanionId = 1,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeCompanionId = 7,
                            CompanionId = 3,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"), 1L, 1);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 3,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 4,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 1,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 6,
                            EnemyId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 7,
                            EnemyId = 3,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.ViewEpisodes", b =>
                {
                    b.Property<string>("Author_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Companions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enemies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToView("ViewEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", null)
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Doctor", null)
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
