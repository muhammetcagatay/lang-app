import Login from "../views/Login";
import Page404 from "../views/Page404";
import SignIn from "../views/SignIn";
import Speaking from "../views/Speaking";
import Vocabulary from "../views/Vocabulary";
const routes = [
  {
    path: "/login",
    component: <Login />,
  },
  {
    path: "/signin",
    component: <SignIn />,
  },
  {
    path: "*",
    component: <Page404 />,
  },
];

const protectedRoutes = [
  {
    path: "/",
    component: <Vocabulary />,
  },
  {
    path: "/vocabulary",
    component: <Vocabulary />,
  },
  {
    path: "speaking",
    component: <Speaking />,
  },
];

export { routes, protectedRoutes };
