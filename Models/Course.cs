﻿using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
