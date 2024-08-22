using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class Notification
    {
        public int Id { get; set; }

        public string Description { get; set; } = null!;//Açıklama boş geçilemez

        public bool State { get; set; } //Okundu okunmadı anlamında

        public int AppUserId { get; set; } //Hangi kullancıya gitmiş
    }
}
