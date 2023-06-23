using SurveyExample.ReadModel.ReadModelGenerators;
using SurveyExample.Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SurveyExample.Domain.Events.Internal;

namespace SurveyExample.Api.EventHandlers
{
	public class AnswerSavedEventHandler : INotificationHandler<AnswerSavedEvent>
	{
		private IAnswersViewGenerator _answersViewGenerator;

		public AnswerSavedEventHandler(IAnswersViewGenerator answersViewGenerator)
		{
			_answersViewGenerator = answersViewGenerator;
		}

		public async Task Handle(AnswerSavedEvent notification, CancellationToken cancellationToken)
		{
			await _answersViewGenerator.HandleEvent(notification);
			return;
		}
	}
}
