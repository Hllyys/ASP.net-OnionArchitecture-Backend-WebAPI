using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.DTOs;
using Eventify_Tutorial_Series.Applicaiton.RequestParameters;
using Eventify_Tutorial_Series.Domain.Entities;
using Eventify_Tutorial_Series.Domain.ValueObjects;

namespace Eventify_Tutorial_Series.Applicaiton.Abstractions.Services
{
	public interface IEventService
	{
		Task CreateEventAsync(CreateEventDto createEventDto );
		Task<IEnumerable<EventDto>>GetAllEventsAsync(Pagination pagi);//tüm event teki değişkenleri dısarı açmamak için
	}
}
