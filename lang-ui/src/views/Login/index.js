import "./Login.css";

import { Link } from "react-router-dom";
import { useContext, useEffect, useState } from "react";
import { AuthContext } from "../../contexts/AuthContext";
import { Alert } from "@mui/material";

const Login = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const { loginHandler, loading, error } = useContext(AuthContext);

  useEffect(() => {
    localStorage.removeItem("auth");
  }, []);

  const handleSubmit = async (e) => {
    e.preventDefault();
    loginHandler(email, password);
  };

  return (
    <div className="container">
      <div className="Auth-form-container">
        <form className="Auth-form" onSubmit={handleSubmit}>
          <div className="Auth-form-content">
            <h3 className="Auth-form-title">Giriş Yap</h3>
            <div className="form-group mt-3">
              <label>Email</label>
              <input
                type="email"
                className="form-control mt-1"
                placeholder="Email adresinizi giriniz"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
              />
            </div>
            <div className="form-group mt-3">
              <label>Şifre</label>
              <input
                type="password"
                className="form-control mt-1"
                placeholder="Şifrenizi giriniz"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
              />
            </div>
            <div className="d-grid gap-2 mt-3">
              <button
                type="submit"
                className="btn btn-primary"
                disabled={loading}
              >
                {loading && (
                  <span className="spinner-border spinner-border-sm mr-1"></span>
                )}
                Giriş
              </button>
            </div>
            <div className="d-grid gap-2 mt-3">
              {error && <Alert severity="error">{error}</Alert>}
            </div>
            <div className="d-grid gap-2 mt-3">
              <p className="text-dark">
                Hesabınız yok mu? <Link to="/signin">Kaydol</Link>
              </p>
            </div>
          </div>
        </form>
      </div>
    </div>
  );
};

export default Login;
