import Footer from "./Footer";
import Header from "./Header";
import "./Layout.css";

const Layout = ({ children }) => {
  return (
    <div id="wrapper">
      <Header />
      <div className="content-page content-full">
        <div className="content">
          <div className="container-fluid ">{children}</div>
        </div>
        <Footer />
      </div>
    </div>
  );
};

export default Layout;
