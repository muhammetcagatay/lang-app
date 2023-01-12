import { Link } from "react-router-dom";
import "./Page404.css";

const Page404 = () => {
  return (
    <div id="notfound">
      <div class="notfound">
        <div class="notfound-404">
          <h1>404</h1>
          <h2>Page not found</h2>
        </div>
        <Link to="/">Home</Link>
      </div>
    </div>
  );
};

export default Page404;
