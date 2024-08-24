using Microsoft.EntityFrameworkCore;
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
    }
}
