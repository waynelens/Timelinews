﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewCenter.DataAccess;

namespace NewCenter.Migrations
{
    [DbContext(typeof(DAOContext))]
    partial class DAOContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewCenter.Models.BookmarkModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<string>("RefNewsId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("NewCenter.Models.CommentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(Max)");

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<int>("RefNewsId")
                        .HasColumnType("int");

                    b.Property<int>("RefUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NewCenter.Models.NewsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<int>("RefSourceId")
                        .HasColumnType("int");

                    b.Property<string>("ThumbNail")
                        .HasColumnType("nvarchar(Max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(Max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NewCenter.Models.PermissionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("NewCenter.Models.SourceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(Max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<string>("RssFeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(Max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("NewCenter.Models.TagModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NewCenter.Models.TagedNewsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<int>("RefNewsId")
                        .HasColumnType("int");

                    b.Property<int>("RefTagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TagedNews");
                });

            modelBuilder.Entity("NewCenter.Models.UpvoteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<int>("RefNewsId")
                        .HasColumnType("int");

                    b.Property<int>("RefUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Upvotes");
                });

            modelBuilder.Entity("NewCenter.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avator")
                        .HasColumnType("nvarchar(Max)");

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(Max)");

                    b.Property<int>("RefCreatorId")
                        .HasColumnType("int");

                    b.Property<int>("RefEditorId")
                        .HasColumnType("int");

                    b.Property<int>("RefPermissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
