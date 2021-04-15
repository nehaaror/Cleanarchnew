using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using CleanarchApplcation.Interfaces;
using CleanarchApplcation.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ICourseService,CourseService>();
            //Infra.data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
