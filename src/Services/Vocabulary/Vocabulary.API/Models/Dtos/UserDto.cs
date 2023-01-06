namespace Vocabulary.API.Models.Dtos
{
    public class UserDto
    {
        public class UserRegisterCourseDto
        {
            public int UserId { get; set; }
            public int CourseId { get; set; }
        }
        public class UserReviewCardDto
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public bool IsFinish { get; set; }
            public int TrueCount { get; set; }
            public int FalseCount { get; set; }
            public int UserId { get; set; }
            public int CardId { get; set; }
        }
    }
}
