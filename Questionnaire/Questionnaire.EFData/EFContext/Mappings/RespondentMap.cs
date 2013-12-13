using System.Data.Entity.ModelConfiguration;
using Questionnaire.Core.Entities;

namespace Questionnaire.EFData.EFContext.Mappings
{
    internal class RespondentMap : EntityTypeConfiguration<Respondent>
    {
        public RespondentMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Name).HasMaxLength(20).IsRequired();
            Property(e => e.Surname).HasMaxLength(30).IsRequired();
            Property(e => e.Patronymic).HasMaxLength(30).IsRequired();
        }
    }
}
