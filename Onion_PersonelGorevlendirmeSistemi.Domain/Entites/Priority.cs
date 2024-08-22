using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class Priority
    {
        public int Id { get; set; }
        public string Definition { get; set; } = null!;//Açıklama boş geçilemez
    }
}
