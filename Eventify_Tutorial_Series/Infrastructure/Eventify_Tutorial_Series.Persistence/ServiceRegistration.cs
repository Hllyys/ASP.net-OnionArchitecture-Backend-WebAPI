using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services;
using Eventify_Tutorial_Series.Persistence.DbContexts;
using Eventify_Tutorial_Series.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddScoped<IEventService, EventService>();//talep edilen IEventservice yerine EventService nesnesi oluşturulacak.
			services.AddDbContext<EventifyDbContext>();//dbcontext kullanmak için gerekli
		}
	}
}
