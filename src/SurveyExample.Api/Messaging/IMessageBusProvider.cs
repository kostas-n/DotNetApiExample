using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SurveyExample.Api.Messaging
{
	public interface IMessageBusProvider
	{
		Task<IBusControl> CreateBus(CancellationToken cancellationToken);
	}
}
