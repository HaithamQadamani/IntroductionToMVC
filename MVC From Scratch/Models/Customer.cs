using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_From_Scratch.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //[Required]
        [Required(ErrorMessage ="Please, Enter Your Name")]
        //[EmailAddress]
        public string Name { get; set; }

        //[Required]
        [Required(ErrorMessage ="Please, Enter Your Address")]
        public string Address { get; set; }

        //[Required]
        [Required(ErrorMessage ="Please, Enter Your Age")]
        //[Range(25,85)]
        [Range(25,60,ErrorMessage ="Please, Enter Correct Age")]
        public int Age { get; set; }


        public Customer (int id, string name, string address, int age)
        {
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }

        public Customer()
        {

        }
    }
}