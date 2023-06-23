using SurveyExample.Api.Dtos;
using SurveyExample.Common;
using SurveyExample.Domain.WriteModels.Responses;
using SurveyExample.Domain.Events;
using SurveyExample.Domain.Events.Public;
//using SurveyExample.Infrastructure.EventsDispatching;
using SurveyExample.Infrastructure.Repositories;
using MassTransit;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Response = SurveyExample.Domain.WriteModels.Responses.Response;

namespace SurveyExample.Api.Commands
{
	public class SubmitResponseCommand : IRequest<Response>
	{
		public string ResponseId { get; }

		public SubmitResponseCommand(string responseId)
		{
			ResponseId = responseId;
		}
	}

	public class SubmitResponseCommandHandler : IRequestHandler<SubmitResponseCommand, Response>
	{
		private IResponsesRepository _responsesRepo;
		private IBusControl _busControl;

		public SubmitResponseCommandHandler(IResponsesRepository responsesRepo, IBusControl busControl)
		{
			_responsesRepo = responsesRepo;
			_busControl = busControl;
		}

		public async Task<Response> Handle(SubmitResponseCommand request, CancellationToken cancellationToken)
		{
			var response = await _responsesRepo.GetResponseById(Guid.Parse(request.ResponseId));

			response.Submit();

			await _responsesRepo.Save();

			await _busControl.Publish(message: new ResponseSubmittedEvent()
			{
				ResponseId = response.ResponseId,
				SurveyId = response.SurveyId,
				SubmittedDate = response.SubmittedDate.Value
			});
			return response;
		}
	}
}
