using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SurveyExample.Common
{
	public interface IReadModelGenerator<T> where T : IInternalEvent
	{
		Task HandleEvent(T @event);
	}
}
