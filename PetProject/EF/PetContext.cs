using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PetProject.EF.EntityTypeConfigurations;
using PetProject.Filtering;
using PetProject.Models;

namespace PetProject.EF
{
    internal class PetContext : DbContext
    {
        public PetContext() { }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<WordInfo> WordInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new WordConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
            builder.ApplyConfiguration(new WordInfoConfiguration());

            builder.Entity<Translation>().HasKey(t => t.TranslationText);
            builder.Entity<Theme>().HasKey(t => t.ThemeName);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString
                   = @"data source = (localdb)\MSSQLLocalDB; database = PetProject;integrated security = true;";

            //string connectionString = "asd/dasasd//afsgas//asgasg";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public static IEnumerable<Word> GetFilteredWords
            (PetContext context, ISpecification<Word> specification)
        {
            return context
                .Words
                .AsNoTracking()
                .Include(w => w.Language)
                .Include(w => w.Translations)
                .Where(specification.IsSatisfied);
        }
    }
}
