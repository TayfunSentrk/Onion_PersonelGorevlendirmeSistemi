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
        public bool State { get; set; }
    }
}
