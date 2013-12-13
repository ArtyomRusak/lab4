using System;
using System.Data.Entity;
using System.Transactions;

namespace Questionnaire.EFData.EFContext.Initializers
{
    public class RecreateIfModelChanges : IDatabaseInitializer<QuestionnaireContext>
    {
        #region Implementation of IDatabaseInitializer<in QuestionnaireContext>

        public void InitializeDatabase(QuestionnaireContext context)
        {
            bool databaseExists;
            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                databaseExists = context.Database.Exists();
            }
            if (databaseExists)
            {
                if (context.Database.CompatibleWithModel(true))
                {
                    return;
                }
                context.Database.Delete();
            }
            context.Database.Create();
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Dispose();
                throw;
            }
        }

        #endregion
    }
}
