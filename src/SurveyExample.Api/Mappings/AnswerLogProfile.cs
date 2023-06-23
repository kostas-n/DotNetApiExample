using AutoMapper;
using SurveyExample.Api.Dtos;
using SurveyExample.Domain.WriteModels.Responses;
using SurveyExample.Domain.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyExample.Api.Mappings
{
	public class AnswerLogProfile: Profile
	{
		public AnswerLogProfile()
		{
			CreateMap<AnswerChangeLogView, AnswerLogDto>();
		}
	}
}
