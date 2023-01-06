import Account from "../views/Account";
import Course from "../views/Course";
import Home from "../views/Home";
import Login from "../views/Login";
import SignIn from "../views/SignIn";
import Vocabulary from "../views/Vocabulary";
import Word from "../views/Word";

const routes = [
  {
    path: "/login",
    component: <Login />,
  },
  {
    path: "/signin",
    component: <SignIn />,
  },
];

const protectedRoutes = [
  {
    path: "/",
    component: <Home />,
  },
  {
    path: "/vocabulary",
    component: <Vocabulary />,
  },
  {
    path: "/account",
    component: <Account />,
  },
  {
    path: "course/:courseId",
    component: <Course />,
  },
  {
    path: "word/:wordId",
    component: <Word />,
  },
];

export { routes, protectedRoutes };
