using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models.Sınıflar
{
    public class İletisim
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string  Mail { get; set; }
        public string  Konu { get; set; }
        public string Mesaj { get; set; }

    }
}