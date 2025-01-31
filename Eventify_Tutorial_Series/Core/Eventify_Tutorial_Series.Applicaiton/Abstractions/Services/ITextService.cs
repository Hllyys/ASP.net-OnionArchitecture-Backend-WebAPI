using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.DTOs;

namespace Eventify_Tutorial_Series.Applicaiton.Abstractions.Services
{//file lı formatlandırmak için
	public interface ITextService
	{
		string FormaTextForEvent(IEnumerable<EventDto> eventItems);
	}
}
