using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Skills
    {
        [Key]
        public int Skill_Id { get; set; }
        public int Student_Id { get; set; }
        public String SkillName { get; set; }
        public String Skill_Level { get; set; }
    }
}