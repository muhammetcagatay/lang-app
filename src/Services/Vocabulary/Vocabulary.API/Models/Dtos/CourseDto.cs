namespace Vocabulary.API.Models.Dtos
{
    public class CourseDto
    {
        public class CreateCourseDto
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int UserId { get; set; }
        }
    }
}
