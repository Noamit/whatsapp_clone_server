﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using whatsapp_WEBAPI.Data;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    [DbContext(typeof(whatsapp_WEBAPIContext))]
    [Migration("20220518110414_messagesNullable")]
    partial class messagesNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("whatsapp_WEBAPI.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("whatsapp_WEBAPI.Friend", b =>
                {
                    b.Property<int>("RealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RealId"), 1L, 1);

                    b.Property<string>("FriendOf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Lastdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RealId");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("whatsapp_WEBAPI.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FriendRealId")
                        .HasColumnType("int");

                    b.Property<bool?>("Send")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FriendRealId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("whatsapp_WEBAPI.Message", b =>
                {
                    b.HasOne("whatsapp_WEBAPI.Friend", null)
                        .WithMany("Messages")
                        .HasForeignKey("FriendRealId");
                });

            modelBuilder.Entity("whatsapp_WEBAPI.Friend", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
