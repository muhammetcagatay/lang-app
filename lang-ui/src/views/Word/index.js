import { useParams } from "react-router-dom";

const Word = () => {
  const { wordId } = useParams();
  return <div>Hello World {wordId}</div>;
};

export default Word;
