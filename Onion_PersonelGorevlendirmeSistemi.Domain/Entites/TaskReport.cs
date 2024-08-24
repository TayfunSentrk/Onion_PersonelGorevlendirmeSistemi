using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class TaskReport
    {
        public int Id { get; set; }
        public string Definition { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int AppTaskId { get; set; } //Hangi göreve ait olduğu
    }
}
