using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;   // Displayname icin eklemeyi unutma
using System.ComponentModel.DataAnnotations;


namespace ValidationControls.Models
{
    public class Uyebil
    {
        public int Id { get; set; }


        [DisplayName("Kullanıcı adı")]

        public string kullaniciAd { get; set; }

        [DisplayName("Kullanıcı Şifre")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifre bilgisi minimum 6 karakter olmalıdır")]


        public string kullanicisifre { get; set; }

        [DisplayName("Şifre Tekrarı")]
        [Compare("kullanicisifre")]
        public string sifre2 { get; set; }


        [DisplayName("Email")]
        [EmailAddress()]
        [MaxLength(25, ErrorMessage = "Şifre bilgisi max 25 karakter olmalıdır")]
        public string email { get; set; }


    }
}