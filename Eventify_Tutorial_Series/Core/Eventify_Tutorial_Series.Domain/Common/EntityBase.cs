using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Domain.Common
{
	public class EntityBase
	{
		public Guid Id { get; set; }
		public DateTimeOffset CreateDate { get; set; }
		public DateTimeOffset? UpdateDate { get; set; }
	}
}
