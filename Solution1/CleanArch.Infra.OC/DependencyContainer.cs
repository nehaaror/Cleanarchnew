using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.infra.bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using CleanarchApplcation.Interfaces;
using CleanarchApplcation.Services;
using MediatR;
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
            //Domain InMemoryBus mediatR
            services.AddScoped<IMediatorhandler, InMemorybus>();
            //Domain handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandhandler>();
            //Application layer
            services.AddScoped<ICourseService,CourseService>();
            //Infra.data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            //to remove dependency of infra.data layer with presentation layer
            services.AddScoped<UniversityDBContext>();


        }
    }
}
