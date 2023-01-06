namespace Scor.Models.Dtos
{
    public class ScorHistoryDto
    {
        public class ScorHistoryResponseDto
        {
            public int TrueAnswer { get; set; }
            public int FalseAnswer { get; set; }
            public DateTime? TotalTime { get; set; }
            public int Scor { get; set; }
        }
    }
}
