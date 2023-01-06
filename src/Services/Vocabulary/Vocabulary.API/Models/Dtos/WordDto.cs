namespace Vocabulary.API.Models.Dtos
{
    public class WordDto
    {
        public class CreateWordDto
        {
            public CreateWordDto()
            {
                FalseAnswers = new List<string>();
            }
            public string Context { get; set; }
            public string TrueAnswer { get; set; }
            public List<string> FalseAnswers { get; set; }
            public int CardId { get; set; }
        }
    }
}
