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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Surname).IsRequired();//soyisim gerekli
            builder.Property(x => x.Surname).HasMaxLength(200); //en fazla 200 karakter olmalı
            builder.Property(x=>x.Name).IsRequired(); // isim gerekli
            builder.Property(x => x.Surname).HasMaxLength(200);//en fazla 200 karakter olmalı
            builder.Property(x => x.Password).IsRequired();//şifre gerekli
            builder.Property(x => x.Password).HasMaxLength(200);//en fazla 200 karakter olmalı
            builder.HasIndex(x => x.UserName).IsUnique(); //username indexe sahip ve benzersiz olmalı
            builder.Property(x => x.UserName).HasMaxLength(200);//en fazla 200 karakter olmalı
            builder.Property(x => x.UserName).IsRequired();//username gerekli
            builder.Property(x => x.AppRoleId).IsRequired();//approleId olmalı
            builder.HasMany(x => x.AppTasks).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);//Appuser ile AppTask arasında bire çok ilişki var
            builder.HasMany(x => x.Notifications).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);//Appuser ile a Notifications arasında bire çok ilişki var
        }
    }
}
