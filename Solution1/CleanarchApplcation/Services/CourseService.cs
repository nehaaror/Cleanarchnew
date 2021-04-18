using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
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
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorhandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorhandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImagURL);
            _bus.Sendcommand(createCourseCommand);

         
           
               
           
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
