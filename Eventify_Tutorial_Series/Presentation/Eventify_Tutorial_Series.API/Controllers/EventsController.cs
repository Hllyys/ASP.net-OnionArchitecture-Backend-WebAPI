using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services.Concreate;
using Eventify_Tutorial_Series.Applicaiton.DTOs;
using Eventify_Tutorial_Series.Applicaiton.RequestParameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventify_Tutorial_Series.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EventsController : ControllerBase
	{
		private readonly IEventService _eventService;
		private readonly ExportService _exportService;//textlerin çıktı vermesi için

		public EventsController(IEventService eventService, ExportService exportService)
		{
			_eventService = eventService;
			_exportService = exportService;
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetAllEvents([FromQuery]Pagination pagination)
		{
			var events= await _eventService.GetAllEventsAsync(pagination);
			return Ok();
		}

		[HttpPost("[action]")]

		public async Task<IActionResult> CreateEvent(CreateEventDto createEventDto)
		{
			await _eventService.CreateEventAsync(createEventDto);
			return Ok();
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> ExportEvents([FromQuery]Pagination pagination,string path)
		{
			var events = await _eventService.GetAllEventsAsync(pagination);
			await _exportService.ExportEventsAsync(events, path);
			return Ok();	
		}
	}
}
