using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DummyBazaarWebApp.Models
{
    public class Manager
    {
        public int ID { get; set; }

        public int ManagerType_ID { get; set; }

        [ForeignKey("ManagerType_ID")]
        public virtual ManagerType ManagerType { get; set; }

        [Required(ErrorMessage="Bu alan zorunludur")]
       [StringLength(maximumLength:50,ErrorMessage ="En fazla 50 karakter olabilir")]
        public string Name { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 50 karakter olabilir")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur")]
        [StringLength(maximumLength:50,ErrorMessage ="En fazla 50 karakter olabilir")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "Şifre 8 ile 20 karakter olabilir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 250, ErrorMessage = "En fazla 250 karakter olabilir")]
        public string Mail { get; set; }

        public bool IsActive { get; set; }

    }
}