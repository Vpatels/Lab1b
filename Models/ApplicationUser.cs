﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab_1B.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
       
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastNAme { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
