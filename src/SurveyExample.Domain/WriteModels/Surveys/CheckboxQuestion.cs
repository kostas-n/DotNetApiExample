using SurveyExample.Domain.Aggregates.Surveys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyExample.Domain.WriteModels.Surveys
{
	public class CheckboxQuestion : Question
	{
		public override string QuestionType => "checkbox";

		public List<QuestionOption> QuestionOptions { get; set; }
	}
}
