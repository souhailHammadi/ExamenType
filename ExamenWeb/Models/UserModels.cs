using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenWeb.Models
{
    public class UserModels
    {
        public int UserId { get; set; } 
        public String login { get; set; }
        public String password { get; set; }
        public String Mail { get; set; }
    }
}