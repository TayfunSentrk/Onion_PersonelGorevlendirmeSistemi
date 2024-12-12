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
    public class AppTaskConfiguration : IEntityTypeConfiguration<AppTask>
    {
        public void Configure(EntityTypeBuilder<AppTask> builder)
        {
            builder.Property(x => x.PriorityId).IsRequired();//PriorityId mutlaka olması lazım
            builder.Property(x => x.AppUserId).IsRequired();//AppUserId gerekli
            builder.Property(x => x.Description).IsRequired();//Description gerekli
            builder.Property(x => x.Title).IsRequired();//Title gerekli
            builder.Property(x => x.Title).HasMaxLength(250);//Title en fazla 250 karakter
            builder.HasMany(x => x.TaskReports).WithOne(x => x.AppTask).HasForeignKey(x => x.AppTaskId);//AppTask ile TaskReport tarafında bire çok ilişki var
      
        }
    }
}
