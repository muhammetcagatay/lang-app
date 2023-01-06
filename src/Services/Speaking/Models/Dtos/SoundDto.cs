namespace Speaking.Models.Dtos
{
    public class SoundDto
    {
        public class SoundRequestDto
        {
            public int UserId { get; set; }
            public int TextId { get; set; }
            public IFormFile AudioFile { get; set; }
        }
        public class SoundResponseDto
        {
            public int TrueWord { get; set; }
            public int FalseWord { get; set; }
            public double AccuracyRate { get; set; }
        }
    }
}
