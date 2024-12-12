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
    public class TaskReportConfiguration : IEntityTypeConfiguration<TaskReport>
    {
        public void Configure(EntityTypeBuilder<TaskReport> builder)
        {
            builder.Property(x => x.Detail).IsRequired();//Detail zorunlu ve nvarcharmax olmalı
            builder.Property(x => x.Definition).IsRequired();//Definition zorunlu
            builder.Property(x => x.Definition).HasMaxLength(250); //Definition en fazla 250 karakter olmalı
            builder.Property(x=>x.AppTaskId).IsRequired();//AppTaskId zorunlu
        }
    }
}
