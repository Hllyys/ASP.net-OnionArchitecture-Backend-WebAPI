using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventify_Tutorial_Series.Applicaiton.DTOs;
//burada yapılan işlem iki soyut yapıyı birleştirmek
//somut yapılar burada kullanılmaz print gibis
namespace Eventify_Tutorial_Series.Applicaiton.Abstractions.Services.Concreate
{
	public class ExportService
	{
		private readonly ITextService _textService;
		private readonly IFileService _fileService;

		public ExportService(IFileService fileService, ITextService textService)
		{
			_textService = textService;
			_fileService = fileService;
		}
		public async Task ExportEventsAsync(IEnumerable<EventDto> eventItems,string path)
		{
			var formattedText = _textService.FormaTextForEvent(eventItems);
			await _fileService.SaveTextAsync(formattedText,path);
		}
	}
}
