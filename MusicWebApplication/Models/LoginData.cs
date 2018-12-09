using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MusicWebApplication.Models
{
    public class LoginData
    {
        public int UserID { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="LoginData-Errormessage, Field required")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "LoginData-Errormessage, Field required")]
        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}