﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240722224733_TeamPlayers")]
    partial class TeamPlayers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("CasualMatchPlayer", b =>
                {
                    b.Property<int>("CasualMatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CasualMatchId", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("CasualMatchPlayers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("JoinCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<int>("MatchFormat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("JoinCode")
                        .IsUnique();

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Domain.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.Property<int>("MatchFormat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchMode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Matches");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Match");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CaptainId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JoinCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("LeagueId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CaptainId");

                    b.HasIndex("JoinCode")
                        .IsUnique();

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PlayerTeam", b =>
                {
                    b.Property<int>("PlayersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayersId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("PlayerTeam");
                });

            modelBuilder.Entity("Domain.Entities.CasualMatch", b =>
                {
                    b.HasBaseType("Domain.Entities.Match");

                    b.Property<int>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JoinCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Open")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AdminId");

                    b.HasIndex("JoinCode")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("CasualMatch");
                });

            modelBuilder.Entity("Domain.Entities.CompetitiveMatch", b =>
                {
                    b.HasBaseType("Domain.Entities.Match");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeagueId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LeagueId");

                    b.HasDiscriminator().HasValue("CompetitiveMatch");
                });

            modelBuilder.Entity("Domain.Entities.Player", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PreferredFoot")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isCaptain")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Player");
                });

            modelBuilder.Entity("CasualMatchPlayer", b =>
                {
                    b.HasOne("Domain.Entities.CasualMatch", null)
                        .WithMany()
                        .HasForeignKey("CasualMatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.League", b =>
                {
                    b.HasOne("Domain.Entities.Player", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Domain.Entities.Team", b =>
                {
                    b.HasOne("Domain.Entities.Player", "Captain")
                        .WithMany()
                        .HasForeignKey("CaptainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId");

                    b.Navigation("Captain");

                    b.Navigation("League");
                });

            modelBuilder.Entity("PlayerTeam", b =>
                {
                    b.HasOne("Domain.Entities.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.CasualMatch", b =>
                {
                    b.HasOne("Domain.Entities.Player", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Domain.Entities.CompetitiveMatch", b =>
                {
                    b.HasOne("Domain.Entities.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("League");
                });

            modelBuilder.Entity("Domain.Entities.League", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
