using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services;
using Eventify_Tutorial_Series.Applicaiton.DTOs;
using Eventify_Tutorial_Series.Applicaiton.RequestParameters;
using Eventify_Tutorial_Series.Domain.Entities;
using Eventify_Tutorial_Series.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Eventify_Tutorial_Series.Persistence.Services
{
	public class EventService : IEventService
	{
		private readonly EventifyDbContext _context;
		public EventService(EventifyDbContext context)
		{
			_context = context;
		}
		public async Task CreateEventAsync(CreateEventDto createEventDto)
		{
			if (createEventDto is not null)
			{
				var newEvent = new Event()
				{
					Title = createEventDto.Title,
					Date = createEventDto.Date,
					Location = createEventDto.Location,
				};
				_context.Events.Add(newEvent);//AWAİT
			    _context.SaveChanges();//AWAİT	
			}
			else
			{
				throw new NullReferenceException();
			}
		}
		public async Task<IEnumerable<EventDto>> GetAllEventsAsync(Pagination pagination)
		{
			return await _context.Events
				.AsNoTracking()
				.Select( x => new EventDto()
			{
				Title = x.Title,
				Date = x.Date,
				Location = x.Location,
			})
				.Skip(pagination.PageCount * pagination.ItemCount)
				.Take(pagination.ItemCount)
				.ToListAsync();
		}

	}
}
