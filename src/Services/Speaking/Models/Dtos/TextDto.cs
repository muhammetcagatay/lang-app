namespace Speaking.Models.Dtos
{
    public class TextDto
    {
        public class TextResponseDto
        {
            public int Id { get; set; }
            public string TextContent { get; set; }
            public string Title { get; set; }
        }
        public class TextSpeechAPIDto
        {
            public string Text { get; set; }
        }
    }
}
