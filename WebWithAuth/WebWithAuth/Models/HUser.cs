using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebWithAuth.Models
{
    public class HUser
    {
        [Key]
        public int id { get; set; }
        public string UName { get; set; }
        public string Password { get; set; }
        
    }
}