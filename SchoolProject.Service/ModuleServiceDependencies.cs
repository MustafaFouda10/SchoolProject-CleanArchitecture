﻿using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.IRepositories;
using SchoolProject.Infrastructure.Repositories;
using SchoolProject.Service.IServices;
using SchoolProject.Service.Services;

namespace SchoolProject.Service
{
    public static class ModuleServiceDependencies
    {
        // we will register all Services in this class (inside an Extension Method) instead of Program.cs class, then we will add the Extension Method in Program.cs class
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }

    }
}