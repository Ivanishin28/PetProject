// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetProject.EF;

#nullable disable

namespace PetProject.Migrations
{
    [DbContext(typeof(PetContext))]
    [Migration("20220719134600_RequiredLanguage")]
    partial class RequiredLanguage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetProject.EF.WordInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("WordId")
                        .IsUnique();

                    b.ToTable("WordInfos");
                });

            modelBuilder.Entity("PetProject.Models.Language", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("PetProject.Models.Theme", b =>
                {
                    b.Property<string>("ThemeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("newStr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThemeName");

                    b.HasIndex("LanguageName");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("PetProject.Models.Translation", b =>
                {
                    b.Property<string>("TranslationText")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TranslationText");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("PetProject.Models.Word", b =>
                {
                    b.Property<string>("WordText")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ThemeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WordInfoId")
                        .HasColumnType("int");

                    b.HasKey("WordText");

                    b.HasIndex("LanguageName");

                    b.HasIndex("ThemeId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("TranslationWord", b =>
                {
                    b.Property<string>("TranslationsTranslationText")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WordsWordText")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TranslationsTranslationText", "WordsWordText");

                    b.HasIndex("WordsWordText");

                    b.ToTable("TranslationWord");
                });

            modelBuilder.Entity("PetProject.EF.WordInfo", b =>
                {
                    b.HasOne("PetProject.Models.Word", "Word")
                        .WithOne("WordInfo")
                        .HasForeignKey("PetProject.EF.WordInfo", "WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Word");
                });

            modelBuilder.Entity("PetProject.Models.Theme", b =>
                {
                    b.HasOne("PetProject.Models.Language", "Language")
                        .WithMany("Themes")
                        .HasForeignKey("LanguageName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("PetProject.Models.Word", b =>
                {
                    b.HasOne("PetProject.Models.Language", "Language")
                        .WithMany("Words")
                        .HasForeignKey("LanguageName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetProject.Models.Theme", "Theme")
                        .WithMany("Words")
                        .HasForeignKey("ThemeId");

                    b.Navigation("Language");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("TranslationWord", b =>
                {
                    b.HasOne("PetProject.Models.Translation", null)
                        .WithMany()
                        .HasForeignKey("TranslationsTranslationText")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetProject.Models.Word", null)
                        .WithMany()
                        .HasForeignKey("WordsWordText")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetProject.Models.Language", b =>
                {
                    b.Navigation("Themes");

                    b.Navigation("Words");
                });

            modelBuilder.Entity("PetProject.Models.Theme", b =>
                {
                    b.Navigation("Words");
                });

            modelBuilder.Entity("PetProject.Models.Word", b =>
                {
                    b.Navigation("WordInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
