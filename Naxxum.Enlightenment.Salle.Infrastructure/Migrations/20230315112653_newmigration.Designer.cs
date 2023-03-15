﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Naxxum.Enlightenment.Salle.Infrastructure;

#nullable disable

namespace Naxxum.Enlightenment.Salle.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230315112653_newmigration")]
    partial class newmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Naxxum.Enlightenment.Salle.Domain.Entities.Bloc", b =>
                {
                    b.Property<int>("IdBloc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdBloc");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBloc"));

                    b.Property<string>("NomBloc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBloc");

                    b.ToTable("Bloc");
                });
#pragma warning restore 612, 618
        }
    }
}
