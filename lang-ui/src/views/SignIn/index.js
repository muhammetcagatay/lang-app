import { useState } from "react";
import { Link } from "react-router-dom";
import "./SignIn.css";

const SignIn = () => {
  const [name, setName] = useState("");
  const [surname, setSurname] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [loading] = useState(false);

  const handleSubmit = async (e) => {};

  return (
    <div className="content">
      <div className="container">
        <div className="row">
          <div className="col-md-6 ">
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
                      required
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
                      required
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
                      required
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
                      required
                      pattern=".{8,}"
                      title="Şifreniz en az 8 karakter olmalıdır"
                    />
                  </div>
                  <div className="d-grid gap-2 mt-3">
                    <button type="submit" className="btn btn-primary">
                      {loading && (
                        <span className="spinner-border spinner-border-sm mr-1"></span>
                      )}
                      Kayıt
                    </button>
                  </div>
                  <div className="d-grid gap-2 mt-3">
                    <p className="text-dark">
                      Zaten hesabınız var mı? <Link to="/">Oturum Açın</Link>
                    </p>
                  </div>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default SignIn;
