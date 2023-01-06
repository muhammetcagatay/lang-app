import { Navigate, Outlet } from "react-router-dom";
import Layout from "../views/Layout";

const AuthRoute = () => {
  const isAuth = localStorage.getItem("auth");
  return isAuth ? (
    <Layout>
      <Outlet />
    </Layout>
  ) : (
    <Navigate to="/login" exact />
  );
};

export default AuthRoute;
