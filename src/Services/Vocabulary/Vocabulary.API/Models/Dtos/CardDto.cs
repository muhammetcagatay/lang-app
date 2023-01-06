namespace Vocabulary.API.Models.Dtos
{
    public class CardDto
    {
        public class CreateCardDto
        {
            public string Title { get; set; }
            public int CourseId { get; set; }
        }
    }
}
