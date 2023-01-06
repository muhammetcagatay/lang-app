import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import { AuthProvider } from "./contexts/AuthContext";
import AuthRoute from "./helpers/AuthRoute";
import { routes, protectedRoutes } from "./configs/routes";

const App = () => {
  return (
    <div className="App">
      <BrowserRouter>
        <AuthProvider>
          <Routes>
            {routes.map((route) => {
              return (
                <Route
                  key={route.path}
                  path={route.path}
                  element={route.component}
                />
              );
            })}

            <Route element={<AuthRoute />}>
              {protectedRoutes.map((route) => {
                return (
                  <Route
                    key={route.path}
                    path={route.path}
                    element={route.component}
                  />
                );
              })}
            </Route>
          </Routes>
        </AuthProvider>
      </BrowserRouter>
    </div>
  );
};

export default App;
