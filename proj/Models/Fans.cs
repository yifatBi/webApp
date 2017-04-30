using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace proj.Models
{
    public class Fan
    {
        public int FanId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        [Required]
        public int Seniority { get; set; }
    }
    public class FansDb : DbContext
    {
        public int FanId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        [Required]
        public int Seniority { get; set; }

        public System.Data.Entity.DbSet<proj.Models.Fan> Fans { get; set; }
    }
    public enum Gender { Female,Male };

}