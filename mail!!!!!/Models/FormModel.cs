using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mail_____.Models
{
    public class FormModel
    {
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }

        public DateTime Tarih { get; set; }
    }
}