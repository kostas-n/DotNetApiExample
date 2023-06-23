using SurveyExample.Common;
using SurveyExample.Domain.WriteModels.Responses;
using System;

namespace SurveyExample.Domain.Events.Public
{
	public class ResponseCreatedEvent
	{
		public Guid ResponseId { get; set; }
		public Guid SurveyId { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
