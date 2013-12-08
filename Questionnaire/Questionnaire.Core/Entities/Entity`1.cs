namespace Questionnaire.Core.Entities
{
    public class Entity<TKey> : Entity
    {
        public TKey Id { get; set; }
    }
}
