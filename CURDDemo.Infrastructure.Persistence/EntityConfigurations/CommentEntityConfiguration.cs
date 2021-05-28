using System;
using System.Collections.Generic;
using System.Text;
using CURDDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CURDDemo.Infrastructure.Persistence.EntityConfigurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> commentConfiguration)
        {
            commentConfiguration.ToTable("Comments");

            commentConfiguration.HasKey(a => a.Id);
            commentConfiguration.Property(a => a.Id)
                .UseHiLo("commentseq");
        }
    }
}
