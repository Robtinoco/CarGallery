// <auto-generated />
using CarGallery.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarGallery.Migrations
{
    [DbContext(typeof(CarGalleryDbContext))]
    partial class CarGalleryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CarGallery.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Porsche"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ferrari"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ford"
                        });
                });

            modelBuilder.Entity("CarGallery.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            ImageUrl = "/assets/porsche/porsche_911_Turbo.jpg",
                            LongDescription = "Sempre que um carro apresenta um comportamento irrepreensível, é difícil não nos perguntarmos como será possível fazer algo melhor em uma futura geração. Desde a primeira edição do 911 Turbo, em 1975, porém, os engenheiros da Porsche vêm conseguindo essa insuspeita superação e desta vez não foi diferente.",
                            Name = "Porsche 911 Turbo",
                            ShortDescription = "Porsche 911 Turbo S",
                            ThumbnailUrl = "/assets/porsche/porsche_911_Turbo_small.jpg"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            ImageUrl = "/assets/ford/ford_mustang.jpg",
                            LongDescription = "O Mustang GT é absolutamente a melhor forma de começar o dia, já que seu motor é uma joia. O V8 ainda mantém o nome de Coyote, mas não é quieto como o anterior. O motor esbraveja como o melhor muscle car de todos os tempos.",
                            Name = "Ford Mustang",
                            ShortDescription = "O melhor pony car",
                            ThumbnailUrl = "/assets/ford/ford_mustang_small.jpg"
                        });
                });

            modelBuilder.Entity("CarGallery.Models.Car", b =>
                {
                    b.HasOne("CarGallery.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CarGallery.Models.Brand", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
