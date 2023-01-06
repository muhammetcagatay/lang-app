import { createContext, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import RefreshTokenCheck from "../helpers/RefreshTokenCheck";
import AuthService from "../services/AuthService";

const AuthContext = createContext();

const AuthProvider = ({ children }) => {
  const [error, setError] = useState(null);
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  useEffect(() => {
    const token = JSON.parse(localStorage.getItem("auth"));
    if (token) {
      if (RefreshTokenCheck(token)) {
      } else {
        window.location.reload();
      }
    } else {
    }
  }, []);

  const loginHandler = async (email, password) => {
    setLoading(true);
    await AuthService.Login(email, password).then((response) => {
      if (response.statusCode === 200) {
        localStorage.setItem("auth", JSON.stringify(response.data));
        navigate("/");
      } else if (response.statusCode === 404) {
        setError(response.errors);
      } else {
        setError(response);
      }
    });
    setLoading(false);
  };

  const logoutHandler = () => {
    localStorage.removeItem("auth");
    window.location.reload();
  };

  return (
    <AuthContext.Provider
      value={{ loginHandler, logoutHandler, loading, error }}
    >
      {children}
    </AuthContext.Provider>
  );
};

export { AuthContext, AuthProvider };
