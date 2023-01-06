import { Link } from "react-router-dom";
import "./ErrorPages.css";
const Page401 = () => {
  return (
    <div id="notfound">
      <div class="notfound">
        <div class="notfound-404">
          <h1>401</h1>
          <h2>Unauthorized</h2>
        </div>

        <Link to="/">Login</Link>
      </div>
    </div>
  );
};

export default Page401;
