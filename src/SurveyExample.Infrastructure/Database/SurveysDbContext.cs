using SurveyExample.Domain.WriteModels.Responses;
using SurveyExample.Domain.ReadModels;
using SurveyExample.Infrastructure.Database.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace SurveyExample.Infrastructure.Database
{
	public class SurveysDbContext: DbContext
	{
		public DbSet<Response> Responses { get; set; }
		public DbSet<Answer> Answers { get; set; }
		public DbSet<ResponseBasicView> ResponseViews { get; set; }
		public DbSet<LatestAnswer> LatestAnswers { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile("appsettings.json")
			.Build();
			optionsBuilder.UseOracle(configuration.GetConnectionString("DefaultConnection"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ResponseConfiguration());
			modelBuilder.ApplyConfiguration(new AnswerConfiguration());
			modelBuilder.ApplyConfiguration(new ResponsesViewConfiguration());
			modelBuilder.ApplyConfiguration(new LatestAnswerConfiguration());
		}
	}
}
