using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion_PersonelGorevlendirmeSistemi.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Persistance.Configurations
{
    public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.Property(x => x.Definition).IsRequired();//Definition gerekli
            builder.Property(x => x.Definition).HasMaxLength(250);//Definition en fazla 250 karakter olması lazım
            builder.HasMany(x => x.AppTasks).WithOne(x => x.Priority).HasForeignKey(x => x.PriorityId);//Priority ile AppTask arasında bire çok ilişki var
        }
    }
}
