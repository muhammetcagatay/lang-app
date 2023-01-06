import AuthService from "../services/AuthService";

async function RefreshTokenCheck(token) {
  if (new Date(token.expiration) > new Date().getTime()) {
    return true;
  } else {
    localStorage.removeItem("auth");
    return await AuthService.RefreshToken(token.refreshToken).then(
      (response) => {
        if (response.statusCode === 200) {
          localStorage.setItem("auth", JSON.stringify(response.data));
          return true;
        } else {
          return false;
        }
      }
    );
  }
}

export default RefreshTokenCheck;
