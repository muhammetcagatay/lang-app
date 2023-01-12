import { useEffect } from "react";
import { useState } from "react";
import CourseCard from "../../components/CourseCard";
import VocabularyService from "../../services/VocabularyService";

const Vocabulary = () => {
  const [courses, setCourses] = useState([]);

  useEffect(() => {
    const getData = async () => {
      await VocabularyService.GetCourses().then((response) => {
        console.log(response);
        setCourses(response.data);
      });
    };
    getData();
  }, []);

  return (
    <div className="container">
      <div className="row">
        {courses.map((course) => (
          <div className="col-4" key={course.id}>
            <CourseCard
              image={
                "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
              }
              title={course.title}
              courseId={1}
              content={course.description}
            />
          </div>
        ))}
      </div>
    </div>
  );
};

export default Vocabulary;
