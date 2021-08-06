using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Configuration;

namespace ConsoleApp.ORM
{
    [Table("Student_Info")]
    public class Student
    {
        [Key]
        [Column("StudentId")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        public Gender Gender { get; set; }
    }

    public class Teachers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        public Gender Gender { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Standard Class { get; set; }

        public int? TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teachers Teacher { get; set; }
    }

    public class Standard
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
    }

    public enum Gender
    {
        Female = 1,
        Male = 0,
        Others = 2
    }
}