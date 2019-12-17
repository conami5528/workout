using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorkoutWeb.ViewModel
{
    public class Login_VM
    {
            [Required]
            public string ID { get; set; }
            [Required]
            public string Password { get; set; }      
    }
}