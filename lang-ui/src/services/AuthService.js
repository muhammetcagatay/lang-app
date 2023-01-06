import Config from "../helpers/Config";

const AuthService = {
  Login(email, password) {
    var requestOptions = {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ email, password }),
    };
    return fetch(Config.service.auth.login, requestOptions)
      .then((response) => {
        return response.json();
      })
      .then((json) => {
        return json;
      })
      .catch((error) => {
        return "Not connected to server";
      });
  },
  RefreshToken(refreshToken) {
    var requestOptions = {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ refreshToken }),
    };

    return fetch(Config.service.auth.refreshToken, requestOptions)
      .then((response) => {
        return response.json();
      })
      .then((json) => {
        return json;
      })
      .catch((error) => {
        return "Not connected to server";
      });
  },
};

export default AuthService;
