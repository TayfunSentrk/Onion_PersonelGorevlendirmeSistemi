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
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(x => x.Description).IsRequired();//Description gerekli
            builder.Property(x => x.Description).HasMaxLength(500);//Description en fazla 500 karakter
            builder.Property(x => x.AppUserId).IsRequired(); //AppuserId gerekli
            builder.Property(x=>x.State).IsRequired();//State gerekli
         
           
        }
    }
}
