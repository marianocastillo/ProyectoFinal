using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TiendaAPI.Models;

#nullable disable

namespace TiendaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231202212943_infoStatic")]
    partial class infoStatic
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TiendaAPI.Models.Articulo", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdArticulo"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("integer");

                    b.Property<int>("IdColores")
                        .HasColumnType("integer");

                    b.Property<int>("IdSizes")
                        .HasColumnType("integer");

                    b.Property<string>("NombreArticulo")
                        .HasColumnType("text");

                    b.Property<byte[]>("imgArt")
                        .HasColumnType("bytea");

                    b.HasKey("IdArticulo");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdColores");

                    b.HasIndex("IdSizes");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("TiendaAPI.Models.Categorias", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCategoria"));

                    b.Property<string>("NombreCategoria")
                        .HasColumnType("text");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("TiendaAPI.Models.Colores", b =>
                {
                    b.Property<int>("idColores")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idColores"));

                    b.Property<string>("NameColores")
                        .HasColumnType("text");

                    b.HasKey("idColores");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("TiendaAPI.Models.Sizes", b =>
                {
                    b.Property<int>("idSizes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idSizes"));

                    b.Property<string>("SizeName")
                        .HasColumnType("text");

                    b.HasKey("idSizes");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("TiendaAPI.Models.Articulo", b =>
                {
                    b.HasOne("TiendaAPI.Models.Categorias", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TiendaAPI.Models.Colores", null)
                        .WithMany()
                        .HasForeignKey("IdColores")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TiendaAPI.Models.Sizes", null)
                        .WithMany()
                        .HasForeignKey("IdSizes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
