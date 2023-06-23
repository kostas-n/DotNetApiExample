using SurveyExample.Common;
using SurveyExample.Domain.WriteModels.Responses;
using System;

namespace SurveyExample.Domain.Events.Public
{
	public class ResponseSubmittedEvent
	{
		public Guid ResponseId { get; set; }
		public Guid SurveyId { get; set; }
		public DateTime SubmittedDate { get; set; }
	}
}
