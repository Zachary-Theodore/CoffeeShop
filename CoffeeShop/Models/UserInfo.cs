using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class UserInfo
    {
        [Required]
        [RegularExpression("^[A-Za-z]{1,30}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("^[A-Za-z]{1,30}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,10}.[a-z]{2,3}$")]
        public string Email { set; get; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}|\d{10}|\d{3} \d{3} \d{4}$")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]{8,16}$")]
        public string Password { set; get; }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Password = "";
        }

        public UserInfo(string fn, string ln, string em, string pn, string pw)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            PhoneNumber = pn;
            Password = pw;
        }




    }
}