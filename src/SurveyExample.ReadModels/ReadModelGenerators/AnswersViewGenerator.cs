using AutoMapper;
using SurveyExample.Common;
using SurveyExample.Domain.Events;
using SurveyExample.Domain.Events.Internal;
using SurveyExample.Domain.ReadModels;
using SurveyExample.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyExample.ReadModel.ReadModelGenerators
{
	public interface IAnswersViewGenerator : IReadModelGenerator<AnswerSavedEvent>
	{

	}

	public class AnswersViewGenerator : IAnswersViewGenerator
	{
		private IMapper _mapper;
		private IResponsesRepository _responsesRepo;

		public AnswersViewGenerator(IMapper mapper, IResponsesRepository responsesRepo)
		{
			_mapper = mapper;
			_responsesRepo = responsesRepo;
		}

		public async Task HandleEvent(AnswerSavedEvent e)
		{
			var latestAnswer = _mapper.Map<AnswerSavedEvent, LatestAnswer>(e);
			_responsesRepo.SetLatestAnswer(latestAnswer);
			await _responsesRepo.Save();
		}
	}
}
