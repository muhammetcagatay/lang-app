const authApiURL = "https://localhost:7179/api/";

const authconcatURL = (url) => {
  return authApiURL.concat(url);
};

const Config = {
  service: {
    auth: {
      login: authconcatURL("auth/login"),
      refreshToken: authconcatURL("auth/refreshToken"),
    },
  },
};

export default Config;
