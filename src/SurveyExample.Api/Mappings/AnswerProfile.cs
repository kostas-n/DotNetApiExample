using AutoMapper;
using SurveyExample.Api.Dtos;
using SurveyExample.Domain.WriteModels.Responses;
using SurveyExample.Domain.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveyExample.Domain.Events.Internal;

namespace SurveyExample.Api.Mappings
{
	public class AnswerProfile: Profile
	{
		public AnswerProfile()
		{
			CreateMap<LatestAnswer, AnswerDto>();

			CreateMap<Answer, AnswerSavedEvent>()
				.ForMember(dest => dest.SetDtm, opt => opt.MapFrom(src => src.UpdatedDtm))
				.ForMember(dest => dest.TextValue, opt => opt.MapFrom(src => src.Text));

			CreateMap<AnswerSavedEvent, LatestAnswer>()
				.ForMember(dest => dest.ChangedDtm, opt => opt.MapFrom(src => src.SetDtm));
		}
	}
}
