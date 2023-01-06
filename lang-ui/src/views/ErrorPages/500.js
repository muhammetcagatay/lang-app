import { Link } from "react-router-dom";
import "./ErrorPages.css";
const Page500 = () => {
  return (
    <div id="notfound">
      <div class="notfound">
        <div class="notfound-404">
          <h1>500</h1>
          <h2>Server Error</h2>
        </div>
        <Link to="/">Home</Link>
      </div>
    </div>
  );
};

export default Page500;
