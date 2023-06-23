using SurveyExample.Domain.WriteModels.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyExample.Infrastructure.SQL.EntityConfiguration
{
	public class ResponseConfiguration : IEntityTypeConfiguration<Response>
	{
		public void Configure(EntityTypeBuilder<Response> builder)
		{
			throw new NotImplementedException();
		}
	}
}
