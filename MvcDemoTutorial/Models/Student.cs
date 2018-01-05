using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemoTutorial.Models
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public String MiddleName { get; set; }
        [Display(Name = "Last Name")]
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
    