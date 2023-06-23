using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyExample.Api.Dtos
{
	public class NewResponseAnswersDto
	{
		public string ResponseId { get; set; }
		public List<NewAnswerDto> Answers { get; set; }
	}
}
