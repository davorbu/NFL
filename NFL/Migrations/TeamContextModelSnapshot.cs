﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NFL.Models;

#nullable disable

namespace NFL.Migrations
{
    [DbContext(typeof(TeamContext))]
    partial class TeamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NFL.Models.Conference", b =>
                {
                    b.Property<string>("ConferenceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConferenceID");

                    b.ToTable("Conferences");

                    b.HasData(
                        new
                        {
                            ConferenceID = "afc",
                            Name = "AFC"
                        },
                        new
                        {
                            ConferenceID = "nfc",
                            Name = "NFC"
                        });
                });

            modelBuilder.Entity("NFL.Models.Division", b =>
                {
                    b.Property<string>("DivisionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DivisionID");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            DivisionID = "north",
                            Name = "North"
                        },
                        new
                        {
                            DivisionID = "south",
                            Name = "South"
                        },
                        new
                        {
                            DivisionID = "east",
                            Name = "East"
                        },
                        new
                        {
                            DivisionID = "west",
                            Name = "West"
                        });
                });

            modelBuilder.Entity("NFL.Models.Team", b =>
                {
                    b.Property<string>("TeamID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConferenceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DivisionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.HasIndex("ConferenceID");

                    b.HasIndex("DivisionID");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamID = "ari",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "ARI.png",
                            Name = "Arizona Cardinals"
                        },
                        new
                        {
                            TeamID = "atl",
                            ConferenceID = "nfc",
                            DivisionID = "south",
                            LogoImage = "ATL.png",
                            Name = "Atlanta Falcons"
                        },
                        new
                        {
                            TeamID = "bal",
                            ConferenceID = "afc",
                            DivisionID = "north",
                            LogoImage = "BAL.png",
                            Name = "Baltimore Ravens"
                        },
                        new
                        {
                            TeamID = "buf",
                            ConferenceID = "afc",
                            DivisionID = "east",
                            LogoImage = "BUF.png",
                            Name = "Buffalo Bills"
                        },
                        new
                        {
                            TeamID = "car",
                            ConferenceID = "nfc",
                            DivisionID = "south",
                            LogoImage = "CAR.png",
                            Name = "Carolina Panthers"
                        },
                        new
                        {
                            TeamID = "chi",
                            ConferenceID = "nfc",
                            DivisionID = "north",
                            LogoImage = "CHI.png",
                            Name = "Chicago Bears"
                        },
                        new
                        {
                            TeamID = "cin",
                            ConferenceID = "afc",
                            DivisionID = "north",
                            LogoImage = "CIN.png",
                            Name = "Cincinnati Bengals"
                        },
                        new
                        {
                            TeamID = "cle",
                            ConferenceID = "afc",
                            DivisionID = "north",
                            LogoImage = "CLE.png",
                            Name = "Cleveland Browns"
                        },
                        new
                        {
                            TeamID = "dal",
                            ConferenceID = "nfc",
                            DivisionID = "east",
                            LogoImage = "DAL.png",
                            Name = "Dallas Cowboys"
                        },
                        new
                        {
                            TeamID = "den",
                            ConferenceID = "afc",
                            DivisionID = "west",
                            LogoImage = "DEN.png",
                            Name = "Denver Broncos"
                        },
                        new
                        {
                            TeamID = "det",
                            ConferenceID = "nfc",
                            DivisionID = "north",
                            LogoImage = "DET.png",
                            Name = "Detroit Lions"
                        },
                        new
                        {
                            TeamID = "gb",
                            ConferenceID = "nfc",
                            DivisionID = "north",
                            LogoImage = "GB.png",
                            Name = "Green Bay Packers"
                        },
                        new
                        {
                            TeamID = "hou",
                            ConferenceID = "afc",
                            DivisionID = "south",
                            LogoImage = "HOU.png",
                            Name = "Houston Texans"
                        },
                        new
                        {
                            TeamID = "ind",
                            ConferenceID = "afc",
                            DivisionID = "south",
                            LogoImage = "IND.png",
                            Name = "Indianapolis Colts"
                        },
                        new
                        {
                            TeamID = "jax",
                            ConferenceID = "afc",
                            DivisionID = "south",
                            LogoImage = "JAX.png",
                            Name = "Jacksonville Jaguars"
                        },
                        new
                        {
                            TeamID = "kc",
                            ConferenceID = "afc",
                            DivisionID = "west",
                            LogoImage = "KC.png",
                            Name = "Kansas City Chiefs"
                        },
                        new
                        {
                            TeamID = "lac",
                            ConferenceID = "afc",
                            DivisionID = "west",
                            LogoImage = "LAC.png",
                            Name = "Los Angeles Chargers"
                        },
                        new
                        {
                            TeamID = "lar",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "LAR.png",
                            Name = "Los Angeles Rams"
                        },
                        new
                        {
                            TeamID = "mia",
                            ConferenceID = "afc",
                            DivisionID = "east",
                            LogoImage = "MIA.png",
                            Name = "Miami Dolphins"
                        },
                        new
                        {
                            TeamID = "min",
                            ConferenceID = "nfc",
                            DivisionID = "north",
                            LogoImage = "MIN.png",
                            Name = "Minnesota Vikings"
                        },
                        new
                        {
                            TeamID = "ne",
                            ConferenceID = "afc",
                            DivisionID = "east",
                            LogoImage = "NE.png",
                            Name = "New England Patriots"
                        },
                        new
                        {
                            TeamID = "no",
                            ConferenceID = "nfc",
                            DivisionID = "south",
                            LogoImage = "NO.png",
                            Name = "New Orleans Saints"
                        },
                        new
                        {
                            TeamID = "nyg",
                            ConferenceID = "nfc",
                            DivisionID = "east",
                            LogoImage = "NYG.png",
                            Name = "New York Giants"
                        },
                        new
                        {
                            TeamID = "nyj",
                            ConferenceID = "afc",
                            DivisionID = "east",
                            LogoImage = "NYJ.png",
                            Name = "New York Jets"
                        },
                        new
                        {
                            TeamID = "oak",
                            ConferenceID = "afc",
                            DivisionID = "west",
                            LogoImage = "OAK.png",
                            Name = "Oakland Raiders"
                        },
                        new
                        {
                            TeamID = "phi",
                            ConferenceID = "nfc",
                            DivisionID = "east",
                            LogoImage = "PHI.png",
                            Name = "Philadelphia Eagles"
                        },
                        new
                        {
                            TeamID = "pit",
                            ConferenceID = "afc",
                            DivisionID = "north",
                            LogoImage = "PIT.png",
                            Name = "Pittsburgh Steelers"
                        },
                        new
                        {
                            TeamID = "sea",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "SEA.png",
                            Name = "Seattle Seahawks"
                        },
                        new
                        {
                            TeamID = "sf",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "SF.png",
                            Name = "San Francisco 49ers"
                        },
                        new
                        {
                            TeamID = "tb",
                            ConferenceID = "nfc",
                            DivisionID = "south",
                            LogoImage = "TB.png",
                            Name = "Tampa Bay Buccaneers"
                        },
                        new
                        {
                            TeamID = "ten",
                            ConferenceID = "afc",
                            DivisionID = "south",
                            LogoImage = "TEN.png",
                            Name = "Tennessee Titans"
                        },
                        new
                        {
                            TeamID = "was",
                            ConferenceID = "nfc",
                            DivisionID = "east",
                            LogoImage = "WAS.png",
                            Name = "Washington Redskins"
                        });
                });

            modelBuilder.Entity("NFL.Models.Team", b =>
                {
                    b.HasOne("NFL.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceID");

                    b.HasOne("NFL.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID");

                    b.Navigation("Conference");

                    b.Navigation("Division");
                });
#pragma warning restore 612, 618
        }
    }
}
