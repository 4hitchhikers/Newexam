using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace newexam.Models
{
    public class User {
        
        public int UserId { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }
        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }

    }
}