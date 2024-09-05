using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class AppUser:BaseEntity
    {
   
        public string UserName { get; set; } = null!; //UserName boş geçilmemesi sağlandı

        public string Password { get; set; } = null!;//Şifre boş geçilmemesi sağlandı
        public string Name { get; set; } = null!; //İsim boş geçilmemesi sağlandı
        public string Surname { get; set; } = null!;//Soyİsim boş geçilmemesi sağlandı
        public int AppRoleId { get; set; }

        #region Navigation_Property
        public AppRole? AppRole { get; set; } //Navigation Property ? işaretleyerek null olabilir  
        public List<AppTask>? AppTasks { get; set; }

        public List<Notification>? Notifications { get; set; }
        #endregion

    }
}
