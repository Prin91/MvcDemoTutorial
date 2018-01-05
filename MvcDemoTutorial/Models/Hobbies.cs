using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Hobbies
    { 
        [Key]
        public int Student_Id { get; set; }
        public String Hobbies_List { get; set; }
    }
}