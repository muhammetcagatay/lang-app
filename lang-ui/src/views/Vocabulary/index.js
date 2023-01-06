import CourseCard from "../../components/CourseCard";

const Vocabulary = () => {
  return (
    <div className="container">
      <div className="row">
        <div className="col-4">
          <CourseCard
            image={
              "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
            }
            title={"İngilizce 1"}
            courseId={1}
            content={
              "Lizards are a widespread group of squamate reptiles, with over 6,000species, ranging across all continents except Antarctica"
            }
          />
        </div>
        <div className="col-4">
          <CourseCard
            image={
              "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
            }
            courseId={2}
            title={"Lizard"}
            content={
              "Lizards are a widespread group of squamate reptiles, with over 6,000species, ranging across all continents except Antarctica"
            }
          />
        </div>
        <div className="col-4">
          <CourseCard
            image={
              "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
            }
            title={"Lizard"}
            courseId={3}
            content={
              "Lizards are a widespread group of squamate reptiles, with over 6,000species, ranging across all continents except Antarctica"
            }
          />
        </div>
        <div className="col-4">
          <CourseCard
            image={
              "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
            }
            courseId={4}
            title={"Lizard"}
            content={
              "Lizards are a widespread group of squamate reptiles, with over 6,000species, ranging across all continents except Antarctica"
            }
          />
        </div>
        <div className="col-4">
          <CourseCard
            image={
              "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
            }
            title={"Lizard"}
            courseId={5}
            content={
              "Lizards are a widespread group of squamate reptiles, with over 6,000species, ranging across all continents except Antarctica"
            }
          />
        </div>
        <div className="col-4">
          <CourseCard
            image={
              "https://www.dreamhost.com/blog/wp-content/uploads/2017/10/online_course-750x375.jpg"
            }
            title={"Lizard"}
            courseId={6}
            content={
              "Lizards are a widespread group of squamate reptiles, with over 6,000species, ranging across all continents except Antarctica"
            }
          />
        </div>
      </div>
    </div>
  );
};

export default Vocabulary;
