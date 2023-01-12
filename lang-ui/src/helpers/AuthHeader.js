const AuthHeader = {
  GetHeader() {
    const token = JSON.parse(localStorage.getItem("auth"));
    if (token) {
      return {
        "Content-Type": "application/json",
        Authorization: "Bearer " + token.accessToken,
      };
    } else {
      return { "Content-Type": "application/json" };
    }
  },
};

export default AuthHeader;
