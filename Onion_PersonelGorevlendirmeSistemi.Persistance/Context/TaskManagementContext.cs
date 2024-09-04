using Microsoft.EntityFrameworkCore;
using Onion_PersonelGorevlendirmeSistemi.Domain.Entites;
using Onion_PersonelGorevlendirmeSistemi.Persistance.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Persistance.Context
{
    public class TaskManagementContext:DbContext
    {
        public TaskManagementContext(DbContextOptions<TaskManagementContext> options):base(options) //Base'ikinci overloadında parametre olarak gönderiyorum
        {
            
        }

        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppTask> AppTasks { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<TaskReport> TaskReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppTaskConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new NotificationConfiguration());
            modelBuilder.ApplyConfiguration(new PriorityConfiguration());
            modelBuilder.ApplyConfiguration(new TaskReportConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
