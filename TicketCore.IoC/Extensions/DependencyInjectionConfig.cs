using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Application.Interfaces;
using TicketCore.Application.Services;
using TicketCore.Domain.Interfaces;
using TicketCore.Infrastructure.Context;
using TicketCore.Infrastructure.Repositories;

namespace TicketCore.IoC.Extensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
