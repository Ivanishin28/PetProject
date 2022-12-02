using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.EF.EntityTypeConfigurations
{
    internal class WordInfoConfiguration : IEntityTypeConfiguration<WordInfo>
    {
        public void Configure(EntityTypeBuilder<WordInfo> builder)
        {
            builder
                .Property(w => w.CurrentLocation)
                .IsConcurrencyToken();
        }
    }
}