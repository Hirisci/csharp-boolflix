﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix.Data;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(BoolflixContext))]
    partial class BoolflixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("ActorMediaInfo", b =>
                {
                    b.Property<int>("CastId")
                        .HasColumnType("int");

                    b.Property<int>("MediaInfosMediaInfoId")
                        .HasColumnType("int");

                    b.HasKey("CastId", "MediaInfosMediaInfoId");

                    b.HasIndex("MediaInfosMediaInfoId");

                    b.ToTable("ActorMediaInfo");
                });

            modelBuilder.Entity("Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TvSeriesId")
                        .HasColumnType("int");

                    b.Property<int>("VisualisationCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvSeriesId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("FeatureMediaInfo", b =>
                {
                    b.Property<int>("FeaturesId")
                        .HasColumnType("int");

                    b.Property<int>("MediaInfosMediaInfoId")
                        .HasColumnType("int");

                    b.HasKey("FeaturesId", "MediaInfosMediaInfoId");

                    b.HasIndex("MediaInfosMediaInfoId");

                    b.ToTable("FeatureMediaInfo");
                });

            modelBuilder.Entity("Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("GenreMediaInfo", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MediaInfosMediaInfoId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MediaInfosMediaInfoId");

                    b.HasIndex("MediaInfosMediaInfoId");

                    b.ToTable("GenreMediaInfo");
                });

            modelBuilder.Entity("MediaInfo", b =>
                {
                    b.Property<int>("MediaInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaInfoId"), 1L, 1);

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("TvSeriesId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaInfoId");

                    b.HasIndex("MovieId")
                        .IsUnique()
                        .HasFilter("[MovieId] IS NOT NULL");

                    b.HasIndex("TvSeriesId");

                    b.ToTable("MediaInfos");
                });

            modelBuilder.Entity("Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisualisationCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("TvSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<int>("SeasonsCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisualisationCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TvSeries");
                });

            modelBuilder.Entity("ActorMediaInfo", b =>
                {
                    b.HasOne("Actor", null)
                        .WithMany()
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaInfo", null)
                        .WithMany()
                        .HasForeignKey("MediaInfosMediaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Episode", b =>
                {
                    b.HasOne("TvSeries", "TvSerie")
                        .WithMany("Episodes")
                        .HasForeignKey("TvSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TvSerie");
                });

            modelBuilder.Entity("FeatureMediaInfo", b =>
                {
                    b.HasOne("Feature", null)
                        .WithMany()
                        .HasForeignKey("FeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaInfo", null)
                        .WithMany()
                        .HasForeignKey("MediaInfosMediaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMediaInfo", b =>
                {
                    b.HasOne("Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaInfo", null)
                        .WithMany()
                        .HasForeignKey("MediaInfosMediaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaInfo", b =>
                {
                    b.HasOne("Movie", "Movie")
                        .WithOne("MediaInfo")
                        .HasForeignKey("MediaInfo", "MovieId");

                    b.HasOne("TvSeries", "Serie")
                        .WithMany()
                        .HasForeignKey("TvSeriesId");

                    b.Navigation("Movie");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("Movie", b =>
                {
                    b.Navigation("MediaInfo");
                });

            modelBuilder.Entity("TvSeries", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}
