using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanarchApplcation.ViewModels
{
   public  class CourseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImagURL { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}
