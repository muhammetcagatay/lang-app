namespace Vocabulary.API.Models.Entities
{
    public abstract class IEntity
    {
        public IEntity()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsDelete = false;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
