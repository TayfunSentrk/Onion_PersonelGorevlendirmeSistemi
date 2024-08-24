using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class AppTask:BaseEntity
    {
   
        public string Title { get; set; } = null!; //boş geçilmemesi sağlandı

        public string? Description { get; set; } //boş geçilebilir

        public int AppUserId { get; set; }
        public int PriorityId { get; set; }

        #region Navigation_Property
        public Priority? Priority { get; set; }
        public AppUser? AppUser { get; set; }

        public List<TaskReport>? TaskReports { get; set; }
        #endregion
        public bool State { get; set; }
    }
}
