using SurveyExample.Domain.ReadModels;
using SurveyExample.Domain.WriteModels.Responses;
using SurveyExample.Infrastructure.SQL.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace SurveyExample.Infrastructure.SQL
{
	public class SurveysDbContext: DbContext
	{
		public SurveysDbContext()
		{
			Database.EnsureCreated();
		}

		public DbSet<Response> Responses { get; set; }
		public DbSet<Answer> Answers { get; set; }
		public DbSet<ResponseBasicView> ResponseViews { get; set; }
		public DbSet<LatestAnswer> LatestAnswers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ResponseConfiguration());
			//modelBuilder.ApplyConfiguration(new AnswerConfiguration());
			//modelBuilder.ApplyConfiguration(new ResponsesViewConfiguration());
			//modelBuilder.ApplyConfiguration(new LatestAnswerConfiguration());
		}
	}
}
