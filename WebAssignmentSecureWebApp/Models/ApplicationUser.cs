using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebAssignmentSecureWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
       
            [Required]

            public string FirstName { get; set; }

            [Required]

            public string LastName { get; set; }

            [Required]

            public DateTime BirthDate { get; set; }
        
    }
}
