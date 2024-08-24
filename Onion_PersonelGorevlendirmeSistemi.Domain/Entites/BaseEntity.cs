using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Domain.Entites
{
    public class BaseEntity
    {
        public int Id { get; set; } //Tüm entity olan ortak Id için ortak bir BaseEntity Sınıfı Oluşturuldu
    }
}
