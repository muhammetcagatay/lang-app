namespace Speaking.Models.Dtos
{
    public class ScorDto
    {
        public class ScorResponseDto
        {
            public string OutputText { get; set; }
            public int TrueWord { get; set; }
            public int FalseWord { get; set; }
            public double AccuracyRate { get; set; }
        }
    }
}
