using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Student
    {
      [Key]
        public int Student_Id { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public String SSN { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip_Code { get; set; }
        public String Phone { get; set; }
        public String EMail { get; set; }
        public DateTime DOB { get; set; }
        public String AboutMe { get; set; }
    }
}