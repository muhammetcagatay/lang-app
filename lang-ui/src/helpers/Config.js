const apiURL = "http://localhost:5001/";

const concatURL = (url) => {
  return apiURL.concat(url);
};

const Config = {
  service: {
    auth: {
      login: concatURL("authservice/api/auth/login"),
      refreshToken: concatURL("auth/refreshToken"),
    },
    user: {
      create: concatURL("userservice/api/user"),
    },
    speaking: {
      sound: concatURL("speakingservice/api/sound"),
      text: concatURL("speakingservice/api/text"),
    },
    vocabulary: {
      getAll: concatURL("vocabularyservice/api/course"),
    },
  },
};

export default Config;
