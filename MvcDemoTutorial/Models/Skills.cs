using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemoTutorial.Models
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