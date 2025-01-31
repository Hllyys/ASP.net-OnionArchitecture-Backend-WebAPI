using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services;
using Eventify_Tutorial_Series.Applicaiton.DTOs;

namespace Eventify_Tutorial_Series.Infrastructure.Services
{
	public class TextService : ITextService
	{
		public string FormaTextForEvent(IEnumerable<EventDto> eventItems)
		{
			if (eventItems is null)
			{
				throw new ArgumentNullException(nameof(eventItems));
			}
			StringBuilder stringBuilder = new();//birden fazla ekleme işleminde string yerine stringbuilder kullanılır
			foreach (var eventItem in eventItems)
			{
				if (eventItem is not null)
				    stringBuilder.AppendLine($"Event:{eventItem.Title} - Location:{eventItem.location} - Date:{eventItem.Date.ToString("HH:mm - dd/MM/yyyy")}");
			}
			return stringBuilder.ToString().TrimEnd();

		}
	}
}
