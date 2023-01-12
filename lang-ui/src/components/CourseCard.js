import Card from "@mui/material/Card";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";
import { useNavigate } from "react-router-dom";

const CourseCard = ({ image, title, content, courseId }) => {
  const navigate = useNavigate();
  const handleClick = (e) => {
    e.preventDefault();
    navigate(`/course/${courseId}`);
  };

  return (
    <div className="m-4">
      <Card sx={{ maxWidth: 345 }}>
        <CardMedia
          component="img"
          alt="green iguana"
          height="160"
          image={image}
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {title}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            {content}
          </Typography>
        </CardContent>
      </Card>
    </div>
  );
};

export default CourseCard;
