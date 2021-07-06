﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lectuner { get; set; }
        [Required(ErrorMessage = ".")]

        public string LectunerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }

    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}