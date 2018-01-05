using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Experience
    {
        [Key]
        public int Experience_Id { get; set; }
        public int Student_Id { get; set; }
        public String Hobbies_List { get; set; }
        public String Title { get; set; }
        public String CompanyName { get; set; }
        public String StartDate { get; set; }
        public String EndDate { get; set; }
        public String Description { get; set; }
    }
}
