using System;
using System.Collections.Generic;
using System.Text;
using CURDDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CURDDemo.Infrastructure.Persistence.EntityConfigurations
{
    public class ArticleEntityConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> articleConfiguration)
        {
            articleConfiguration.ToTable("Articles");

            articleConfiguration.HasKey(a => a.Id);
            articleConfiguration.Property(a => a.Id)
                .UseHiLo("articleseq");

            articleConfiguration.Property(a => a.Name).IsRequired();
            articleConfiguration.Property(a => a.Content).IsRequired();

            articleConfiguration.HasMany(a => a.Comments)
                .WithOne()
                .HasForeignKey(c => c.ArticleId);
        }
    }
}
