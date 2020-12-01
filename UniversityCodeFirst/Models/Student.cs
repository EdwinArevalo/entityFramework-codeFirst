﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityCodeFirst.Models
{
    public class Student: Person
    {  
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}