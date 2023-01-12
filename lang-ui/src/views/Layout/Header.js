const Header = () => {
  const handleLogout = () => {
    localStorage.removeItem("auth");
    window.location.reload();
  };
  return (
    <header>
      <nav
        className="navbar navbar-expand-lg  text-light mb-5"
        style={{ background: "#6c63ff" }}
      >
        <div className="container">
          <div className="row w-100">
            <div className="col-2 text-center">
              <a href="/">
                <img
                  src="https://static.memrise.com/dist/img/header/logo-c3ae0edc1913.svg"
                  alt="logo"
                />
              </a>
            </div>

            <div className="collapse navbar-collapse col-10 text-right">
              <ul className="navbar-nav me-auto mb-2 mb-lg-1">
                <li className="nav-item">
                  <a className="nav-link text-white" href="/vocabulary">
                    Kelime
                  </a>
                </li>
                <li className="nav-item">
                  <a className="nav-link text-white" href="/speaking">
                    Konuşma
                  </a>
                </li>
                <li className="nav-item">
                  <a
                    onClick={handleLogout}
                    className="nav-link text-white"
                    href="#login"
                  >
                    Çıkış
                  </a>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </nav>
    </header>
  );
};
export default Header;
