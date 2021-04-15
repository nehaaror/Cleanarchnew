using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanarchApplcation.ViewModels
{
   public  class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
