﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Data;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20231030090835_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web.Data.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at")
                        .HasAnnotation("Relational:JsonPropertyName", "created_at");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("created_by")
                        .HasAnnotation("Relational:JsonPropertyName", "created_by");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int")
                        .HasColumnName("deleted_by")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_by");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active")
                        .HasAnnotation("Relational:JsonPropertyName", "is_active");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted")
                        .HasAnnotation("Relational:JsonPropertyName", "is_deleted");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at")
                        .HasAnnotation("Relational:JsonPropertyName", "modified_at");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("modified_by")
                        .HasAnnotation("Relational:JsonPropertyName", "modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Web.Data.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at")
                        .HasAnnotation("Relational:JsonPropertyName", "created_at");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("created_by")
                        .HasAnnotation("Relational:JsonPropertyName", "created_by");

                    b.Property<DateTime?>("DateOfJoining")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_joining")
                        .HasAnnotation("Relational:JsonPropertyName", "date_of_joining");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int")
                        .HasColumnName("deleted_by")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_by");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email")
                        .HasAnnotation("Relational:JsonPropertyName", "email");

                    b.Property<DateTime?>("ExpirationDateOtp")
                        .HasColumnType("datetime2")
                        .HasColumnName("expiration_date_otp")
                        .HasAnnotation("Relational:JsonPropertyName", "expiration_date_otp");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("full_name")
                        .HasAnnotation("Relational:JsonPropertyName", "full_name");

                    b.Property<int>("IsActive")
                        .HasColumnType("int")
                        .HasColumnName("is_active")
                        .HasAnnotation("Relational:JsonPropertyName", "is_active");

                    b.Property<int?>("IsDeleted")
                        .HasColumnType("int")
                        .HasColumnName("is_deleted")
                        .HasAnnotation("Relational:JsonPropertyName", "is_deleted");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at")
                        .HasAnnotation("Relational:JsonPropertyName", "modified_at");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("modified_by")
                        .HasAnnotation("Relational:JsonPropertyName", "modified_by");

                    b.Property<int?>("OTP")
                        .HasColumnType("int")
                        .HasColumnName("otp")
                        .HasAnnotation("Relational:JsonPropertyName", "otp");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password")
                        .HasAnnotation("Relational:JsonPropertyName", "password");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id")
                        .HasAnnotation("Relational:JsonPropertyName", "role_id");

                    b.Property<string>("SaltKey")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("salt")
                        .HasAnnotation("Relational:JsonPropertyName", "salt");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name")
                        .HasAnnotation("Relational:JsonPropertyName", "user_name");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Web.Data.UsersRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("roles_id")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "roles_id");

                    b.Property<int?>("users_id")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "users_id");

                    b.HasKey("Id");

                    b.HasIndex("roles_id");

                    b.HasIndex("users_id");

                    b.ToTable("users_roles");
                });

            modelBuilder.Entity("Web.Data.UsersRoles", b =>
                {
                    b.HasOne("Web.Data.Roles", "Roles")
                        .WithMany("UsersRoles")
                        .HasForeignKey("roles_id");

                    b.HasOne("Web.Data.Users", "Users")
                        .WithMany("UsersRoles")
                        .HasForeignKey("users_id");

                    b.Navigation("Roles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Web.Data.Roles", b =>
                {
                    b.Navigation("UsersRoles");
                });

            modelBuilder.Entity("Web.Data.Users", b =>
                {
                    b.Navigation("UsersRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
