using System.Data.Entity;
using Questionnaire.Core.Entities;
using Questionnaire.EFData.EFContext.Mappings;

namespace Questionnaire.EFData.EFContext
{
    public class QuestionnaireContext : DbContext
    {
        public DbSet<Respondent> Respondents { get; set; }
        public DbSet<Question> Questions { get; set; }

        public QuestionnaireContext()
        {

        }

        public QuestionnaireContext(string connectionString)
            : base(connectionString)
        {

        }

        #region Overrides of DbContext

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RespondentMap());
            modelBuilder.Configurations.Add(new QuestionMap());

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
