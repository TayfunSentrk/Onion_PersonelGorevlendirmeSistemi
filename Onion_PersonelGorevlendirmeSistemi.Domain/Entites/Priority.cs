using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class Priority:BaseEntity
    {
      
        public string Definition { get; set; } = null!;//Açıklama boş geçilemez

        #region Navigation_Property
        public List<AppTask>? AppTasks { get; set; } 
        #endregion
    }
}
