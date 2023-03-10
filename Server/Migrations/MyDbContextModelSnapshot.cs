// <auto-generated />
using System;
using CRUD.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD.Server.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioRolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioRolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CRUD.Server.Models.UsuarioRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PermisoParaCrear")
                        .HasColumnType("bit");

                    b.Property<bool>("PermisoParaEditar")
                        .HasColumnType("bit");

                    b.Property<bool>("PermisoParaEliminar")
                        .HasColumnType("bit");

                    b.Property<int?>("UsuarioRolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioRolId");

                    b.ToTable("UsuariosRoles");
                });

            modelBuilder.Entity("CRUD.Server.Models.Usuario", b =>
                {
                    b.HasOne("CRUD.Server.Models.UsuarioRol", "UsuarioRol")
                        .WithMany()
                        .HasForeignKey("UsuarioRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioRol");
                });

            modelBuilder.Entity("CRUD.Server.Models.UsuarioRol", b =>
                {
                    b.HasOne("CRUD.Server.Models.UsuarioRol", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioRolId");
                });

            modelBuilder.Entity("CRUD.Server.Models.UsuarioRol", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
