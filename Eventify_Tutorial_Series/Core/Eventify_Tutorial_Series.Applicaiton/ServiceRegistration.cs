using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services.Concreate;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series.Applicaiton
{
	public static class ServiceRegistration
	{
		public static void AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<ExportService>();
		}
	}
}
