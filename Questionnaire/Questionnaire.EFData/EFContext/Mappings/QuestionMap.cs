using System.Data.Entity.ModelConfiguration;
using Questionnaire.Core.Entities;

namespace Questionnaire.EFData.EFContext.Mappings
{
    internal class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Hobbies).HasMaxLength(250).IsRequired();
            Property(e => e.PetAnimals).HasMaxLength(250).IsRequired();
            Property(e => e.SeasonsOfTheYear).HasMaxLength(250).IsRequired();
            Property(e => e.Subjects).HasMaxLength(200).IsRequired();
            Property(e => e.Age).IsRequired();
            Property(e => e.Like).IsRequired();
            HasRequired(e => e.Respondent).WithMany().HasForeignKey(e => e.RespondentId);
        }
    }
}
