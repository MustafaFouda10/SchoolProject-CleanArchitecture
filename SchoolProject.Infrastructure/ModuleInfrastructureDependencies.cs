﻿using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.IRepositories;
using SchoolProject.Infrastructure.Repositories;

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        // we will register all Repos in this class (inside an Extension Method) instead of Program.cs class, then we will add the Extension Method in Program.cs class
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}