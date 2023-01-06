import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { CardActionArea } from "@mui/material";
import { useNavigate } from "react-router-dom";

const WordCard = ({ number, image, title }) => {
  const navigate = useNavigate();
  return (
    <div className="m-2">
      <Card
        sx={{ maxWidth: 125 }}
        onClick={() => {
          navigate(`/word/${number}`);
        }}
      >
        <CardActionArea>
          <Typography gutterBottom variant="p" component="div">
            {number}
          </Typography>
          <CardMedia
            component="img"
            height="130"
            image={image}
            alt="green iguana"
          />
          <CardContent>
            <Typography gutterBottom variant="p" component="div">
              {title}
            </Typography>
          </CardContent>
        </CardActionArea>
      </Card>
    </div>
  );
};

export default WordCard;
