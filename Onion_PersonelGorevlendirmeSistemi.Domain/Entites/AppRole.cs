using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class AppRole:BaseEntity
    {
      
        public string Definition { get; set; } = null!;//Null olmaması için belirttim

        #region Navigation_Property
        public List<AppUser>? AppUsers { get; set; }  //Birden Fazla AppUser aynı role sahip olabilir
        #endregion
    }
}
