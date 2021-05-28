using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sharp5x2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //[CreditCard, MaxLength(16), MinLength(16)]
        //public DataType.CreaditCard CreditCard { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string UrlFacebook { get; set; }
        public string DateOfBirth { get; set; }

    }
}
