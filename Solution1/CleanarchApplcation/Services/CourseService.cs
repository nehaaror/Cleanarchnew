using CleanArch.Domain.Interfaces;
using CleanarchApplcation.Interfaces;
using CleanarchApplcation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanarchApplcation.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        
        CourseViewModel ICourseService.GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()                
                 
            };
                
                }
    }
}
