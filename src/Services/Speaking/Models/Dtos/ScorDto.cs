namespace Speaking.Models.Dtos
{
    public class ScorDto
    {
        public class ScorResponseDto
        {
            public int TrueWord { get; set; }
            public int FalseWord { get; set; }
            public double AccuracyRate { get; set; }
        }
    }
}
