using AutoMapper;
using SurveyExample.Domain.Events.Internal;
using SurveyExample.Domain.WriteModels.Responses;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SurveyExample.Api.Notifications
{
	public interface INotificationsService
	{
		Task Execute(List<Answer> answers);
	}

	public class NotificationsService : INotificationsService
	{
		private readonly IMapper _mapper;
		private readonly IMediator _mediator;

		public NotificationsService(IMapper mapper, IMediator mediator)
		{
			_mapper = mapper;
			_mediator = mediator;
		}

		public async Task Execute(List<Answer> answers)
		{
			foreach (var answer in answers)
			{
				var answerSavedEvent = _mapper.Map<Answer, AnswerSavedEvent>(answer);
				await _mediator.Publish(answerSavedEvent);
			};
		}
	}
}
