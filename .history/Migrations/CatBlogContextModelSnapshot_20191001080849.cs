﻿// <auto-generated />
using System;
using CatBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatBlog.Migrations
{
    [DbContext(typeof(CatBlogContext))]
    partial class CatBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("CatBlog.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Color");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cat");
                });
#pragma warning restore 612, 618
        }
    }
}