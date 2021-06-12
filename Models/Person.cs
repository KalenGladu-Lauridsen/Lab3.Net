using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3Cs.Models
{
    public class Person
    {
        [Required]
        [StringLength(100)]
        [BindProperty(Name = "firstName")]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        [BindProperty(Name = "lastName")]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        [BindProperty(Name = "age")]
        public int Age
        {
            get;
            set;
        }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        [BindProperty(Name = "email")]
        public string EmailAddress
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Date)]
        [BindProperty(Name = "date")]
        public string BirthDay
        {
            get;
            set;
        }

        [Required]
        [StringLength(500)]
        [BindProperty(Name = "description")]
        public string PersonDescription
        {
            get;
            set;
        }
    }
}
