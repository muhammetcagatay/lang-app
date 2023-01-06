import { useParams } from "react-router-dom";
import WordCard from "../../components/WordCard";

const Course = () => {
  const { courseId } = useParams();

  return (
    <div className="container">
      <div className="row">
        <div className="col-6">
          <div className="row">
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={courseId}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={2}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={3}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={4}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={5}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={6}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={7}
              />
            </div>
            <div className="col-3">
              <WordCard
                image={
                  "https://static.memrise.com/img/400sqf/from/uploads/immersion/ENUK1.jpg"
                }
                title={"Fırlatma Rampası"}
                number={8}
              />
            </div>
          </div>
        </div>
        <div className="col-6">Hello</div>
      </div>
    </div>
  );
};

export default Course;
