import { Alert } from "@mui/material";
import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import UserService from "../../services/UserService";
import "./SignIn.css";

const SignIn = () => {
  const [name, setName] = useState("");
  const [surname, setSurname] = useState("");
  const [age, setAge] = useState(0);
  const [city, setCity] = useState("");
  const [country, setCountry] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");
  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();
    setLoading(true);
    await UserService.Create(
      name,
      surname,
      age,
      city,
      country,
      email,
      password
    ).then((response) => {
      navigate("/login");
    });
    setLoading(false);
  };

  return (
    <div className="container">
      <div className="Auth-form-container">
        <form className="Auth-form" onSubmit={handleSubmit}>
          <div className="Auth-form-content">
            <h3 className="Auth-form-title">Kayıt Ol</h3>
            <div className="form-group mt-3">
              <label>Ad</label>
              <input
                type="text"
                className="form-control mt-1"
                placeholder="Adınızı giriniz"
                value={name}
                onChange={(e) => setName(e.target.value)}
              />
            </div>
            <div className="form-group mt-3">
              <label>Soyad</label>
              <input
                type="text"
                className="form-control mt-1"
                placeholder="Soyadınızı giriniz"
                value={surname}
                onChange={(e) => setSurname(e.target.value)}
              />
            </div>
            <div className="form-group mt-3">
              <label>Yaş</label>
              <input
                type="number"
                className="form-control mt-1"
                placeholder="Yaşınızı giriniz"
                value={age}
                onChange={(e) => setAge(e.target.value)}
              />
            </div>
            <div className="form-group mt-3">
              <label>İl</label>
              <input
                type="text"
                className="form-control mt-1"
                placeholder="Şehrinizi giriniz"
                value={city}
                onChange={(e) => setCity(e.target.value)}
              />
            </div>
            <div className="form-group mt-3">
              <label>Ülke</label>
              <input
                type="text"
                className="form-control mt-1"
                placeholder="Ülkenizi giriniz"
                value={country}
                onChange={(e) => setCountry(e.target.value)}
              />
            </div>
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
                Kayıt
              </button>
            </div>
            <div className="d-grid gap-2 mt-3">
              {error && <Alert severity="error">{error}</Alert>}
            </div>
            <div className="d-grid gap-2 mt-3">
              <p className="text-dark">
                Zaten hesabınız var mı ? <Link to="/login">Giriş Yap</Link>
              </p>
            </div>
          </div>
        </form>
      </div>
    </div>
  );
};

export default SignIn;
