using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyExample.Domain.Aggregates.Surveys
{
	public class TextQuestion : Question
	{
		public override string QuestionType => "text";
	}
}
