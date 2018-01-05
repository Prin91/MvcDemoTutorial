using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemoTutorial.Models
{
    public class Project
    {
        [Key]
        public int Project_Id { get; set; }
        public int Student_Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public String URL { get; set; }
    }
}

