using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyExample.Common
{
	public interface IInternalEvent: INotification
	{
	}
}
